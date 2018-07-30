#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace BudgetExecution
{
    partial class Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.Info = new System.Windows.Forms.RichTextBox();
            this.OkButton = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.metroSetPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.Black;
            this.Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Info.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Info.Location = new System.Drawing.Point(17, 20);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(488, 123);
            this.Info.TabIndex = 0;
            this.Info.Text = "Message Here";
            // 
            // OkButton
            // 
            this.OkButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.OkButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.OkButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.OkButton.HoverColor = System.Drawing.Color.SteelBlue;
            this.OkButton.HoverTextColor = System.Drawing.Color.White;
            this.OkButton.Location = new System.Drawing.Point(236, 207);
            this.OkButton.Name = "OkButton";
            this.OkButton.NormalBorderColor = System.Drawing.Color.Black;
            this.OkButton.NormalColor = System.Drawing.Color.Transparent;
            this.OkButton.NormalTextColor = System.Drawing.SystemColors.MenuHighlight;
            this.OkButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.OkButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.OkButton.PressTextColor = System.Drawing.Color.White;
            this.OkButton.Size = new System.Drawing.Size(100, 36);
            this.OkButton.Style = MetroSet_UI.Design.Style.Custom;
            this.OkButton.StyleManager = null;
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.ThemeAuthor = "Narwin";
            this.OkButton.ThemeName = "MetroDark";
            this.OkButton.Click += new System.EventHandler(this.OkButton_OnClick);
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.Black;
            this.metroSetPanel1.BorderColor = System.Drawing.Color.SteelBlue;
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.Info);
            this.metroSetPanel1.Location = new System.Drawing.Point(31, 24);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(529, 156);
            this.metroSetPanel1.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 2;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroDark";
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionForeColor = System.Drawing.Color.Black;
            captionImage1.BackColor = System.Drawing.Color.Black;
            captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
            captionImage1.Location = new System.Drawing.Point(5, 5);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(30, 30);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(600, 274);
            this.Controls.Add(this.metroSetPanel1);
            this.Controls.Add(this.OkButton);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.Black;
            this.MinimizeBox = false;
            this.Name = "Message";
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
        private MetroSet_UI.Controls.MetroSetButton OkButton;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
    }
}