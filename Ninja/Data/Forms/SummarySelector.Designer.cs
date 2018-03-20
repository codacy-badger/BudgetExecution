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

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            partial class SummarySelector : MetroForm
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
                    this.ViewerCarousel = new Syncfusion.Windows.Forms.Tools.Carousel( );
                    this.SuspendLayout( );
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
                    this.ViewerCarousel.Location = new System.Drawing.Point(287, 125);
                    this.ViewerCarousel.Margin = new System.Windows.Forms.Padding(2);
                    this.ViewerCarousel.Name = "ViewerCarousel";
                    this.ViewerCarousel.PadX = 1;
                    this.ViewerCarousel.PadY = 0;
                    this.ViewerCarousel.Perspective = 4F;
                    this.ViewerCarousel.RotateAlways = false;
                    this.ViewerCarousel.ShowImagePreview = true;
                    this.ViewerCarousel.ShowImageShadow = true;
                    this.ViewerCarousel.Size = new System.Drawing.Size(1136, 630);
                    this.ViewerCarousel.TabIndex = 1;
                    this.ViewerCarousel.Text = "carousel2";
                    this.ViewerCarousel.TouchTransitionSpeed = 3F;
                    this.ViewerCarousel.UseOriginalImageinPreview = false;
                    this.ViewerCarousel.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Default;
                    // 
                    // SummarySelector
                    // 
                    this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
                    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                    this.BackColor = System.Drawing.Color.Black;
                    this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
                    this.CaptionBarColor = System.Drawing.Color.Black;
                    this.CaptionBarHeight = 60;
                    this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
                    this.ClientSize = new System.Drawing.Size(1788, 934);
                    this.Controls.Add(this.ViewerCarousel);
                    this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
                    this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                    this.MaximumSize = new System.Drawing.Size(1800, 1000);
                    this.MetroColor = System.Drawing.Color.Black;
                    this.Name = "SummarySelector";
                    this.ShowIcon = false;
                    this.Load += new System.EventHandler(this.SummarySelector_Load);
                    this.ResumeLayout(false);

                }

                #endregion

                private Syncfusion.Windows.Forms.Tools.Carousel ViewerCarousel;
            } 
        }
    }
}