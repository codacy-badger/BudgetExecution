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

namespace Budget.Ninja.Data
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.TextItem textItem1 = new Syncfusion.Windows.Forms.Tools.TextItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionalityForm));
            Syncfusion.Windows.Forms.Tools.TextItem textItem2 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem3 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem4 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem5 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem6 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem7 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem8 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            this.DataTile = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.hubTile1 = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.DivisionCarousel = new Syncfusion.Windows.Forms.Tools.Carousel();
            this.DatabaseCarousel = new Syncfusion.Windows.Forms.Tools.Carousel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTile
            // 
            this.DataTile.BackColor = System.Drawing.Color.Black;
            textItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem1.HubTile = this.DataTile;
            textItem1.Text = "Summary";
            this.DataTile.Banner = textItem1;
            this.DataTile.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataTile.BannerHeight = 30;
            this.DataTile.BannerIcon = ((System.Drawing.Image)(resources.GetObject("DataTile.BannerIcon")));
            textItem2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem2.HubTile = this.DataTile;
            this.DataTile.Body = textItem2;
            this.DataTile.EnableSelectionMarker = false;
            this.DataTile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem3.HubTile = this.DataTile;
            textItem3.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.DataTile.Footer = textItem3;
            this.DataTile.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.DataTile.ImageSource = ((System.Drawing.Image)(resources.GetObject("DataTile.ImageSource")));
            this.DataTile.Location = new System.Drawing.Point(58, 54);
            this.DataTile.Margin = new System.Windows.Forms.Padding(1);
            this.DataTile.MinimumSize = new System.Drawing.Size(69, 66);
            this.DataTile.Name = "DataTile";
            this.DataTile.PulseScale = 2;
            this.DataTile.ShowBanner = true;
            this.DataTile.ShowBannerIcon = true;
            this.DataTile.Size = new System.Drawing.Size(206, 99);
            this.DataTile.TabIndex = 25;
            textItem4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem4.HubTile = this.DataTile;
            this.DataTile.Title = textItem4;
            // 
            // hubTile1
            // 
            this.hubTile1.BackColor = System.Drawing.Color.Black;
            textItem5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem5.HubTile = this.hubTile1;
            textItem5.Text = "Reprogramming ";
            this.hubTile1.Banner = textItem5;
            this.hubTile1.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hubTile1.BannerHeight = 30;
            this.hubTile1.BannerIcon = ((System.Drawing.Image)(resources.GetObject("hubTile1.BannerIcon")));
            textItem6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem6.HubTile = this.hubTile1;
            this.hubTile1.Body = textItem6;
            this.hubTile1.EnableSelectionMarker = false;
            this.hubTile1.EnableTileSlideEffect = false;
            this.hubTile1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem7.HubTile = this.hubTile1;
            this.hubTile1.Footer = textItem7;
            this.hubTile1.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.hubTile1.ImageSource = ((System.Drawing.Image)(resources.GetObject("hubTile1.ImageSource")));
            this.hubTile1.Location = new System.Drawing.Point(319, 54);
            this.hubTile1.Margin = new System.Windows.Forms.Padding(1);
            this.hubTile1.MinimumSize = new System.Drawing.Size(69, 66);
            this.hubTile1.Name = "hubTile1";
            this.hubTile1.ShowBanner = true;
            this.hubTile1.ShowBannerIcon = true;
            this.hubTile1.ShowRotateTileBanner = true;
            this.hubTile1.Size = new System.Drawing.Size(206, 99);
            this.hubTile1.SlideTransition = Syncfusion.Windows.Forms.Tools.TransitionDirection.BottomToTop;
            this.hubTile1.TabIndex = 26;
            textItem8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem8.HubTile = this.hubTile1;
            this.hubTile1.Title = textItem8;
            // 
            // DivisionCarousel
            // 
            this.DivisionCarousel.BackColor = System.Drawing.Color.Black;
            this.DivisionCarousel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DivisionCarousel.CarouselBounds = 200;
            this.DivisionCarousel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionCarousel.HighlightColor = System.Drawing.Color.Lavender;
            this.DivisionCarousel.ImageshadeColor = System.Drawing.Color.Black;
            this.DivisionCarousel.ImageSlides = true;
            this.DivisionCarousel.Location = new System.Drawing.Point(81, 65);
            this.DivisionCarousel.Margin = new System.Windows.Forms.Padding(2);
            this.DivisionCarousel.Name = "DivisionCarousel";
            this.DivisionCarousel.PadX = 0;
            this.DivisionCarousel.PadY = 1;
            this.DivisionCarousel.Perspective = 5F;
            this.DivisionCarousel.RotateAlways = false;
            this.DivisionCarousel.ShowImagePreview = true;
            this.DivisionCarousel.ShowImageShadow = true;
            this.DivisionCarousel.Size = new System.Drawing.Size(1033, 400);
            this.DivisionCarousel.TabIndex = 6;
            this.DivisionCarousel.Text = "carousel2";
            this.DivisionCarousel.TouchTransitionSpeed = 1F;
            this.DivisionCarousel.UseOriginalImageinPreview = false;
            this.DivisionCarousel.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Default;
            // 
            // DatabaseCarousel
            // 
            this.DatabaseCarousel.BackColor = System.Drawing.Color.Black;
            this.DatabaseCarousel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DatabaseCarousel.CarouselBounds = 200;
            this.DatabaseCarousel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseCarousel.HighlightColor = System.Drawing.Color.Lavender;
            this.DatabaseCarousel.ImageshadeColor = System.Drawing.Color.Black;
            this.DatabaseCarousel.ImageSlides = true;
            this.DatabaseCarousel.Location = new System.Drawing.Point(28, 11);
            this.DatabaseCarousel.Margin = new System.Windows.Forms.Padding(2);
            this.DatabaseCarousel.Name = "DatabaseCarousel";
            this.DatabaseCarousel.PadX = 0;
            this.DatabaseCarousel.PadY = 1;
            this.DatabaseCarousel.Perspective = 5F;
            this.DatabaseCarousel.RotateAlways = false;
            this.DatabaseCarousel.ShowImagePreview = true;
            this.DatabaseCarousel.ShowImageShadow = true;
            this.DatabaseCarousel.Size = new System.Drawing.Size(577, 511);
            this.DatabaseCarousel.TabIndex = 7;
            this.DatabaseCarousel.Text = "carousel2";
            this.DatabaseCarousel.TouchTransitionSpeed = 1F;
            this.DatabaseCarousel.UseOriginalImageinPreview = true;
            this.DatabaseCarousel.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Default;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button12);
            this.splitContainer1.Panel1.Controls.Add(this.button11);
            this.splitContainer1.Panel1.Controls.Add(this.button10);
            this.splitContainer1.Panel1.Controls.Add(this.button9);
            this.splitContainer1.Panel1.Controls.Add(this.button8);
            this.splitContainer1.Panel1.Controls.Add(this.button7);
            this.splitContainer1.Panel1.Controls.Add(this.button6);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.hubTile1);
            this.splitContainer1.Panel1.Controls.Add(this.DataTile);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DivisionCarousel);
            this.splitContainer1.Panel2.Controls.Add(this.DatabaseCarousel);
            this.splitContainer1.Size = new System.Drawing.Size(1788, 924);
            this.splitContainer1.SplitterDistance = 564;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(84, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 73);
            this.button1.TabIndex = 30;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(300, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 73);
            this.button2.TabIndex = 31;
            this.button2.Text = "button2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(84, 525);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 73);
            this.button3.TabIndex = 32;
            this.button3.Text = "button3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Location = new System.Drawing.Point(84, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 73);
            this.button4.TabIndex = 33;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.Location = new System.Drawing.Point(300, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 73);
            this.button5.TabIndex = 34;
            this.button5.Text = "button5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.Location = new System.Drawing.Point(300, 525);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 73);
            this.button6.TabIndex = 35;
            this.button6.Text = "button6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button7.Location = new System.Drawing.Point(75, 204);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 73);
            this.button7.TabIndex = 36;
            this.button7.Text = "button7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button8.Location = new System.Drawing.Point(300, 204);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(154, 73);
            this.button8.TabIndex = 37;
            this.button8.Text = "button8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button9.Location = new System.Drawing.Point(84, 628);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(154, 73);
            this.button9.TabIndex = 38;
            this.button9.Text = "button9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button10.Location = new System.Drawing.Point(300, 628);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(154, 73);
            this.button10.TabIndex = 39;
            this.button10.Text = "button10";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button11.Location = new System.Drawing.Point(84, 755);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(154, 73);
            this.button11.TabIndex = 40;
            this.button11.Text = "button11";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button12.Location = new System.Drawing.Point(300, 739);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(154, 73);
            this.button12.TabIndex = 41;
            this.button12.Text = "button12";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // FunctionalityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionBarHeight = 70;
            this.CaptionFont = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.SystemColors.MenuHighlight;
            captionImage1.BackColor = System.Drawing.Color.Black;
            captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(100, 50);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(1788, 924);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1800, 1000);
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "FunctionalityForm";
            this.ShowIcon = false;
            this.Text = "Functionality";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.Carousel DivisionCarousel;
        private Syncfusion.Windows.Forms.Tools.Carousel DatabaseCarousel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private HubTile hubTile1;
        private HubTile DataTile;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}