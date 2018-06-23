#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace BudgetExecution
{
    partial class Calendar
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.monthCalendarAdv1 = new Syncfusion.Windows.Forms.Tools.MonthCalendarAdv();
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendarAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendarAdv1
            // 
            this.monthCalendarAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.monthCalendarAdv1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.monthCalendarAdv1.Culture = new System.Globalization.CultureInfo("");
            this.monthCalendarAdv1.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.monthCalendarAdv1.DayNamesFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendarAdv1.DaysHeaderInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            this.monthCalendarAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendarAdv1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendarAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarAdv1.GridBackColor = System.Drawing.SystemColors.MenuBar;
            this.monthCalendarAdv1.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.monthCalendarAdv1.HeaderHeight = 34;
            this.monthCalendarAdv1.HeaderStartColor = System.Drawing.SystemColors.InactiveCaption;
            this.monthCalendarAdv1.HighlightColor = System.Drawing.Color.Black;
            this.monthCalendarAdv1.Iso8601CalenderFormat = false;
            this.monthCalendarAdv1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendarAdv1.MetroColor = System.Drawing.Color.SteelBlue;
            this.monthCalendarAdv1.Name = "monthCalendarAdv1";
            this.monthCalendarAdv1.ScrollButtonSize = new System.Drawing.Size(24, 24);
            this.monthCalendarAdv1.Size = new System.Drawing.Size(722, 608);
            this.monthCalendarAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.monthCalendarAdv1.TabIndex = 0;
            this.monthCalendarAdv1.WeekFont = new System.Drawing.Font("Verdana", 8F);
            // 
            // 
            // 
            this.monthCalendarAdv1.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.monthCalendarAdv1.NoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.monthCalendarAdv1.NoneButton.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.monthCalendarAdv1.NoneButton.ForeColor = System.Drawing.Color.White;
            this.monthCalendarAdv1.NoneButton.IsBackStageButton = false;
            this.monthCalendarAdv1.NoneButton.Location = new System.Drawing.Point(361, 0);
            this.monthCalendarAdv1.NoneButton.Size = new System.Drawing.Size(361, 20);
            this.monthCalendarAdv1.NoneButton.Text = "None";
            this.monthCalendarAdv1.NoneButton.UseVisualStyle = true;
            // 
            // 
            // 
            this.monthCalendarAdv1.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.monthCalendarAdv1.TodayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.monthCalendarAdv1.TodayButton.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.monthCalendarAdv1.TodayButton.ForeColor = System.Drawing.Color.White;
            this.monthCalendarAdv1.TodayButton.IsBackStageButton = false;
            this.monthCalendarAdv1.TodayButton.Location = new System.Drawing.Point(0, 0);
            this.monthCalendarAdv1.TodayButton.Size = new System.Drawing.Size(361, 20);
            this.monthCalendarAdv1.TodayButton.Text = "Today";
            this.monthCalendarAdv1.TodayButton.UseVisualStyle = true;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionForeColor = System.Drawing.Color.Black;
            captionImage1.BackColor = System.Drawing.Color.Black;
            captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
            captionImage1.Location = new System.Drawing.Point(10, 10);
            captionImage1.Name = "CaptionImage1";
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(722, 608);
            this.Controls.Add(this.monthCalendarAdv1);
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "Calendar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendarAdv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.MonthCalendarAdv monthCalendarAdv1;
    }
}