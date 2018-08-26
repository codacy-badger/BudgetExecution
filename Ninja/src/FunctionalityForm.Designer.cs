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
            Syncfusion.Windows.Forms.Tools.TextItem textItem17 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem18 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem19 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem20 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem21 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem22 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem23 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem24 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionalityForm));
            this.BudgetServerTile = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.hubTile1 = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.hubTile2 = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.hubTile3 = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.hubTile4 = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.hubTile5 = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.FunctionCarousel = new Syncfusion.Windows.Forms.Tools.Carousel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
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
            textItem2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem2.HubTile = this.BudgetServerTile;
            this.BudgetServerTile.Body = textItem2;
            this.BudgetServerTile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem3.HubTile = this.BudgetServerTile;
            this.BudgetServerTile.Footer = textItem3;
            this.BudgetServerTile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.BudgetServerTile.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.BudgetServerTile.Location = new System.Drawing.Point(882, 121);
            this.BudgetServerTile.Margin = new System.Windows.Forms.Padding(1);
            this.BudgetServerTile.MinimumSize = new System.Drawing.Size(100, 100);
            this.BudgetServerTile.Name = "BudgetServerTile";
            this.BudgetServerTile.SelectionMarkerColor = System.Drawing.Color.SteelBlue;
            this.BudgetServerTile.ShowBanner = true;
            this.BudgetServerTile.ShowBannerIcon = true;
            this.BudgetServerTile.ShowRotateTileBanner = true;
            this.BudgetServerTile.Size = new System.Drawing.Size(261, 105);
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
            textItem6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem6.HubTile = this.hubTile1;
            this.hubTile1.Body = textItem6;
            this.hubTile1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem7.HubTile = this.hubTile1;
            this.hubTile1.Footer = textItem7;
            this.hubTile1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.hubTile1.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.hubTile1.Location = new System.Drawing.Point(855, 477);
            this.hubTile1.Margin = new System.Windows.Forms.Padding(1);
            this.hubTile1.MinimumSize = new System.Drawing.Size(100, 100);
            this.hubTile1.Name = "hubTile1";
            this.hubTile1.SelectionMarkerColor = System.Drawing.Color.SteelBlue;
            this.hubTile1.ShowBanner = true;
            this.hubTile1.ShowBannerIcon = true;
            this.hubTile1.ShowRotateTileBanner = true;
            this.hubTile1.Size = new System.Drawing.Size(329, 240);
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
            textItem10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem10.HubTile = this.hubTile2;
            this.hubTile2.Body = textItem10;
            this.hubTile2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem11.HubTile = this.hubTile2;
            this.hubTile2.Footer = textItem11;
            this.hubTile2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.hubTile2.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.hubTile2.Location = new System.Drawing.Point(1192, 121);
            this.hubTile2.Margin = new System.Windows.Forms.Padding(1);
            this.hubTile2.MinimumSize = new System.Drawing.Size(100, 100);
            this.hubTile2.Name = "hubTile2";
            this.hubTile2.SelectionMarkerColor = System.Drawing.Color.SteelBlue;
            this.hubTile2.ShowBanner = true;
            this.hubTile2.ShowBannerIcon = true;
            this.hubTile2.ShowRotateTileBanner = true;
            this.hubTile2.Size = new System.Drawing.Size(324, 264);
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
            textItem14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem14.HubTile = this.hubTile3;
            this.hubTile3.Body = textItem14;
            this.hubTile3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem15.HubTile = this.hubTile3;
            this.hubTile3.Footer = textItem15;
            this.hubTile3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.hubTile3.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.hubTile3.Location = new System.Drawing.Point(48, 111);
            this.hubTile3.Margin = new System.Windows.Forms.Padding(1);
            this.hubTile3.MinimumSize = new System.Drawing.Size(100, 100);
            this.hubTile3.Name = "hubTile3";
            this.hubTile3.SelectionMarkerColor = System.Drawing.Color.SteelBlue;
            this.hubTile3.ShowBanner = true;
            this.hubTile3.ShowBannerIcon = true;
            this.hubTile3.ShowRotateTileBanner = true;
            this.hubTile3.Size = new System.Drawing.Size(340, 261);
            this.hubTile3.SwitchRotateTileBannerVisibility = true;
            this.hubTile3.TabIndex = 74;
            textItem16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem16.HubTile = this.hubTile3;
            this.hubTile3.Title = textItem16;
            // 
            // hubTile4
            // 
            this.hubTile4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textItem17.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem17.HubTile = this.hubTile4;
            textItem17.Text = "Functionality | Budget Tools";
            this.hubTile4.Banner = textItem17;
            this.hubTile4.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hubTile4.BannerHeight = 20;
            textItem18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem18.HubTile = this.hubTile4;
            this.hubTile4.Body = textItem18;
            this.hubTile4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem19.HubTile = this.hubTile4;
            this.hubTile4.Footer = textItem19;
            this.hubTile4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.hubTile4.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.hubTile4.Location = new System.Drawing.Point(882, 277);
            this.hubTile4.Margin = new System.Windows.Forms.Padding(1);
            this.hubTile4.MinimumSize = new System.Drawing.Size(100, 100);
            this.hubTile4.Name = "hubTile4";
            this.hubTile4.SelectionMarkerColor = System.Drawing.Color.SteelBlue;
            this.hubTile4.ShowBanner = true;
            this.hubTile4.ShowBannerIcon = true;
            this.hubTile4.ShowRotateTileBanner = true;
            this.hubTile4.Size = new System.Drawing.Size(246, 108);
            this.hubTile4.SwitchRotateTileBannerVisibility = true;
            this.hubTile4.TabIndex = 75;
            textItem20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem20.HubTile = this.hubTile4;
            this.hubTile4.Title = textItem20;
            // 
            // hubTile5
            // 
            this.hubTile5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textItem21.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textItem21.HubTile = this.hubTile5;
            textItem21.Text = "Functionality | Budget Tools";
            this.hubTile5.Banner = textItem21;
            this.hubTile5.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hubTile5.BannerHeight = 20;
            textItem22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem22.HubTile = this.hubTile5;
            this.hubTile5.Body = textItem22;
            this.hubTile5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem23.HubTile = this.hubTile5;
            this.hubTile5.Footer = textItem23;
            this.hubTile5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.hubTile5.HoveredBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.hubTile5.Location = new System.Drawing.Point(376, 516);
            this.hubTile5.Margin = new System.Windows.Forms.Padding(1);
            this.hubTile5.MinimumSize = new System.Drawing.Size(100, 100);
            this.hubTile5.Name = "hubTile5";
            this.hubTile5.SelectionMarkerColor = System.Drawing.Color.SteelBlue;
            this.hubTile5.ShowBanner = true;
            this.hubTile5.ShowBannerIcon = true;
            this.hubTile5.ShowRotateTileBanner = true;
            this.hubTile5.Size = new System.Drawing.Size(372, 261);
            this.hubTile5.SwitchRotateTileBannerVisibility = true;
            this.hubTile5.TabIndex = 76;
            textItem24.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem24.HubTile = this.hubTile5;
            this.hubTile5.Title = textItem24;
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
            this.FunctionCarousel.Location = new System.Drawing.Point(1234, 643);
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
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.Info;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(48, 493);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(242, 74);
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
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(465, 293);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(224, 79);
            this.button6.TabIndex = 12;
            this.button6.Text = "button6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.SystemColors.Info;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(48, 599);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(242, 68);
            this.button11.TabIndex = 17;
            this.button11.Text = "button11";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.SystemColors.Info;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(465, 111);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(233, 78);
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
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(48, 698);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(242, 79);
            this.button14.TabIndex = 20;
            this.button14.Text = "button14";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.hubTile5);
            this.Controls.Add(this.hubTile4);
            this.Controls.Add(this.hubTile3);
            this.Controls.Add(this.hubTile2);
            this.Controls.Add(this.hubTile1);
            this.Controls.Add(this.BudgetServerTile);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.FunctionCarousel);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "FunctionalityForm";
            this.ShowIcon = false;
            this.Text = "Functionality";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.Carousel FunctionCarousel;
        private Button button5;
        private Button button6;
        private Button button11;
        private Button button13;
        private Button button14;
        private HubTile BudgetServerTile;
        private HubTile hubTile1;
        private HubTile hubTile2;
        private HubTile hubTile3;
        private HubTile hubTile4;
        private HubTile hubTile5;
    }
}