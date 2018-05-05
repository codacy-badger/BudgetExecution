#region Using Directives

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroSet_UI.Controls;
using MetroFramework.Controls;
using MetroForm = Syncfusion.Windows.Forms.MetroForm;

#endregion

namespace BudgetExecution
{
    partial class FunctionalityForm
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
            this.FunctionCarousel = new Syncfusion.Windows.Forms.Tools.Carousel();
            this.SuspendLayout();
            // 
            // FunctionCarousel
            // 
            this.FunctionCarousel.BackColor = System.Drawing.Color.Black;
            this.FunctionCarousel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FunctionCarousel.CarouselBounds = 200;
            this.FunctionCarousel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionCarousel.HighlightColor = System.Drawing.Color.Lavender;
            this.FunctionCarousel.ImageshadeColor = System.Drawing.Color.Black;
            this.FunctionCarousel.ImageSlides = true;
            this.FunctionCarousel.Location = new System.Drawing.Point(258, 65);
            this.FunctionCarousel.Margin = new System.Windows.Forms.Padding(2);
            this.FunctionCarousel.Name = "FunctionCarousel";
            this.FunctionCarousel.PadX = 0;
            this.FunctionCarousel.PadY = 1;
            this.FunctionCarousel.Perspective = 5F;
            this.FunctionCarousel.RotateAlways = false;
            this.FunctionCarousel.ShowImagePreview = true;
            this.FunctionCarousel.ShowImageShadow = true;
            this.FunctionCarousel.Size = new System.Drawing.Size(1145, 566);
            this.FunctionCarousel.TabIndex = 6;
            this.FunctionCarousel.Text = "carousel2";
            this.FunctionCarousel.TouchTransitionSpeed = 1F;
            this.FunctionCarousel.UseOriginalImageinPreview = false;
            this.FunctionCarousel.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Default;
            // 
            // FunctionalityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionBarHeight = 70;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
            captionImage1.BackColor = System.Drawing.Color.Black;
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(100, 50);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(1588, 924);
            this.Controls.Add(this.FunctionCarousel);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "FunctionalityForm";
            this.ShowIcon = false;
            this.Text = "Functionality";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.Carousel FunctionCarousel;
    }
}