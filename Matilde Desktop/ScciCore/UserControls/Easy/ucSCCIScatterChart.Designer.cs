﻿namespace UnicodeSrl.ScciCore
{
    partial class ucSCCIScatterChart
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
            Infragistics.UltraChart.Resources.Appearance.PaintElement paintElement1 = new Infragistics.UltraChart.Resources.Appearance.PaintElement();
            Infragistics.UltraChart.Resources.Appearance.TimeAxisAppearance timeAxisAppearance1 = new Infragistics.UltraChart.Resources.Appearance.TimeAxisAppearance();
            Infragistics.UltraChart.Resources.Appearance.GradientEffect gradientEffect1 = new Infragistics.UltraChart.Resources.Appearance.GradientEffect();
            Infragistics.UltraChart.Resources.Appearance.ScatterChartAppearance scatterChartAppearance1 = new Infragistics.UltraChart.Resources.Appearance.ScatterChartAppearance();
            Infragistics.UltraChart.Resources.Appearance.ChartTextAppearance chartTextAppearance1 = new Infragistics.UltraChart.Resources.Appearance.ChartTextAppearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.ultraChart = new Infragistics.Win.UltraWinChart.UltraChart();
            this.lblTitolo = new UnicodeSrl.ScciCore.ucEasyLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ultraChart)).BeginInit();
            this.SuspendLayout();
                        this.ultraChart.ChartType = Infragistics.UltraChart.Shared.Styles.ChartType.ScatterChart;
                                                this.ultraChart.Axis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            paintElement1.ElementType = Infragistics.UltraChart.Shared.Styles.PaintElementType.None;
            paintElement1.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.ultraChart.Axis.PE = paintElement1;
            this.ultraChart.Axis.X.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart.Axis.X.Labels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart.Axis.X.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
            this.ultraChart.Axis.X.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart.Axis.X.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart.Axis.X.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart.Axis.X.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart.Axis.X.Labels.SeriesLabels.FormatString = "";
            this.ultraChart.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart.Axis.X.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart.Axis.X.LineThickness = 1;
            this.ultraChart.Axis.X.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart.Axis.X.MajorGridLines.Visible = true;
            this.ultraChart.Axis.X.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart.Axis.X.MinorGridLines.Visible = false;
            this.ultraChart.Axis.X.TickmarkInterval = 10D;
            this.ultraChart.Axis.X.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            timeAxisAppearance1.TimeAxisStyle = Infragistics.UltraChart.Shared.Styles.RulerGenre.Discrete;
            this.ultraChart.Axis.X.TimeAxisStyle = timeAxisAppearance1;
            this.ultraChart.Axis.X.Visible = true;
            this.ultraChart.Axis.X2.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart.Axis.X2.Labels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart.Axis.X2.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
            this.ultraChart.Axis.X2.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart.Axis.X2.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart.Axis.X2.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart.Axis.X2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart.Axis.X2.Labels.SeriesLabels.FormatString = "";
            this.ultraChart.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart.Axis.X2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart.Axis.X2.Labels.Visible = false;
            this.ultraChart.Axis.X2.LineThickness = 1;
            this.ultraChart.Axis.X2.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart.Axis.X2.MajorGridLines.Visible = true;
            this.ultraChart.Axis.X2.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart.Axis.X2.MinorGridLines.Visible = false;
            this.ultraChart.Axis.X2.TickmarkInterval = 10D;
            this.ultraChart.Axis.X2.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart.Axis.X2.Visible = false;
            this.ultraChart.Axis.Y.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart.Axis.Y.Labels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
            this.ultraChart.Axis.Y.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart.Axis.Y.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart.Axis.Y.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart.Axis.Y.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart.Axis.Y.Labels.SeriesLabels.FormatString = "";
            this.ultraChart.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart.Axis.Y.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart.Axis.Y.LineThickness = 1;
            this.ultraChart.Axis.Y.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart.Axis.Y.MajorGridLines.Visible = true;
            this.ultraChart.Axis.Y.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart.Axis.Y.MinorGridLines.Visible = false;
            this.ultraChart.Axis.Y.TickmarkInterval = 40D;
            this.ultraChart.Axis.Y.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart.Axis.Y.Visible = true;
            this.ultraChart.Axis.Y2.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart.Axis.Y2.Labels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
            this.ultraChart.Axis.Y2.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart.Axis.Y2.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart.Axis.Y2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart.Axis.Y2.Labels.SeriesLabels.FormatString = "";
            this.ultraChart.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart.Axis.Y2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart.Axis.Y2.Labels.Visible = false;
            this.ultraChart.Axis.Y2.LineThickness = 1;
            this.ultraChart.Axis.Y2.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart.Axis.Y2.MajorGridLines.Visible = true;
            this.ultraChart.Axis.Y2.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart.Axis.Y2.MinorGridLines.Visible = false;
            this.ultraChart.Axis.Y2.TickmarkInterval = 40D;
            this.ultraChart.Axis.Y2.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart.Axis.Y2.Visible = false;
            this.ultraChart.Axis.Z.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart.Axis.Z.Labels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart.Axis.Z.Labels.ItemFormatString = "";
            this.ultraChart.Axis.Z.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart.Axis.Z.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart.Axis.Z.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart.Axis.Z.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart.Axis.Z.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart.Axis.Z.Labels.Visible = false;
            this.ultraChart.Axis.Z.LineThickness = 1;
            this.ultraChart.Axis.Z.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart.Axis.Z.MajorGridLines.Visible = true;
            this.ultraChart.Axis.Z.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart.Axis.Z.MinorGridLines.Visible = false;
            this.ultraChart.Axis.Z.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart.Axis.Z.Visible = false;
            this.ultraChart.Axis.Z2.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart.Axis.Z2.Labels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart.Axis.Z2.Labels.ItemFormatString = "";
            this.ultraChart.Axis.Z2.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart.Axis.Z2.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart.Axis.Z2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart.Axis.Z2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart.Axis.Z2.Labels.Visible = false;
            this.ultraChart.Axis.Z2.LineThickness = 1;
            this.ultraChart.Axis.Z2.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart.Axis.Z2.MajorGridLines.Visible = true;
            this.ultraChart.Axis.Z2.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart.Axis.Z2.MinorGridLines.Visible = false;
            this.ultraChart.Axis.Z2.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart.Axis.Z2.Visible = false;
            this.ultraChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ultraChart.ColorModel.AlphaLevel = ((byte)(150));
            this.ultraChart.ColorModel.ColorBegin = System.Drawing.Color.Pink;
            this.ultraChart.ColorModel.ColorEnd = System.Drawing.Color.DarkRed;
            this.ultraChart.ColorModel.ModelStyle = Infragistics.UltraChart.Shared.Styles.ColorModels.CustomLinear;
            this.ultraChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraChart.Effects.Effects.Add(gradientEffect1);
            this.ultraChart.Legend.Margins.Bottom = 1;
            this.ultraChart.Legend.Margins.Left = 1;
            this.ultraChart.Legend.Margins.Right = 1;
            this.ultraChart.Legend.Margins.Top = 1;
            this.ultraChart.Legend.SpanPercentage = 18;
            this.ultraChart.Legend.Visible = true;
            this.ultraChart.Location = new System.Drawing.Point(0, 32);
            this.ultraChart.Margin = new System.Windows.Forms.Padding(1);
            this.ultraChart.Name = "ultraChart";
            chartTextAppearance1.ChartTextFont = new System.Drawing.Font("Arial", 7F);
            chartTextAppearance1.ClipText = false;
            chartTextAppearance1.Column = -2;
            chartTextAppearance1.ItemFormatString = "<DATA_VALUE_Y:00.00>";
            chartTextAppearance1.Row = -2;
            chartTextAppearance1.Visible = true;
            scatterChartAppearance1.ChartText.Add(chartTextAppearance1);
            scatterChartAppearance1.ConnectWithLines = true;
            scatterChartAppearance1.Icon = Infragistics.UltraChart.Shared.Styles.SymbolIcon.Square;
            scatterChartAppearance1.LineAppearance.Thickness = 4;
            scatterChartAppearance1.NullHandling = Infragistics.UltraChart.Shared.Styles.NullHandling.DontPlot;
            this.ultraChart.ScatterChart = scatterChartAppearance1;
            this.ultraChart.Size = new System.Drawing.Size(796, 524);
            this.ultraChart.TabIndex = 0;
            this.ultraChart.Tooltips.FormatString = "<DATA_VALUE_Y:00.##>";
            this.ultraChart.Tooltips.HighlightFillColor = System.Drawing.Color.DimGray;
            this.ultraChart.Tooltips.HighlightOutlineColor = System.Drawing.Color.DarkGray;
            this.ultraChart.FillSceneGraph += new Infragistics.UltraChart.Shared.Events.FillSceneGraphEventHandler(this.ultraChart_FillSceneGraph);
                                                appearance1.FontData.SizeInPoints = 22.50746F;
            appearance1.TextVAlignAsString = "Bottom";
            this.lblTitolo.Appearance = appearance1;
            this.lblTitolo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitolo.Location = new System.Drawing.Point(0, 0);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.ShortcutColor = System.Drawing.Color.Black;
            this.lblTitolo.ShortcutFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions.Small;
            this.lblTitolo.ShortcutKey = System.Windows.Forms.Keys.None;
            this.lblTitolo.ShortcutPosition = UnicodeSrl.ScciCore.easyStatics.easyShortcutPosition.top_right;
            this.lblTitolo.Size = new System.Drawing.Size(796, 32);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Titolo";
            this.lblTitolo.TextFontRelativeDimension = UnicodeSrl.ScciCore.easyStatics.easyRelativeDimensions.Medium;
                                                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ultraChart);
            this.Controls.Add(this.lblTitolo);
            this.Name = "ucSCCIScatterChart";
            this.Size = new System.Drawing.Size(796, 556);
            ((System.ComponentModel.ISupportInitialize)(this.ultraChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucEasyLabel lblTitolo;
        private Infragistics.Win.UltraWinChart.UltraChart ultraChart;
    }
}
