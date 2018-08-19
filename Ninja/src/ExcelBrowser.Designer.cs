#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace BudgetExecution
{
    partial class ExcelBrowser
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
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelBrowser));
            this.Info = new System.Windows.Forms.RichTextBox();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.ExcelGrabber = new System.Windows.Forms.OpenFileDialog();
            this.metroSetPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.Black;
            this.Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Info.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Info.Location = new System.Drawing.Point(39, 19);
            this.Info.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(325, 80);
            this.Info.TabIndex = 0;
            this.Info.Text = "Message Here";
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.Black;
            this.metroSetPanel1.BorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.Info);
            this.metroSetPanel1.Location = new System.Drawing.Point(21, 16);
            this.metroSetPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(400, 123);
            this.metroSetPanel1.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 2;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroDark";
            // 
            // ExcelGrabber
            // 
            this.ExcelGrabber.DefaultExt = "xlsx";
            this.ExcelGrabber.FileName = "openFileDialog1";
            this.ExcelGrabber.Title = "Grab Excel File";
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionForeColor = System.Drawing.Color.Black;
            captionImage1.BackColor = System.Drawing.Color.Black;
            captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
            captionImage1.Location = new System.Drawing.Point(10, 5);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(30, 20);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(468, 255);
            this.Controls.Add(this.metroSetPanel1);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.Black;
            this.MinimizeBox = false;
            this.Name = "ExcelBrowser";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.TopMost = true;
            this.metroSetPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Info;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private System.Windows.Forms.OpenFileDialog ExcelGrabber;
    }
}