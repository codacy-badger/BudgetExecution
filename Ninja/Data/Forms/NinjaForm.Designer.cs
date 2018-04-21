namespace Ninja.Data.Forms
{
    partial class NinjaForm
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
            this.ViewerCarousel = new Syncfusion.Windows.Forms.Tools.Carousel();
            this.SuspendLayout();
            // 
            // ViewerCarousel
            // 
            this.ViewerCarousel.BackColor = System.Drawing.Color.Black;
            this.ViewerCarousel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ViewerCarousel.CarouselBounds = 200;
            this.ViewerCarousel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewerCarousel.HighlightColor = System.Drawing.SystemColors.MenuHighlight;
            this.ViewerCarousel.ImageshadeColor = System.Drawing.Color.Black;
            this.ViewerCarousel.ImageSlides = true;
            this.ViewerCarousel.Location = new System.Drawing.Point(377, 226);
            this.ViewerCarousel.Margin = new System.Windows.Forms.Padding(2);
            this.ViewerCarousel.MaximumSize = new System.Drawing.Size(900, 600);
            this.ViewerCarousel.Name = "ViewerCarousel";
            this.ViewerCarousel.PadX = 1;
            this.ViewerCarousel.PadY = 0;
            this.ViewerCarousel.Perspective = 4F;
            this.ViewerCarousel.RotateAlways = false;
            this.ViewerCarousel.ShowImagePreview = true;
            this.ViewerCarousel.ShowImageShadow = true;
            this.ViewerCarousel.Size = new System.Drawing.Size(835, 500);
            this.ViewerCarousel.TabIndex = 2;
            this.ViewerCarousel.Text = "carousel2";
            this.ViewerCarousel.TouchTransitionSpeed = 3F;
            this.ViewerCarousel.UseOriginalImageinPreview = false;
            this.ViewerCarousel.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Default;
            // 
            // NinjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1588, 953);
            this.Controls.Add(this.ViewerCarousel);
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "NinjaForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.Carousel ViewerCarousel;
    }
}