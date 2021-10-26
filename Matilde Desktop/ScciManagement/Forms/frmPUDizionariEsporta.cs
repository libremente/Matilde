﻿using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace UnicodeSrl.ScciManagement
{
    public partial class frmPUDizionariEsporta : Form, Interfacce.IViewFormBase
    {
        public frmPUDizionariEsporta()
        {
            InitializeComponent();
        }

        #region Declare

        private const string C_COL_SEL = "SEL";
        private const string C_COL_COD = "NewCod";
        private const string C_COL_DESC = "NewDesc";

        #endregion

        #region Interface

        public Icon ViewIcon
        {
            get
            {
                return this.Icon;
            }
            set
            {
                this.Icon = value;
            }
        }

        public string ViewText
        {
            get
            {
                return (string)this.Tag;
            }
            set
            {
                this.Tag = value;
                this.Text = value;
            }
        }

        public void ViewInit()
        {
            this.InitializeSaveFileDialog();
            this.InitializeUltraGrid();

            this.LoadUltraGrid();
        }

        #endregion

        #region Public Properties

        public Image ViewImage
        {
            get
            {
                return this.picView.Image;
            }
            set
            {
                this.picView.Image = value;
            }
        }

        #endregion

        #region Initialize

        private void InitializeSaveFileDialog()
        {
            this.saveFileDialog.FileName = string.Empty;
            this.saveFileDialog.Filter = "File XML (*.xml)|*.xml|Tutti i file|*.*";
            this.saveFileDialog.FilterIndex = 0;
            this.saveFileDialog.CheckPathExists = true;
            this.saveFileDialog.OverwritePrompt = true;
            this.saveFileDialog.Title = "Seleziona il percorso ed il nome file di esportazione";
        }

        private void InitializeUltraGrid()
        {
            MyStatics.SetUltraGridLayout(ref this.UltraGrid, true, false);
            this.UltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.UltraGrid.DisplayLayout.Override.RowSelectors = DefaultableBoolean.False;
            this.UltraGrid.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True;
            this.UltraGrid.UpdateMode = UpdateMode.OnCellChangeOrLostFocus;
        }

        private void LoadUltraGrid()
        {
            DataTable odtTemp = null;
            DataTable odtFinal = null;

            try
            {
                odtTemp = DataBase.GetDataTable("SELECT * FROM T_DCDecodifiche ORDER BY Codice");

                if (odtTemp != null && odtTemp.Rows.Count > 0)
                {
                    odtFinal = new DataTable();

                    odtFinal.Columns.Add(C_COL_SEL, typeof(bool));

                    foreach (DataColumn dtc in odtTemp.Columns)
                    {
                        odtFinal.Columns.Add(dtc.ColumnName, dtc.DataType);
                    }

                    odtFinal.Columns.Add(C_COL_COD, typeof(string));
                    odtFinal.Columns.Add(C_COL_DESC, typeof(string));

                    foreach (DataRow dtr in odtTemp.Rows)
                    {
                        DataRow dradd = odtFinal.NewRow();

                        dradd[C_COL_SEL] = false;

                        foreach (DataColumn dtc in odtTemp.Columns)
                        {
                            dradd[dtc.ColumnName] = dtr[dtc.ColumnName];
                        }

                        dradd[C_COL_COD] = dtr["Codice"];
                        dradd[C_COL_DESC] = dtr["Descrizione"];

                        odtFinal.Rows.Add(dradd);
                    }
                }

                this.UltraGrid.DataSource = odtFinal;
                this.UltraGrid.Refresh();
                this.UltraGrid.Text = string.Format("{0} ({1:#,##0})", "Dizionari: ", this.UltraGrid.Rows.Count);

                this.UltraGrid.DisplayLayout.PerformAutoResizeColumns(false, PerformAutoSizeType.AllRowsInBand);
            }
            catch (Exception ex)
            {
                UnicodeSrl.Framework.Diagnostics.Statics.AddDebugInfo(ex);
            }

        }

        #endregion

        #region Subroutine

        private bool CheckInput()
        {

            bool bRet = true;

            if (this.uteFilePath.Text == string.Empty)
            {
                MessageBox.Show(@"Inserire " + this.lblFilePath.Text + @"!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.uteFilePath.Focus();
                bRet = false;
            }

            if (bRet)
            {
                if (!Directory.Exists(Path.GetDirectoryName(this.uteFilePath.Text)))
                {
                    MessageBox.Show(@"Percorso di salvataggio inesistente!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.uteFilePath.Focus();
                    bRet = false;
                }
            }

            if (bRet)
            {
                List<UltraGridRow> rowlist = this.UltraGrid.Rows.ToList<UltraGridRow>().FindAll(r => Boolean.Parse(r.Cells[C_COL_SEL].Value.ToString()) == true);

                if (rowlist == null || rowlist.Count == 0)
                {
                    MessageBox.Show(@"Selezionare almeno un dizionario per l'esportazione!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.UltraGrid.Focus();
                    bRet = false;
                }
            }

            return bRet;
        }

        private void Export()
        {
            DataTable odttemp = null;
            string ssql = string.Empty;
            List<UltraGridRow> rowlist = null;
            XmlSerializer ser = null;
            TextWriter writer = null;

            DizionariExport dizexp = null;

            try
            {

                dizexp = new DizionariExport();

                rowlist = this.UltraGrid.Rows.ToList<UltraGridRow>().FindAll(r => Boolean.Parse(r.Cells[C_COL_SEL].Value.ToString()) == true);

                foreach (UltraGridRow row in rowlist)
                {

                    DizionarioExport dz = new DizionarioExport();
                    dz.Codice = row.Cells[C_COL_COD].Value.ToString();
                    dz.Descrizione = row.Cells[C_COL_DESC].Value.ToString();

                    ssql = "select * from T_DCDecodificheValori where CodDec = '" + row.Cells["Codice"].Value.ToString() + "'";
                    odttemp = DataBase.GetDataTable(ssql);

                    foreach (DataRow dr in odttemp.Rows)
                    {
                        VoceDizionarioExport v = new VoceDizionarioExport();

                        foreach (DataColumn dc in odttemp.Columns)
                        {
                            ExportField f = new ExportField();

                            f.Name = dc.ColumnName;
                            f.DataType = dc.DataType.ToString();

                            if (f.Name == "CodDec")
                                f.Value = System.Security.SecurityElement.Escape(row.Cells[C_COL_COD].Value.ToString());
                            else if (f.Name == "Icona")
                                f.Value = System.Security.SecurityElement.Escape(this.byteArrayToString(dr[dc.ColumnName]));
                            else
                                f.Value = System.Security.SecurityElement.Escape(dr[dc.ColumnName].ToString());

                            v.Fields.Add(f);
                        }

                        dz.Voci.Add(v);
                    }

                    dizexp.Dizionari.Add(dz);
                }

                ser = new XmlSerializer(typeof(DizionariExport));
                writer = new StreamWriter(this.uteFilePath.Text);
                ser.Serialize(writer, dizexp);

            }
            catch (Exception ex)
            {
                UnicodeSrl.Framework.Diagnostics.Statics.AddDebugInfo(ex);
            }
            finally
            {
                if (rowlist != null)
                {
                    rowlist = null;
                }

                if (odttemp != null)
                {
                    odttemp.Dispose();
                    odttemp = null;
                }

                if (writer != null)
                {
                    writer.Close();
                    writer.Dispose();
                    writer = null;
                }

            }
        }

        private string byteArrayToString(object byteArray)
        {

            string sRet = "";

            try
            {
                if (byteArray != null && byteArray != DBNull.Value)
                {
                    sRet = "0x" + BitConverter.ToString((byte[])byteArray).Replace("-", "");
                }
                else
                    sRet = string.Empty;
            }
            catch
            {
                sRet = string.Empty;
            }

            return sRet;
        }

        #endregion

        #region Events

        private void UltraGrid_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            foreach (var col in e.Layout.Bands[0].Columns)
            {
                switch (col.Key)
                {
                    case C_COL_SEL:
                        col.Header.CheckBoxSynchronization = HeaderCheckBoxSynchronization.Band;
                        col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                        col.CellClickAction = CellClickAction.Edit;
                        col.CellActivation = Activation.AllowEdit;
                        col.Header.Caption = string.Empty;
                        break;

                    case C_COL_COD:
                        col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Default;
                        col.CellClickAction = CellClickAction.Edit;
                        col.CellActivation = Activation.AllowEdit;
                        col.Header.Caption = "Nuovo Codice";
                        break;

                    case C_COL_DESC:
                        col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Default;
                        col.CellClickAction = CellClickAction.Edit;
                        col.CellActivation = Activation.AllowEdit;
                        col.Header.Caption = "Nuova Descrizione";
                        break;

                    default:
                        col.CellClickAction = CellClickAction.RowSelect;
                        col.CellActivation = Activation.ActivateOnly;
                        break;
                }
            }
        }

        private void ubFilePath_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.uteFilePath.Text = this.saveFileDialog.FileName;
            }
        }

        private void ubAnnulla_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void ubConferma_Click(object sender, EventArgs e)
        {
            if (this.CheckInput())
            {
                this.Cursor = Cursors.WaitCursor;
                this.Export();
                this.Cursor = Cursors.Default;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        #endregion
    }
}
