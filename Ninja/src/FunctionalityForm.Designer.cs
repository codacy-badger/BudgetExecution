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
            Syncfusion.Windows.Forms.Tools.TextItem textItem9 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem10 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem11 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem12 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem13 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem14 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem15 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem16 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            this.BudgetServerTile = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.hubTile1 = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.hubTile2 = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.hubTile3 = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.FunctionCarousel = new Syncfusion.Windows.Forms.Tools.Carousel();
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
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BudgetServerTile
            // 
            this.BudgetServerTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem1.HubTile = this.BudgetServerTile;
            textItem1.Text = "Functionality | Budget Tools";
            this.BudgetServerTile.Banner = textItem1;
            this.BudgetServerTile.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BudgetServerTile.BannerHeight = 20;
            this.BudgetServerTile.BannerIcon = ((System.Drawing.Image)(resources.GetObject("BudgetServerTile.BannerIcon")));
            textItem2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem2.HubTile = this.BudgetServerTile;
            this.BudgetServerTile.Body = textItem2;
            this.BudgetServerTile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem3.HubTile = this.BudgetServerTile;
            this.BudgetServerTile.Footer = textItem3;
            this.BudgetServerTile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.BudgetServerTile.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.BudgetServerTile.ImageSource = ((System.Drawing.Image)(resources.GetObject("BudgetServerTile.ImageSource")));
            this.BudgetServerTile.Location = new System.Drawing.Point(1185, 38);
            this.BudgetServerTile.Margin = new System.Windows.Forms.Padding(1);
            this.BudgetServerTile.MinimumSize = new System.Drawing.Size(100, 100);
            this.BudgetServerTile.Name = "BudgetServerTile";
            this.BudgetServerTile.SelectionMarkerColor = System.Drawing.Color.SteelBlue;
            this.BudgetServerTile.ShowBanner = true;
            this.BudgetServerTile.ShowBannerIcon = true;
            this.BudgetServerTile.ShowRotateTileBanner = true;
            this.BudgetServerTile.Size = new System.Drawing.Size(246, 136);
            this.BudgetServerTile.SwitchRotateTileBannerVisibility = true;
            this.BudgetServerTile.TabIndex = 71;
            textItem4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem4.HubTile = this.BudgetServerTile;
            this.BudgetServerTile.Title = textItem4;
            // 
            // hubTile1
            // 
            this.hubTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textItem5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem5.HubTile = this.hubTile1;
            textItem5.Text = "Functionality | Budget Tools";
            this.hubTile1.Banner = textItem5;
            this.hubTile1.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hubTile1.BannerHeight = 20;
            this.hubTile1.BannerIcon = ((System.Drawing.Image)(resources.GetObject("hubTile1.BannerIcon")));
            textItem6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem6.HubTile = this.hubTile1;
            this.hubTile1.Body = textItem6;
            this.hubTile1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem7.HubTile = this.hubTile1;
            this.hubTile1.Footer = textItem7;
            this.hubTile1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.hubTile1.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.hubTile1.ImageSource = ((System.Drawing.Image)(resources.GetObject("hubTile1.ImageSource")));
            this.hubTile1.Location = new System.Drawing.Point(48, 31);
            this.hubTile1.Margin = new System.Windows.Forms.Padding(1);
            this.hubTile1.MinimumSize = new System.Drawing.Size(100, 100);
            this.hubTile1.Name = "hubTile1";
            this.hubTile1.SelectionMarkerColor = System.Drawing.Color.SteelBlue;
            this.hubTile1.ShowBanner = true;
            this.hubTile1.ShowBannerIcon = true;
            this.hubTile1.ShowRotateTileBanner = true;
            this.hubTile1.Size = new System.Drawing.Size(272, 143);
            this.hubTile1.SwitchRotateTileBannerVisibility = true;
            this.hubTile1.TabIndex = 72;
            textItem8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem8.HubTile = this.hubTile1;
            this.hubTile1.Title = textItem8;
            // 
            // hubTile2
            // 
            this.hubTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textItem9.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem9.HubTile = this.hubTile2;
            textItem9.Text = "Functionality | Budget Tools";
            this.hubTile2.Banner = textItem9;
            this.hubTile2.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hubTile2.BannerHeight = 20;
            this.hubTile2.BannerIcon = ((System.Drawing.Image)(resources.GetObject("hubTile2.BannerIcon")));
            textItem10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem10.HubTile = this.hubTile2;
            this.hubTile2.Body = textItem10;
            this.hubTile2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem11.HubTile = this.hubTile2;
            this.hubTile2.Footer = textItem11;
            this.hubTile2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.hubTile2.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.hubTile2.ImageSource = ((System.Drawing.Image)(resources.GetObject("hubTile2.ImageSource")));
            this.hubTile2.Location = new System.Drawing.Point(48, 337);
            this.hubTile2.Margin = new System.Windows.Forms.Padding(1);
            this.hubTile2.MinimumSize = new System.Drawing.Size(100, 100);
            this.hubTile2.Name = "hubTile2";
            this.hubTile2.SelectionMarkerColor = System.Drawing.Color.SteelBlue;
            this.hubTile2.ShowBanner = true;
            this.hubTile2.ShowBannerIcon = true;
            this.hubTile2.ShowRotateTileBanner = true;
            this.hubTile2.Size = new System.Drawing.Size(272, 161);
            this.hubTile2.SwitchRotateTileBannerVisibility = true;
            this.hubTile2.TabIndex = 73;
            textItem12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem12.HubTile = this.hubTile2;
            this.hubTile2.Title = textItem12;
            // 
            // hubTile3
            // 
            this.hubTile3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textItem13.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem13.HubTile = this.hubTile3;
            textItem13.Text = "Functionality | Budget Tools";
            this.hubTile3.Banner = textItem13;
            this.hubTile3.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hubTile3.BannerHeight = 20;
            this.hubTile3.BannerIcon = ((System.Drawing.Image)(resources.GetObject("hubTile3.BannerIcon")));
            textItem14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem14.HubTile = this.hubTile3;
            this.hubTile3.Body = textItem14;
            this.hubTile3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem15.HubTile = this.hubTile3;
            this.hubTile3.Footer = textItem15;
            this.hubTile3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.hubTile3.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.hubTile3.ImageSource = ((System.Drawing.Image)(resources.GetObject("hubTile3.ImageSource")));
            this.hubTile3.Location = new System.Drawing.Point(1187, 326);
            this.hubTile3.Margin = new System.Windows.Forms.Padding(1);
            this.hubTile3.MinimumSize = new System.Drawing.Size(100, 100);
            this.hubTile3.Name = "hubTile3";
            this.hubTile3.SelectionMarkerColor = System.Drawing.Color.SteelBlue;
            this.hubTile3.ShowBanner = true;
            this.hubTile3.ShowBannerIcon = true;
            this.hubTile3.ShowRotateTileBanner = true;
            this.hubTile3.Size = new System.Drawing.Size(244, 152);
            this.hubTile3.SwitchRotateTileBannerVisibility = true;
            this.hubTile3.TabIndex = 74;
            textItem16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem16.HubTile = this.hubTile3;
            this.hubTile3.Title = textItem16;
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
            this.FunctionCarousel.Location = new System.Drawing.Point(1257, 633);
            this.FunctionCarousel.Margin = new System.Windows.Forms.Padding(2);
            this.FunctionCarousel.Name = "FunctionCarousel";
            this.FunctionCarousel.PadX = 0;
            this.FunctionCarousel.PadY = 1;
            this.FunctionCarousel.Perspective = 5F;
            this.FunctionCarousel.RotateAlways = false;
            this.FunctionCarousel.ShowImagePreview = true;
            this.FunctionCarousel.ShowImageShadow = true;
            this.FunctionCarousel.Size = new System.Drawing.Size(174, 194);
            this.FunctionCarousel.TabIndex = 6;
            this.FunctionCarousel.Text = "carousel2";
            this.FunctionCarousel.TouchTransitionSpeed = 1F;
            this.FunctionCarousel.UseOriginalImageinPreview = false;
            this.FunctionCarousel.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Default;
            this.FunctionCarousel.Click += new System.EventHandler(this.FunctionCarousel_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1017, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(794, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Info;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1021, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 68);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.Info;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(438, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 104);
            this.button4.TabIndex = 10;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.Info;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(711, 744);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 68);
            this.button5.TabIndex = 11;
            this.button5.Text = "button5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.Info;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(78, 633);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 104);
            this.button6.TabIndex = 12;
            this.button6.Text = "button6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.Info;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(1025, 326);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 51);
            this.button7.TabIndex = 13;
            this.button7.Text = "button7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.Info;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(1025, 395);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 51);
            this.button8.TabIndex = 14;
            this.button8.Text = "button8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.Info;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(785, 465);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(159, 52);
            this.button9.TabIndex = 15;
            this.button9.Text = "button9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.Info;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(475, 420);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(140, 68);
            this.button10.TabIndex = 16;
            this.button10.Text = "button10";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.SystemColors.Info;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(698, 633);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(140, 68);
            this.button11.TabIndex = 17;
            this.button11.Text = "button11";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.SystemColors.Info;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(630, 559);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(140, 68);
            this.button12.TabIndex = 18;
            this.button12.Text = "button12";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.SystemColors.Info;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(528, 744);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(140, 68);
            this.button13.TabIndex = 19;
            this.button13.Text = "button13";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.SystemColors.Info;
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(266, 633);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(168, 104);
            this.button14.TabIndex = 20;
            this.button14.Text = "button14";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ForeColor = System.Drawing.SystemColors.Info;
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.Location = new System.Drawing.Point(1021, 53);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(140, 55);
            this.button16.TabIndex = 22;
            this.button16.Text = "button16";
            this.button16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.ForeColor = System.Drawing.SystemColors.Info;
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.Location = new System.Drawing.Point(1025, 460);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(140, 57);
            this.button17.TabIndex = 23;
            this.button17.Text = "button17";
            this.button17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.ForeColor = System.Drawing.SystemColors.Info;
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.Location = new System.Drawing.Point(961, 575);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(140, 68);
            this.button18.TabIndex = 24;
            this.button18.Text = "button18";
            this.button18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.SystemColors.Info;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(603, 10);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(167, 104);
            this.button15.TabIndex = 25;
            this.button15.Text = "button15";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.ForeColor = System.Drawing.SystemColors.Info;
            this.button19.Image = ((System.Drawing.Image)(resources.GetObject("button19.Image")));
            this.button19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.Location = new System.Drawing.Point(630, 464);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(147, 53);
            this.button19.TabIndex = 26;
            this.button19.Text = "button19";
            this.button19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.ForeColor = System.Drawing.SystemColors.Info;
            this.button20.Image = ((System.Drawing.Image)(resources.GetObject("button20.Image")));
            this.button20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button20.Location = new System.Drawing.Point(630, 389);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(147, 57);
            this.button20.TabIndex = 27;
            this.button20.Text = "button20";
            this.button20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button20.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.hubTile3);
            this.Controls.Add(this.hubTile2);
            this.Controls.Add(this.hubTile1);
            this.Controls.Add(this.BudgetServerTile);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FunctionCarousel);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "FunctionalityForm";
            this.ShowIcon = false;
            this.Text = "Functionality";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.Carousel FunctionCarousel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button15;
        private Button button19;
        private Button button20;
        private HubTile BudgetServerTile;
        private HubTile hubTile1;
        private HubTile hubTile2;
        private HubTile hubTile3;
    }
}