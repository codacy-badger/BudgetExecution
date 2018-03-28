using System.Data;
namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            partial class AccountManager
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
            this.AccountMangerGroupBox = new System.Windows.Forms.GroupBox();
            this.PrcPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BfyBox = new MetroFramework.Controls.MetroComboBox();
            this.RcBox = new MetroFramework.Controls.MetroComboBox();
            this.OrgBox = new MetroFramework.Controls.MetroComboBox();
            this.BocBox = new MetroFramework.Controls.MetroComboBox();
            this.FundBox = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.Amount = new MetroSet_UI.Controls.MetroSetTextBox();
            this.CodeBox = new MetroFramework.Controls.MetroComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AccountMangerGroupBox.SuspendLayout();
            this.PrcPanel.SuspendLayout();
            this.expandCollapsePanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountMangerGroupBox
            // 
            this.AccountMangerGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AccountMangerGroupBox.Controls.Add(this.PrcPanel);
            this.AccountMangerGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountMangerGroupBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.AccountMangerGroupBox.Location = new System.Drawing.Point(52, 59);
            this.AccountMangerGroupBox.Name = "AccountMangerGroupBox";
            this.AccountMangerGroupBox.Size = new System.Drawing.Size(916, 153);
            this.AccountMangerGroupBox.TabIndex = 125;
            this.AccountMangerGroupBox.TabStop = false;
            this.AccountMangerGroupBox.Text = "Division Account Data";
            // 
            // PrcPanel
            // 
            this.PrcPanel.ColumnCount = 7;
            this.PrcPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.PrcPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.PrcPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.PrcPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.PrcPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.PrcPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.PrcPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.PrcPanel.Controls.Add(this.BfyBox, 0, 1);
            this.PrcPanel.Controls.Add(this.RcBox, 4, 1);
            this.PrcPanel.Controls.Add(this.OrgBox, 3, 1);
            this.PrcPanel.Controls.Add(this.BocBox, 2, 1);
            this.PrcPanel.Controls.Add(this.FundBox, 1, 1);
            this.PrcPanel.Controls.Add(this.label6, 6, 0);
            this.PrcPanel.Controls.Add(this.label7, 0, 0);
            this.PrcPanel.Controls.Add(this.label8, 5, 0);
            this.PrcPanel.Controls.Add(this.label15, 1, 0);
            this.PrcPanel.Controls.Add(this.label10, 4, 0);
            this.PrcPanel.Controls.Add(this.label41, 3, 0);
            this.PrcPanel.Controls.Add(this.label43, 2, 0);
            this.PrcPanel.Controls.Add(this.Amount, 6, 1);
            this.PrcPanel.Controls.Add(this.CodeBox, 5, 1);
            this.PrcPanel.Location = new System.Drawing.Point(23, 45);
            this.PrcPanel.Name = "PrcPanel";
            this.PrcPanel.RowCount = 2;
            this.PrcPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.79167F));
            this.PrcPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.20833F));
            this.PrcPanel.Size = new System.Drawing.Size(878, 72);
            this.PrcPanel.TabIndex = 151;
            // 
            // BfyBox
            // 
            this.BfyBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.BfyBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.BfyBox.FormattingEnabled = true;
            this.BfyBox.ItemHeight = 29;
            this.BfyBox.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            ""});
            this.BfyBox.Location = new System.Drawing.Point(2, 34);
            this.BfyBox.Margin = new System.Windows.Forms.Padding(2);
            this.BfyBox.Name = "BfyBox";
            this.BfyBox.Size = new System.Drawing.Size(104, 35);
            this.BfyBox.TabIndex = 147;
            this.BfyBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BfyBox.UseCustomForeColor = true;
            this.BfyBox.UseSelectable = true;
            // 
            // RcBox
            // 
            this.RcBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.RcBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.RcBox.FormattingEnabled = true;
            this.RcBox.ItemHeight = 29;
            this.RcBox.Location = new System.Drawing.Point(449, 34);
            this.RcBox.Margin = new System.Windows.Forms.Padding(2);
            this.RcBox.Name = "RcBox";
            this.RcBox.Size = new System.Drawing.Size(109, 35);
            this.RcBox.TabIndex = 146;
            this.RcBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RcBox.UseCustomForeColor = true;
            this.RcBox.UseSelectable = true;
            // 
            // OrgBox
            // 
            this.OrgBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.OrgBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.OrgBox.FormattingEnabled = true;
            this.OrgBox.ItemHeight = 29;
            this.OrgBox.Location = new System.Drawing.Point(331, 34);
            this.OrgBox.Margin = new System.Windows.Forms.Padding(2);
            this.OrgBox.Name = "OrgBox";
            this.OrgBox.Size = new System.Drawing.Size(114, 35);
            this.OrgBox.TabIndex = 145;
            this.OrgBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OrgBox.UseCustomForeColor = true;
            this.OrgBox.UseSelectable = true;
            // 
            // BocBox
            // 
            this.BocBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.BocBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.BocBox.FormattingEnabled = true;
            this.BocBox.ItemHeight = 29;
            this.BocBox.Items.AddRange(new object[] {
            "10",
            "17",
            "21",
            "28",
            "36",
            "37",
            "38",
            "41"});
            this.BocBox.Location = new System.Drawing.Point(218, 34);
            this.BocBox.Margin = new System.Windows.Forms.Padding(2);
            this.BocBox.Name = "BocBox";
            this.BocBox.Size = new System.Drawing.Size(109, 35);
            this.BocBox.TabIndex = 144;
            this.BocBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BocBox.UseCustomForeColor = true;
            this.BocBox.UseSelectable = true;
            // 
            // FundBox
            // 
            this.FundBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.FundBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.FundBox.FormattingEnabled = true;
            this.FundBox.ItemHeight = 29;
            this.FundBox.Location = new System.Drawing.Point(110, 34);
            this.FundBox.Margin = new System.Windows.Forms.Padding(2);
            this.FundBox.Name = "FundBox";
            this.FundBox.Size = new System.Drawing.Size(104, 35);
            this.FundBox.TabIndex = 143;
            this.FundBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FundBox.UseCustomForeColor = true;
            this.FundBox.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(767, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 65;
            this.label6.Text = "Amount:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(36, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 21);
            this.label7.TabIndex = 140;
            this.label7.Text = "BFY";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(618, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 21);
            this.label8.TabIndex = 64;
            this.label8.Text = "Code:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label15.Location = new System.Drawing.Point(138, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 21);
            this.label15.TabIndex = 60;
            this.label15.Text = "Fund:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(487, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 21);
            this.label10.TabIndex = 63;
            this.label10.Text = "RC:";
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label41.Location = new System.Drawing.Point(368, 11);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(40, 21);
            this.label41.TabIndex = 62;
            this.label41.Text = "Org:";
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label43.AutoSize = true;
            this.label43.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label43.Location = new System.Drawing.Point(250, 11);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(44, 21);
            this.label43.TabIndex = 66;
            this.label43.Text = "BOC:";
            // 
            // Amount
            // 
            this.Amount.AutoCompleteCustomSource = null;
            this.Amount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Amount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Amount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Amount.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Amount.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Amount.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Amount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Amount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Amount.Image = null;
            this.Amount.Lines = null;
            this.Amount.Location = new System.Drawing.Point(729, 35);
            this.Amount.MaxLength = 32767;
            this.Amount.Multiline = false;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = false;
            this.Amount.Size = new System.Drawing.Size(146, 34);
            this.Amount.Style = MetroSet_UI.Design.Style.Dark;
            this.Amount.StyleManager = null;
            this.Amount.TabIndex = 135;
            this.Amount.Text = "$ 0.00";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Amount.ThemeAuthor = "Narwin";
            this.Amount.ThemeName = "MetroDark";
            this.Amount.UseSystemPasswordChar = false;
            this.Amount.WatermarkText = "";
            // 
            // CodeBox
            // 
            this.CodeBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.CodeBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CodeBox.FormattingEnabled = true;
            this.CodeBox.ItemHeight = 29;
            this.CodeBox.Location = new System.Drawing.Point(562, 34);
            this.CodeBox.Margin = new System.Windows.Forms.Padding(2);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(162, 35);
            this.CodeBox.TabIndex = 142;
            this.CodeBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CodeBox.UseCustomForeColor = true;
            this.CodeBox.UseSelectable = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(222)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 49);
            this.button1.TabIndex = 130;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(222)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(13, 146);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 60);
            this.button2.TabIndex = 131;
            this.button2.Text = "button2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // expandCollapsePanel1
            // 
            this.expandCollapsePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.expandCollapsePanel1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel1.Controls.Add(this.button2);
            this.expandCollapsePanel1.Controls.Add(this.button1);
            this.expandCollapsePanel1.ExpandedHeight = 223;
            this.expandCollapsePanel1.IsExpanded = false;
            this.expandCollapsePanel1.Location = new System.Drawing.Point(2, 2);
            this.expandCollapsePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.expandCollapsePanel1.Name = "expandCollapsePanel1";
            this.expandCollapsePanel1.Size = new System.Drawing.Size(182, 37);
            this.expandCollapsePanel1.TabIndex = 132;
            this.expandCollapsePanel1.Text = "expandCollapsePanel1";
            this.expandCollapsePanel1.UseAnimation = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.expandCollapsePanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(999, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(212, 158);
            this.tableLayoutPanel1.TabIndex = 133;
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
            captionImage1.BackColor = System.Drawing.Color.Black;
            captionImage1.Location = new System.Drawing.Point(30, 10);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(45, 30);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(1240, 267);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AccountMangerGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AccountManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MetroForm1";
            this.Load += new System.EventHandler(this.AccountManager_Load);
            this.AccountMangerGroupBox.ResumeLayout(false);
            this.PrcPanel.ResumeLayout(false);
            this.PrcPanel.PerformLayout();
            this.expandCollapsePanel1.ResumeLayout(false);
            this.expandCollapsePanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

                }

                #endregion

                private System.Windows.Forms.GroupBox AccountMangerGroupBox;
                private System.Windows.Forms.TableLayoutPanel PrcPanel;
                private System.Windows.Forms.Label label6;
                private MetroSet_UI.Controls.MetroSetTextBox Amount;
                private System.Windows.Forms.Label label7;
                private System.Windows.Forms.Label label8;
                private System.Windows.Forms.Label label15;
                private System.Windows.Forms.Label label10;
                private System.Windows.Forms.Label label41;
                private System.Windows.Forms.Label label43;
                private MetroFramework.Controls.MetroComboBox CodeBox;
                private MetroFramework.Controls.MetroComboBox BfyBox;
                private MetroFramework.Controls.MetroComboBox RcBox;
                private MetroFramework.Controls.MetroComboBox OrgBox;
                private MetroFramework.Controls.MetroComboBox BocBox;
                private MetroFramework.Controls.MetroComboBox FundBox;
                private System.Windows.Forms.Button button1;
                private System.Windows.Forms.Button button2;
                private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
                private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            }  
        }
    }
}