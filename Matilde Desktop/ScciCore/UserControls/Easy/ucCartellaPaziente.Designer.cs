﻿namespace UnicodeSrl.ScciCore
{
    partial class ucCartellaPaziente
    {
                                private System.ComponentModel.IContainer components = null;

                                        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

                                        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.UltraGroupBox = new Infragistics.Win.Misc.UltraGroupBox();
            this.UltraPanel = new Infragistics.Win.Misc.UltraPanel();
            this.ucRtfAlertAllergieAnamnesi = new UnicodeSrl.ScciCore.ucRtf();
            this.ucRtfAlertGenerici = new UnicodeSrl.ScciCore.ucRtf();
            this.ucRtfDatiMancanti = new UnicodeSrl.ScciCore.ucRtf();
            this.ucRtfEvidenzaClinica = new UnicodeSrl.ScciCore.ucRtf();
            this.ucRtfDatiRilievo = new UnicodeSrl.ScciCore.ucRtf();
            this.ucRtfOrdini = new UnicodeSrl.ScciCore.ucRtf();
            this.ucRtfParametriVitali = new UnicodeSrl.ScciCore.ucRtf();
            this.ucRtfAppuntamenti = new UnicodeSrl.ScciCore.ucRtf();
            this.ucRtfTaskInfermieristici = new UnicodeSrl.ScciCore.ucRtf();
            this.ultraToolTipManager1 = new Infragistics.Win.UltraWinToolTip.UltraToolTipManager(this.components);
            this.UltraPopupControlContainer = new Infragistics.Win.Misc.UltraPopupControlContainer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox)).BeginInit();
            this.UltraGroupBox.SuspendLayout();
            this.UltraPanel.ClientArea.SuspendLayout();
            this.UltraPanel.SuspendLayout();
            this.SuspendLayout();
                                                this.UltraGroupBox.Controls.Add(this.UltraPanel);
            this.UltraGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox.Location = new System.Drawing.Point(0, 0);
            this.UltraGroupBox.Name = "UltraGroupBox";
            this.UltraGroupBox.Size = new System.Drawing.Size(1024, 600);
            this.UltraGroupBox.TabIndex = 4;
            this.UltraGroupBox.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
                                                appearance1.BackColor = System.Drawing.Color.Transparent;
            this.UltraPanel.Appearance = appearance1;
                                                this.UltraPanel.ClientArea.Controls.Add(this.ucRtfAlertAllergieAnamnesi);
            this.UltraPanel.ClientArea.Controls.Add(this.ucRtfAlertGenerici);
            this.UltraPanel.ClientArea.Controls.Add(this.ucRtfDatiMancanti);
            this.UltraPanel.ClientArea.Controls.Add(this.ucRtfEvidenzaClinica);
            this.UltraPanel.ClientArea.Controls.Add(this.ucRtfDatiRilievo);
            this.UltraPanel.ClientArea.Controls.Add(this.ucRtfOrdini);
            this.UltraPanel.ClientArea.Controls.Add(this.ucRtfParametriVitali);
            this.UltraPanel.ClientArea.Controls.Add(this.ucRtfAppuntamenti);
            this.UltraPanel.ClientArea.Controls.Add(this.ucRtfTaskInfermieristici);
            this.UltraPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraPanel.Location = new System.Drawing.Point(3, 3);
            this.UltraPanel.Name = "UltraPanel";
            this.UltraPanel.Size = new System.Drawing.Size(1018, 594);
            this.UltraPanel.TabIndex = 3;
            this.UltraPanel.Resize += new System.EventHandler(this.UltraPanel_Resize);
                                                this.ucRtfAlertAllergieAnamnesi.ColonnaRTFResize = "";
            this.ucRtfAlertAllergieAnamnesi.Dati = null;
            this.ucRtfAlertAllergieAnamnesi.FattoreRidimensionamentoRTF = 21;
            this.ucRtfAlertAllergieAnamnesi.Immagine = null;
            this.ucRtfAlertAllergieAnamnesi.Location = new System.Drawing.Point(3, 3);
            this.ucRtfAlertAllergieAnamnesi.Name = "ucRtfAlertAllergieAnamnesi";
            this.ucRtfAlertAllergieAnamnesi.Size = new System.Drawing.Size(500, 100);
            this.ucRtfAlertAllergieAnamnesi.TabIndex = 0;
            this.ucRtfAlertAllergieAnamnesi.Titolo = "";
            this.ucRtfAlertAllergieAnamnesi.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ucRtf_ClickCell);
            this.ucRtfAlertAllergieAnamnesi.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.ucRtf_InitializeLayout);
                                                this.ucRtfAlertGenerici.ColonnaRTFResize = "";
            this.ucRtfAlertGenerici.Dati = null;
            this.ucRtfAlertGenerici.FattoreRidimensionamentoRTF = 21;
            this.ucRtfAlertGenerici.Immagine = null;
            this.ucRtfAlertGenerici.Location = new System.Drawing.Point(3, 106);
            this.ucRtfAlertGenerici.Name = "ucRtfAlertGenerici";
            this.ucRtfAlertGenerici.Size = new System.Drawing.Size(500, 100);
            this.ucRtfAlertGenerici.TabIndex = 1;
            this.ucRtfAlertGenerici.Titolo = "";
            this.ucRtfAlertGenerici.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ucRtf_ClickCell);
            this.ucRtfAlertGenerici.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.ucRtf_InitializeLayout);
                                                this.ucRtfDatiMancanti.ColonnaRTFResize = "";
            this.ucRtfDatiMancanti.Dati = null;
            this.ucRtfDatiMancanti.FattoreRidimensionamentoRTF = 21;
            this.ucRtfDatiMancanti.Immagine = null;
            this.ucRtfDatiMancanti.Location = new System.Drawing.Point(3, 207);
            this.ucRtfDatiMancanti.Name = "ucRtfDatiMancanti";
            this.ucRtfDatiMancanti.Size = new System.Drawing.Size(500, 100);
            this.ucRtfDatiMancanti.TabIndex = 2;
            this.ucRtfDatiMancanti.Titolo = "";
            this.ucRtfDatiMancanti.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ucRtf_ClickCell);
            this.ucRtfDatiMancanti.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.ucRtfDatiMancanti_InitializeLayout);
                                                this.ucRtfEvidenzaClinica.ColonnaRTFResize = "";
            this.ucRtfEvidenzaClinica.Dati = null;
            this.ucRtfEvidenzaClinica.FattoreRidimensionamentoRTF = 21;
            this.ucRtfEvidenzaClinica.Immagine = null;
            this.ucRtfEvidenzaClinica.Location = new System.Drawing.Point(506, 150);
            this.ucRtfEvidenzaClinica.Name = "ucRtfEvidenzaClinica";
            this.ucRtfEvidenzaClinica.Size = new System.Drawing.Size(509, 145);
            this.ucRtfEvidenzaClinica.TabIndex = 0;
            this.ucRtfEvidenzaClinica.Titolo = "";
            this.ucRtfEvidenzaClinica.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ucRtf_ClickCell);
            this.ucRtfEvidenzaClinica.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.ucRtf_InitializeLayout);
                                                this.ucRtfDatiRilievo.ColonnaRTFResize = "";
            this.ucRtfDatiRilievo.Dati = null;
            this.ucRtfDatiRilievo.FattoreRidimensionamentoRTF = 21;
            this.ucRtfDatiRilievo.Immagine = null;
            this.ucRtfDatiRilievo.Location = new System.Drawing.Point(3, 310);
            this.ucRtfDatiRilievo.Name = "ucRtfDatiRilievo";
            this.ucRtfDatiRilievo.Size = new System.Drawing.Size(500, 100);
            this.ucRtfDatiRilievo.TabIndex = 3;
            this.ucRtfDatiRilievo.Titolo = "";
            this.ucRtfDatiRilievo.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ucRtf_ClickCell);
            this.ucRtfDatiRilievo.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.ucRtfDatiRilievo_InitializeLayout);
                                                this.ucRtfOrdini.ColonnaRTFResize = "";
            this.ucRtfOrdini.Dati = null;
            this.ucRtfOrdini.FattoreRidimensionamentoRTF = 21;
            this.ucRtfOrdini.Immagine = null;
            this.ucRtfOrdini.Location = new System.Drawing.Point(506, 298);
            this.ucRtfOrdini.Name = "ucRtfOrdini";
            this.ucRtfOrdini.Size = new System.Drawing.Size(509, 145);
            this.ucRtfOrdini.TabIndex = 1;
            this.ucRtfOrdini.Titolo = "";
            this.ucRtfOrdini.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ucRtf_ClickCell);
            this.ucRtfOrdini.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.ucRtfOrdini_InitializeLayout);
                                                this.ucRtfParametriVitali.ColonnaRTFResize = "";
            this.ucRtfParametriVitali.Dati = null;
            this.ucRtfParametriVitali.FattoreRidimensionamentoRTF = 21;
            this.ucRtfParametriVitali.Immagine = null;
            this.ucRtfParametriVitali.Location = new System.Drawing.Point(3, 413);
            this.ucRtfParametriVitali.Name = "ucRtfParametriVitali";
            this.ucRtfParametriVitali.Size = new System.Drawing.Size(500, 100);
            this.ucRtfParametriVitali.TabIndex = 4;
            this.ucRtfParametriVitali.Titolo = "";
            this.ucRtfParametriVitali.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ucRtf_ClickCell);
            this.ucRtfParametriVitali.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.ucRtf_InitializeLayout);
                                                this.ucRtfAppuntamenti.ColonnaRTFResize = "";
            this.ucRtfAppuntamenti.Dati = null;
            this.ucRtfAppuntamenti.FattoreRidimensionamentoRTF = 21;
            this.ucRtfAppuntamenti.Immagine = null;
            this.ucRtfAppuntamenti.Location = new System.Drawing.Point(506, 446);
            this.ucRtfAppuntamenti.Name = "ucRtfAppuntamenti";
            this.ucRtfAppuntamenti.Size = new System.Drawing.Size(509, 145);
            this.ucRtfAppuntamenti.TabIndex = 2;
            this.ucRtfAppuntamenti.Titolo = "";
            this.ucRtfAppuntamenti.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ucRtf_ClickCell);
            this.ucRtfAppuntamenti.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.ucRtf_InitializeLayout);
                                                this.ucRtfTaskInfermieristici.ColonnaRTFResize = "";
            this.ucRtfTaskInfermieristici.Dati = null;
            this.ucRtfTaskInfermieristici.FattoreRidimensionamentoRTF = 21;
            this.ucRtfTaskInfermieristici.Immagine = null;
            this.ucRtfTaskInfermieristici.Location = new System.Drawing.Point(506, 3);
            this.ucRtfTaskInfermieristici.Name = "ucRtfTaskInfermieristici";
            this.ucRtfTaskInfermieristici.Size = new System.Drawing.Size(509, 145);
            this.ucRtfTaskInfermieristici.TabIndex = 5;
            this.ucRtfTaskInfermieristici.Titolo = "";
            this.ucRtfTaskInfermieristici.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ucRtf_ClickCell);
            this.ucRtfTaskInfermieristici.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.ucRtf_InitializeLayout);
                                                this.ultraToolTipManager1.ContainingControl = this;
                                                this.UltraPopupControlContainer.Opening += new System.ComponentModel.CancelEventHandler(this.UltraPopupControlContainer_Opening);
            this.UltraPopupControlContainer.Opened += new System.EventHandler(this.UltraPopupControlContainer_Opened);
            this.UltraPopupControlContainer.Closed += new System.EventHandler(this.UltraPopupControlContainer_Closed);
                                                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.UltraGroupBox);
            this.Name = "ucCartellaPaziente";
            this.Size = new System.Drawing.Size(1024, 600);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox)).EndInit();
            this.UltraGroupBox.ResumeLayout(false);
            this.UltraPanel.ClientArea.ResumeLayout(false);
            this.UltraPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox UltraGroupBox;
        private Infragistics.Win.Misc.UltraPanel UltraPanel;
        private ucRtf ucRtfAlertAllergieAnamnesi;
        private ucRtf ucRtfAlertGenerici;
        private ucRtf ucRtfDatiMancanti;
        private ucRtf ucRtfDatiRilievo;
        private ucRtf ucRtfParametriVitali;
        private ucRtf ucRtfTaskInfermieristici;
        private ucRtf ucRtfEvidenzaClinica;
        private ucRtf ucRtfOrdini;
        private ucRtf ucRtfAppuntamenti;
        private Infragistics.Win.UltraWinToolTip.UltraToolTipManager ultraToolTipManager1;
        private Infragistics.Win.Misc.UltraPopupControlContainer UltraPopupControlContainer;
    }
}
