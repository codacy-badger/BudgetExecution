﻿
namespace BudgetExecution
{
    partial class Selector
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
            this.ViewerCarousel = new Syncfusion.Windows.Forms.Tools.Carousel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewerCarousel
            // 
            this.ViewerCarousel.BackColor = System.Drawing.Color.Black;
            this.ViewerCarousel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ViewerCarousel.CarouselBounds = 200;
            this.ViewerCarousel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewerCarousel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewerCarousel.HighlightColor = System.Drawing.Color.SteelBlue;
            this.ViewerCarousel.ImageshadeColor = System.Drawing.Color.MidnightBlue;
            this.ViewerCarousel.ImageSlides = true;
            this.ViewerCarousel.Location = new System.Drawing.Point(0, 0);
            this.ViewerCarousel.Margin = new System.Windows.Forms.Padding(2);
            this.ViewerCarousel.Name = "ViewerCarousel";
            this.ViewerCarousel.PadX = 2;
            this.ViewerCarousel.PadY = 1;
            this.ViewerCarousel.Perspective = 4F;
            this.ViewerCarousel.RotateAlways = false;
            this.ViewerCarousel.ShowImagePreview = true;
            this.ViewerCarousel.ShowImageShadow = true;
            this.ViewerCarousel.Size = new System.Drawing.Size(1552, 918);
            this.ViewerCarousel.TabIndex = 2;
            this.ViewerCarousel.Text = "carousel2";
            this.ViewerCarousel.TouchTransitionSpeed = 3F;
            this.ViewerCarousel.UseOriginalImageinPreview = false;
            this.ViewerCarousel.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Default;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ViewerCarousel);
            this.panel1.Location = new System.Drawing.Point(84, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1552, 918);
            this.panel1.TabIndex = 3;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Black;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1702, 1017);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1714, 1064);
            this.MetroColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(1714, 1064);
            this.Name = "Selector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.Carousel ViewerCarousel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}