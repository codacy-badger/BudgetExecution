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
    this.panel1 = new System.Windows.Forms.Panel();
    this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
    ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
    this.splitContainerAdv1.Panel1.SuspendLayout();
    this.splitContainerAdv1.Panel2.SuspendLayout();
    this.splitContainerAdv1.SuspendLayout();
    this.SuspendLayout();
    // 
    // splitContainerAdv1
    // 
    this.splitContainerAdv1.BeforeTouchSize = 7;
    this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
    this.splitContainerAdv1.Location = new System.Drawing.Point(0, 0);
    this.splitContainerAdv1.Name = "splitContainerAdv1";
    // 
    // splitContainerAdv1.Panel1
    // 
    this.splitContainerAdv1.Panel1.Controls.Add(this.panel1);
    // 
    // splitContainerAdv1.Panel2
    // 
    this.splitContainerAdv1.Panel2.Controls.Add(this.expandCollapsePanel1);
    this.splitContainerAdv1.Size = new System.Drawing.Size(1788, 953);
    this.splitContainerAdv1.SplitterDistance = 1357;
    this.splitContainerAdv1.TabIndex = 0;
    this.splitContainerAdv1.Text = "splitContainerAdv1";
    // 
    // panel1
    // 
    this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
    this.panel1.Location = new System.Drawing.Point(51, 50);
    this.panel1.Name = "panel1";
    this.panel1.Size = new System.Drawing.Size(1245, 785);
    this.panel1.TabIndex = 1;
    // 
    // expandCollapsePanel1
    // 
    this.expandCollapsePanel1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
    this.expandCollapsePanel1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
    this.expandCollapsePanel1.ExpandedHeight = 0;
    this.expandCollapsePanel1.IsExpanded = true;
    this.expandCollapsePanel1.Location = new System.Drawing.Point(23, 35);
    this.expandCollapsePanel1.Name = "expandCollapsePanel1";
    this.expandCollapsePanel1.Size = new System.Drawing.Size(351, 662);
    this.expandCollapsePanel1.TabIndex = 0;
    this.expandCollapsePanel1.Text = "expandCollapsePanel1";
    this.expandCollapsePanel1.UseAnimation = true;
    // 
    // BudgetTools
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
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
    this.ClientSize = new System.Drawing.Size(1788, 953);
    this.Controls.Add(this.splitContainerAdv1);
    this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
    this.MaximumSize = new System.Drawing.Size(1800, 1000);
    this.MetroColor = System.Drawing.Color.Black;
    this.Name = "BudgetTools";
    this.ShowIcon = false;
    this.Text = "MetroForm1";
    this.Load += new System.EventHandler(this.BudgetTools_Load);
    this.splitContainerAdv1.Panel1.ResumeLayout(false);
    this.splitContainerAdv1.Panel2.ResumeLayout(false);
    ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
    this.splitContainerAdv1.ResumeLayout(false);
    this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private System.Windows.Forms.Panel panel1;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
    }
}