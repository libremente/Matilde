﻿namespace UnicodeSrl.ScciCore
{
    partial class ucEasyDevExpressViewer
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
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEasyDevExpressViewer));
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            this.ucEasyTableLayoutPanel = new UnicodeSrl.ScciCore.ucEasyTableLayoutPanel(this.components);
            this.uchkBookmark = new UnicodeSrl.ScciCore.ucEasyStateButton();
            this.ubPrint = new UnicodeSrl.ScciCore.ucEasyButton();
            this.ubPagDown = new UnicodeSrl.ScciCore.ucEasyButton();
            this.ubPagUp = new UnicodeSrl.ScciCore.ucEasyButton();
            this.ubWholePage = new UnicodeSrl.ScciCore.ucEasyButton();
            this.ubPageWidth = new UnicodeSrl.ScciCore.ucEasyButton();
            this.ubZoomOut = new UnicodeSrl.ScciCore.ucEasyButton();
            this.ubZoomIn = new UnicodeSrl.ScciCore.ucEasyButton();
            this.Viewer = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.ucEasyTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
                                                this.ucEasyTableLayoutPanel.ColumnCount = 2;
            this.ucEasyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91F));
            this.ucEasyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.ucEasyTableLayoutPanel.Controls.Add(this.uchkBookmark, 1, 7);
            this.ucEasyTableLayoutPanel.Controls.Add(this.ubPrint, 1, 6);
            this.ucEasyTableLayoutPanel.Controls.Add(this.ubPagDown, 1, 5);
            this.ucEasyTableLayoutPanel.Controls.Add(this.ubPagUp, 1, 4);
            this.ucEasyTableLayoutPanel.Controls.Add(this.ubWholePage, 1, 3);
            this.ucEasyTableLayoutPanel.Controls.Add(this.ubPageWidth, 1, 2);
            this.ucEasyTableLayoutPanel.Controls.Add(this.ubZoomOut, 1, 1);
            this.ucEasyTableLayoutPanel.Controls.Add(this.ubZoomIn, 1, 0);
            this.ucEasyTableLayoutPanel.Controls.Add(this.Viewer, 0, 0);
            this.ucEasyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEasyTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ucEasyTableLayoutPanel.Name = "ucEasyTableLayoutPanel";
            this.ucEasyTableLayoutPanel.RowCount = 8;
            this.ucEasyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.ucEasyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.ucEasyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.ucEasyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.ucEasyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.ucEasyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.ucEasyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.ucEasyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.ucEasyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ucEasyTableLayoutPanel.Size = new System.Drawing.Size(815, 541);
            this.ucEasyTableLayoutPanel.TabIndex = 0;
                                                appearance9.FontData.SizeInPoints = 15.58209F;
            appearance9.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance9.ImageBackground")));
            appearance9.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance9.ImageVAlign = Infragistics.Win.VAlign.Top;
            appearance9.TextHAlignAsString = "Center";
            appearance9.TextVAlignAsString = "Bottom";
            this.uchkBookmark.Appearance = appearance9;
            this.uchkBookmark.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2003ToolbarButton;
            this.uchkBookmark.Checked = false;
            this.uchkBookmark.CheckedImage = null;
            this.uchkBookmark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uchkBookmark.Location = new System.Drawing.Point(744, 493);
            this.uchkBookmark.Name = "uchkBookmark";
            this.uchkBookmark.PercImageFill = 0.75F;
            this.uchkBookmark.ShortcutColor = System.Drawing.Color.Black;
            this.uchkBookmark.ShortcutFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions.XSmall;
            this.uchkBookmark.ShortcutKey = System.Windows.Forms.Keys.I;
            this.uchkBookmark.ShortcutPosition = UnicodeSrl.ScciCore.easyStatics.easyShortcutPosition.top_right;
            this.uchkBookmark.Size = new System.Drawing.Size(68, 45);
            this.uchkBookmark.TabIndex = 15;
            this.uchkBookmark.TextFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions.Small;
            this.uchkBookmark.UNCheckedImage = null;
            this.uchkBookmark.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.uchkBookmark.Click += new System.EventHandler(this.uchkBookmark_Click);
                                                appearance10.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance10.ImageVAlign = Infragistics.Win.VAlign.Middle;
            appearance10.TextHAlignAsString = "Center";
            appearance10.TextVAlignAsString = "Bottom";
            this.ubPrint.Appearance = appearance10;
            this.ubPrint.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2003ToolbarButton;
            this.ubPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubPrint.Location = new System.Drawing.Point(744, 423);
            this.ubPrint.Name = "ubPrint";
            this.ubPrint.PercImageFill = 0.75F;
            this.ubPrint.ShortcutColor = System.Drawing.Color.Black;
            this.ubPrint.ShortcutFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions.Small;
            this.ubPrint.ShortcutKey = System.Windows.Forms.Keys.None;
            this.ubPrint.ShortcutPosition = UnicodeSrl.ScciCore.easyStatics.easyShortcutPosition.top_right;
            this.ubPrint.Size = new System.Drawing.Size(68, 64);
            this.ubPrint.TabIndex = 8;
            this.ubPrint.TextFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions._undefined;
            this.ubPrint.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.ubPrint.Click += new System.EventHandler(this.ubPrint_Click);
                                                appearance11.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance11.ImageVAlign = Infragistics.Win.VAlign.Middle;
            appearance11.TextHAlignAsString = "Center";
            appearance11.TextVAlignAsString = "Bottom";
            this.ubPagDown.Appearance = appearance11;
            this.ubPagDown.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2003ToolbarButton;
            this.ubPagDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubPagDown.Location = new System.Drawing.Point(744, 353);
            this.ubPagDown.Name = "ubPagDown";
            this.ubPagDown.PercImageFill = 0.75F;
            this.ubPagDown.ShortcutColor = System.Drawing.Color.Black;
            this.ubPagDown.ShortcutFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions.Small;
            this.ubPagDown.ShortcutKey = System.Windows.Forms.Keys.None;
            this.ubPagDown.ShortcutPosition = UnicodeSrl.ScciCore.easyStatics.easyShortcutPosition.top_right;
            this.ubPagDown.Size = new System.Drawing.Size(68, 64);
            this.ubPagDown.TabIndex = 7;
            this.ubPagDown.TextFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions._undefined;
            this.ubPagDown.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.ubPagDown.Click += new System.EventHandler(this.ubPagDown_Click);
                                                appearance12.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance12.ImageVAlign = Infragistics.Win.VAlign.Middle;
            appearance12.TextHAlignAsString = "Center";
            appearance12.TextVAlignAsString = "Bottom";
            this.ubPagUp.Appearance = appearance12;
            this.ubPagUp.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2003ToolbarButton;
            this.ubPagUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubPagUp.Location = new System.Drawing.Point(744, 283);
            this.ubPagUp.Name = "ubPagUp";
            this.ubPagUp.PercImageFill = 0.75F;
            this.ubPagUp.ShortcutColor = System.Drawing.Color.Black;
            this.ubPagUp.ShortcutFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions.Small;
            this.ubPagUp.ShortcutKey = System.Windows.Forms.Keys.None;
            this.ubPagUp.ShortcutPosition = UnicodeSrl.ScciCore.easyStatics.easyShortcutPosition.top_right;
            this.ubPagUp.Size = new System.Drawing.Size(68, 64);
            this.ubPagUp.TabIndex = 6;
            this.ubPagUp.TextFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions._undefined;
            this.ubPagUp.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.ubPagUp.Click += new System.EventHandler(this.ubPagUp_Click);
                                                appearance13.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance13.ImageVAlign = Infragistics.Win.VAlign.Middle;
            appearance13.TextHAlignAsString = "Center";
            appearance13.TextVAlignAsString = "Bottom";
            this.ubWholePage.Appearance = appearance13;
            this.ubWholePage.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2003ToolbarButton;
            this.ubWholePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubWholePage.Location = new System.Drawing.Point(744, 213);
            this.ubWholePage.Name = "ubWholePage";
            this.ubWholePage.PercImageFill = 0.75F;
            this.ubWholePage.ShortcutColor = System.Drawing.Color.Black;
            this.ubWholePage.ShortcutFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions.Small;
            this.ubWholePage.ShortcutKey = System.Windows.Forms.Keys.None;
            this.ubWholePage.ShortcutPosition = UnicodeSrl.ScciCore.easyStatics.easyShortcutPosition.top_right;
            this.ubWholePage.Size = new System.Drawing.Size(68, 64);
            this.ubWholePage.TabIndex = 5;
            this.ubWholePage.TextFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions._undefined;
            this.ubWholePage.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.ubWholePage.Click += new System.EventHandler(this.ubWholePage_Click);
                                                appearance14.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance14.ImageVAlign = Infragistics.Win.VAlign.Middle;
            appearance14.TextHAlignAsString = "Center";
            appearance14.TextVAlignAsString = "Bottom";
            this.ubPageWidth.Appearance = appearance14;
            this.ubPageWidth.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2003ToolbarButton;
            this.ubPageWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubPageWidth.Location = new System.Drawing.Point(744, 143);
            this.ubPageWidth.Name = "ubPageWidth";
            this.ubPageWidth.PercImageFill = 0.75F;
            this.ubPageWidth.ShortcutColor = System.Drawing.Color.Black;
            this.ubPageWidth.ShortcutFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions.Small;
            this.ubPageWidth.ShortcutKey = System.Windows.Forms.Keys.None;
            this.ubPageWidth.ShortcutPosition = UnicodeSrl.ScciCore.easyStatics.easyShortcutPosition.top_right;
            this.ubPageWidth.Size = new System.Drawing.Size(68, 64);
            this.ubPageWidth.TabIndex = 4;
            this.ubPageWidth.TextFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions._undefined;
            this.ubPageWidth.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.ubPageWidth.Click += new System.EventHandler(this.ubPageWidth_Click);
                                                appearance15.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance15.ImageVAlign = Infragistics.Win.VAlign.Middle;
            appearance15.TextHAlignAsString = "Center";
            appearance15.TextVAlignAsString = "Bottom";
            this.ubZoomOut.Appearance = appearance15;
            this.ubZoomOut.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2003ToolbarButton;
            this.ubZoomOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubZoomOut.Location = new System.Drawing.Point(744, 73);
            this.ubZoomOut.Name = "ubZoomOut";
            this.ubZoomOut.PercImageFill = 0.75F;
            this.ubZoomOut.ShortcutColor = System.Drawing.Color.Black;
            this.ubZoomOut.ShortcutFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions.Small;
            this.ubZoomOut.ShortcutKey = System.Windows.Forms.Keys.None;
            this.ubZoomOut.ShortcutPosition = UnicodeSrl.ScciCore.easyStatics.easyShortcutPosition.top_right;
            this.ubZoomOut.Size = new System.Drawing.Size(68, 64);
            this.ubZoomOut.TabIndex = 3;
            this.ubZoomOut.TextFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions._undefined;
            this.ubZoomOut.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.ubZoomOut.Click += new System.EventHandler(this.ubZoomOut_Click);
                                                appearance16.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance16.ImageVAlign = Infragistics.Win.VAlign.Middle;
            appearance16.TextHAlignAsString = "Center";
            appearance16.TextVAlignAsString = "Bottom";
            this.ubZoomIn.Appearance = appearance16;
            this.ubZoomIn.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2003ToolbarButton;
            this.ubZoomIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubZoomIn.Location = new System.Drawing.Point(744, 3);
            this.ubZoomIn.Name = "ubZoomIn";
            this.ubZoomIn.PercImageFill = 0.75F;
            this.ubZoomIn.ShortcutColor = System.Drawing.Color.Black;
            this.ubZoomIn.ShortcutFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions.Small;
            this.ubZoomIn.ShortcutKey = System.Windows.Forms.Keys.None;
            this.ubZoomIn.ShortcutPosition = UnicodeSrl.ScciCore.easyStatics.easyShortcutPosition.top_right;
            this.ubZoomIn.Size = new System.Drawing.Size(68, 64);
            this.ubZoomIn.TabIndex = 2;
            this.ubZoomIn.TextFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions._undefined;
            this.ubZoomIn.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.ubZoomIn.Click += new System.EventHandler(this.ubZoomIn_Click);
                                                this.Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer.IsMetric = true;
            this.Viewer.Location = new System.Drawing.Point(3, 3);
            this.Viewer.Name = "Viewer";
            this.ucEasyTableLayoutPanel.SetRowSpan(this.Viewer, 8);
            this.Viewer.ShowPageMargins = false;
            this.Viewer.Size = new System.Drawing.Size(735, 535);
            this.Viewer.TabIndex = 0;
                                                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ucEasyTableLayoutPanel);
            this.Name = "ucEasyDevExpressViewer";
            this.Size = new System.Drawing.Size(815, 541);
            this.ucEasyTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ucEasyTableLayoutPanel ucEasyTableLayoutPanel;
        private DevExpress.XtraPrinting.Preview.DocumentViewer Viewer;
        private ucEasyButton ubZoomIn;
        private ucEasyButton ubZoomOut;
        private ucEasyButton ubPageWidth;
        private ucEasyButton ubWholePage;
        private ucEasyButton ubPagUp;
        private ucEasyButton ubPagDown;
        private ucEasyButton ubPrint;
        private ucEasyStateButton uchkBookmark;
    }
}
