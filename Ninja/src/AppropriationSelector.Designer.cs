// <copyright file="AssemblyInfo.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
using Syncfusion.Windows.Forms;
namespace BudgetExecution
{
    partial class AppropriationSelector : MetroForm
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
            this.AppropriationCarousel = new Syncfusion.Windows.Forms.Tools.Carousel();
            this.SuspendLayout();
            // 
            // AppropriationCarousel
            // 
            this.AppropriationCarousel.BackColor = System.Drawing.Color.Black;
            this.AppropriationCarousel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AppropriationCarousel.CarouselBounds = 200;
            this.AppropriationCarousel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppropriationCarousel.HighlightColor = System.Drawing.Color.Lavender;
            this.AppropriationCarousel.ImageshadeColor = System.Drawing.Color.MidnightBlue;
            this.AppropriationCarousel.ImageSlides = true;
            this.AppropriationCarousel.Location = new System.Drawing.Point(263, 189);
            this.AppropriationCarousel.Name = "AppropriationCarousel";
            this.AppropriationCarousel.PadX = 0;
            this.AppropriationCarousel.PadY = 1;
            this.AppropriationCarousel.Perspective = 5F;
            this.AppropriationCarousel.RotateAlways = false;
            this.AppropriationCarousel.ShowImagePreview = true;
            this.AppropriationCarousel.ShowImageShadow = true;
            this.AppropriationCarousel.Size = new System.Drawing.Size(1159, 455);
            this.AppropriationCarousel.TabIndex = 8;
            this.AppropriationCarousel.Text = "carousel2";
            this.AppropriationCarousel.TouchTransitionSpeed = 3F;
            this.AppropriationCarousel.UseOriginalImageinPreview = true;
            this.AppropriationCarousel.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Default;
            // 
            // AppropriationSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionBarHeight = 60;
            this.CaptionFont = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1788, 925);
            this.Controls.Add(this.AppropriationCarousel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "AppropriationSelector";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.Carousel AppropriationCarousel;
    }
}