#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Budget
{
    namespace Ninja
    {
        namespace Data
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
                    System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle( );
                    System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle( );
                    Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage( );
                    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetTools));
                    this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv( );
                    this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv( );
                    this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
                    this.dataGridView1 = new System.Windows.Forms.DataGridView( );
                    this.bFYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
                    this.fundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
                    this.bOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
                    this.orgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
                    this.rCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
                    this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
                    this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn( );
                    ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit( );
                    this.splitContainerAdv1.Panel1.SuspendLayout( );
                    this.splitContainerAdv1.SuspendLayout( );
                    ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit( );
                    this.tabControlAdv1.SuspendLayout( );
                    this.tabPageAdv1.SuspendLayout( );
                    ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit( );
                    this.SuspendLayout( );
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
                    this.splitContainerAdv1.Panel1.Controls.Add(this.tabControlAdv1);
                    this.splitContainerAdv1.Size = new System.Drawing.Size(1788, 953);
                    this.splitContainerAdv1.SplitterDistance = 1357;
                    this.splitContainerAdv1.TabIndex = 0;
                    this.splitContainerAdv1.Text = "splitContainerAdv1";
                    // 
                    // tabControlAdv1
                    // 
                    this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.SteelBlue;
                    this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
                    this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(846, 352);
                    this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
                    this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
                    this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
                    this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
                    this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.SteelBlue;
                    this.tabControlAdv1.FocusOnTabClick = false;
                    this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
                    this.tabControlAdv1.Location = new System.Drawing.Point(112, 106);
                    this.tabControlAdv1.Name = "tabControlAdv1";
                    this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
                    this.tabControlAdv1.ShowSeparator = false;
                    this.tabControlAdv1.Size = new System.Drawing.Size(846, 352);
                    this.tabControlAdv1.TabIndex = 0;
                    this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.Black;
                    this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
                    // 
                    // tabPageAdv1
                    // 
                    this.tabPageAdv1.Controls.Add(this.dataGridView1);
                    this.tabPageAdv1.Image = null;
                    this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
                    this.tabPageAdv1.Location = new System.Drawing.Point(1, 29);
                    this.tabPageAdv1.Name = "tabPageAdv1";
                    this.tabPageAdv1.ShowCloseButton = true;
                    this.tabPageAdv1.Size = new System.Drawing.Size(843, 321);
                    this.tabPageAdv1.TabIndex = 1;
                    this.tabPageAdv1.Text = "tabPageAdv1";
                    this.tabPageAdv1.ThemesEnabled = false;
                    // 
                    // dataGridView1
                    // 
                    this.dataGridView1.AutoGenerateColumns = false;
                    dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                    dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
                    dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
                    dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
                    dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                    dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                    this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
                    this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bFYDataGridViewTextBoxColumn,
            this.fundDataGridViewTextBoxColumn,
            this.bOCDataGridViewTextBoxColumn,
            this.orgDataGridViewTextBoxColumn,
            this.rCDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
                    this.dataGridView1.DataMember = "P7";
                    this.dataGridView1.EnableHeadersVisualStyles = false;
                    this.dataGridView1.Location = new System.Drawing.Point(32, 66);
                    this.dataGridView1.Name = "dataGridView1";
                    dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                    dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
                    dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
                    dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
                    dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                    dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                    this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
                    this.dataGridView1.RowTemplate.Height = 28;
                    this.dataGridView1.Size = new System.Drawing.Size(776, 75);
                    this.dataGridView1.TabIndex = 0;
                    // 
                    // bFYDataGridViewTextBoxColumn
                    // 
                    this.bFYDataGridViewTextBoxColumn.DataPropertyName = "BFY";
                    this.bFYDataGridViewTextBoxColumn.HeaderText = "BFY";
                    this.bFYDataGridViewTextBoxColumn.Name = "bFYDataGridViewTextBoxColumn";
                    // 
                    // fundDataGridViewTextBoxColumn
                    // 
                    this.fundDataGridViewTextBoxColumn.DataPropertyName = "Fund";
                    this.fundDataGridViewTextBoxColumn.HeaderText = "Fund";
                    this.fundDataGridViewTextBoxColumn.Name = "fundDataGridViewTextBoxColumn";
                    // 
                    // bOCDataGridViewTextBoxColumn
                    // 
                    this.bOCDataGridViewTextBoxColumn.DataPropertyName = "BOC";
                    this.bOCDataGridViewTextBoxColumn.HeaderText = "BOC";
                    this.bOCDataGridViewTextBoxColumn.Name = "bOCDataGridViewTextBoxColumn";
                    // 
                    // orgDataGridViewTextBoxColumn
                    // 
                    this.orgDataGridViewTextBoxColumn.DataPropertyName = "Org";
                    this.orgDataGridViewTextBoxColumn.HeaderText = "Org";
                    this.orgDataGridViewTextBoxColumn.Name = "orgDataGridViewTextBoxColumn";
                    // 
                    // rCDataGridViewTextBoxColumn
                    // 
                    this.rCDataGridViewTextBoxColumn.DataPropertyName = "RC";
                    this.rCDataGridViewTextBoxColumn.HeaderText = "RC";
                    this.rCDataGridViewTextBoxColumn.Name = "rCDataGridViewTextBoxColumn";
                    // 
                    // codeDataGridViewTextBoxColumn
                    // 
                    this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
                    this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
                    this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
                    // 
                    // amountDataGridViewTextBoxColumn
                    // 
                    this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
                    this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
                    this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
                    // 
                    // e6
                    // 
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
                    captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
                    captionImage1.Location = new System.Drawing.Point(10, 4);
                    captionImage1.Name = "CaptionImage1";
                    captionImage1.Size = new System.Drawing.Size(50, 35);
                    this.CaptionImages.Add(captionImage1);
                    this.ClientSize = new System.Drawing.Size(1788, 953);
                    this.Controls.Add(this.splitContainerAdv1);
                    this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
                    this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                    this.MaximumSize = new System.Drawing.Size(1800, 1000);
                    this.MetroColor = System.Drawing.Color.Black;
                    this.Name = "BudgetTools";
                    this.ShowIcon = false;
                    this.Text = "MetroForm1";
                    this.Load += new System.EventHandler(this.BudgetTools_Load);
                    this.splitContainerAdv1.Panel1.ResumeLayout(false);
                    ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit( );
                    this.splitContainerAdv1.ResumeLayout(false);
                    ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit( );
                    this.tabControlAdv1.ResumeLayout(false);
                    this.tabPageAdv1.ResumeLayout(false);
                    ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit( );
                    this.ResumeLayout(false);

                }

                #endregion

                private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
                private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
                private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
                private System.Windows.Forms.DataGridView dataGridView1;
                private System.Windows.Forms.DataGridViewTextBoxColumn bFYDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn fundDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn bOCDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn orgDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn rCDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
            }

        }
    }
}