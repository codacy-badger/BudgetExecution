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
            this.StackButton = new MetroSet_UI.Controls.MetroSetButton();
            this.TargetButton = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.Black;
            this.Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Info.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Info.Location = new System.Drawing.Point(16, 22);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(503, 215);
            this.Info.TabIndex = 0;
            this.Info.Text = "Message Here";
            // 
            // OkButton
            // 
            this.OkButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.OkButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.OkButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OkButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.OkButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.OkButton.HoverTextColor = System.Drawing.Color.White;
            this.OkButton.Location = new System.Drawing.Point(60, 306);
            this.OkButton.Name = "OkButton";
            this.OkButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.OkButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.OkButton.NormalTextColor = System.Drawing.Color.White;
            this.OkButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.OkButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.OkButton.PressTextColor = System.Drawing.Color.White;
            this.OkButton.Size = new System.Drawing.Size(100, 36);
            this.OkButton.Style = MetroSet_UI.Design.Style.Dark;
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
            this.metroSetPanel1.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.Info);
            this.metroSetPanel1.Location = new System.Drawing.Point(34, 25);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(529, 253);
            this.metroSetPanel1.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 2;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroDark";
            // 
            // StackButton
            // 
            this.StackButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.StackButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.StackButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.StackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StackButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.StackButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.StackButton.HoverTextColor = System.Drawing.Color.White;
            this.StackButton.Location = new System.Drawing.Point(232, 306);
            this.StackButton.Name = "StackButton";
            this.StackButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.StackButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.StackButton.NormalTextColor = System.Drawing.Color.White;
            this.StackButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.StackButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.StackButton.PressTextColor = System.Drawing.Color.White;
            this.StackButton.Size = new System.Drawing.Size(100, 36);
            this.StackButton.Style = MetroSet_UI.Design.Style.Dark;
            this.StackButton.StyleManager = null;
            this.StackButton.TabIndex = 3;
            this.StackButton.Text = "Stack";
            this.StackButton.ThemeAuthor = "Narwin";
            this.StackButton.ThemeName = "MetroDark";
            this.StackButton.Click += new System.EventHandler(this.StackButton_OnClick);
            // 
            // TargetButton
            // 
            this.TargetButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TargetButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TargetButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.TargetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TargetButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.TargetButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.TargetButton.HoverTextColor = System.Drawing.Color.White;
            this.TargetButton.Location = new System.Drawing.Point(409, 306);
            this.TargetButton.Name = "TargetButton";
            this.TargetButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TargetButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TargetButton.NormalTextColor = System.Drawing.Color.White;
            this.TargetButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.TargetButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.TargetButton.PressTextColor = System.Drawing.Color.White;
            this.TargetButton.Size = new System.Drawing.Size(100, 36);
            this.TargetButton.Style = MetroSet_UI.Design.Style.Dark;
            this.TargetButton.StyleManager = null;
            this.TargetButton.TabIndex = 4;
            this.TargetButton.Text = "Target";
            this.TargetButton.ThemeAuthor = "Narwin";
            this.TargetButton.ThemeName = "MetroDark";
            this.TargetButton.Click += new System.EventHandler(this.TargetButton_OnClick);
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.Color.Red;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionForeColor = System.Drawing.Color.Black;
            captionImage1.BackColor = System.Drawing.Color.Black;
            captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
            captionImage1.Location = new System.Drawing.Point(10, 10);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(25, 20);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(600, 354);
            this.Controls.Add(this.TargetButton);
            this.Controls.Add(this.StackButton);
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
        private MetroSet_UI.Controls.MetroSetButton StackButton;
        private MetroSet_UI.Controls.MetroSetButton TargetButton;
    }
}