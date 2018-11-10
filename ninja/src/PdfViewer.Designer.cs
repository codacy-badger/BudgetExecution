#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace BudgetExecution
{
    partial class Tool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool));
            this.pdfViewerControl1 = new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl();
            this.SuspendLayout();
            // 
            // pdfViewerControl1
            // 
            this.pdfViewerControl1.EnableContextMenu = true;
            this.pdfViewerControl1.EnableNotificationBar = true;
            this.pdfViewerControl1.IsBookmarkEnabled = true;
            this.pdfViewerControl1.Location = new System.Drawing.Point(86, 31);
            this.pdfViewerControl1.Name = "pdfViewerControl1";
            this.pdfViewerControl1.PageBorderThickness = 1;
            pdfViewerPrinterSettings1.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings1.PrintLocation")));
            this.pdfViewerControl1.PrinterSettings = pdfViewerPrinterSettings1;
            this.pdfViewerControl1.ReferencePath = null;
            this.pdfViewerControl1.RenderingEngine = Syncfusion.Windows.Forms.PdfViewer.PdfRenderingEngine.SfPdf;
            this.pdfViewerControl1.ScrollDisplacementValue = 0;
            this.pdfViewerControl1.ShowHorizontalScrollBar = true;
            this.pdfViewerControl1.ShowToolBar = true;
            this.pdfViewerControl1.ShowVerticalScrollBar = true;
            this.pdfViewerControl1.Size = new System.Drawing.Size(1097, 992);
            this.pdfViewerControl1.TabIndex = 1;
            this.pdfViewerControl1.Text = "pdfViewerControl1";
            this.pdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016Black;
            this.pdfViewerControl1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1278, 1059);
            this.Controls.Add(this.pdfViewerControl1);
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "Tool";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl pdfViewerControl1;
    }
}