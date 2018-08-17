#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace BudgetExecution
{
    public partial class BudgetTools
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
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.expandCollapsePanel1);
            this.splitContainerAdv1.Panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainerAdv1.Size = new System.Drawing.Size(1193, 628);
            this.splitContainerAdv1.SplitterDistance = 905;
            this.splitContainerAdv1.TabIndex = 0;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // expandCollapsePanel1
            // 
            this.expandCollapsePanel1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel1.ExpandedHeight = 0;
            this.expandCollapsePanel1.IsExpanded = true;
            this.expandCollapsePanel1.Location = new System.Drawing.Point(15, 23);
            this.expandCollapsePanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expandCollapsePanel1.Name = "expandCollapsePanel1";
            this.expandCollapsePanel1.Size = new System.Drawing.Size(234, 430);
            this.expandCollapsePanel1.TabIndex = 0;
            this.expandCollapsePanel1.Text = "expandCollapsePanel1";
            this.expandCollapsePanel1.UseAnimation = true;
            // 
            // BudgetTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
            captionImage1.BackColor = System.Drawing.Color.Black;
            captionImage1.Location = new System.Drawing.Point(10, 4);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(50, 35);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(1193, 628);
            this.Controls.Add(this.splitContainerAdv1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "BudgetTools";
            this.ShowIcon = false;
            this.Text = "MetroForm1";
            this.Load += new System.EventHandler(this.BudgetTools_Load);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
    }
}