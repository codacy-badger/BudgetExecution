﻿// <copyright file="Selector.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public partial class DatabaseSelector : MetroForm
    {
        // CONSTRUCTORS
        public DatabaseSelector()
        {
            InitializeComponent();
            FunctionImages = Info.FunctionImages;
            NinjaData = new FormData();
            GetViewerCarouselImageList(FunctionImages);
            ViewerCarousel.OnCarouselItemFocused += ViewerCarousel_OnImageSelected;
        }

        public DatabaseSelector(string path)
        {
            InitializeComponent();
            NinjaData = new FormData();
            GetViewerCarouselImageList(path);
            ViewerCarousel.OnCarouselItemFocused += ViewerCarousel_OnImageSelected;
        }

        // PROPERTIES
        // PROPERTIES
        private string FunctionImages { get; set; }

        private string DivisionImages { get; set; }

        private string SummaryImages { get; set; }

        private string FilePath { get; set; }

        public FormData NinjaData { get; set; }

        private string[] Images { get; set; }

        // METHODS
        private void GetViewerCarouselImageList(string path)
        {
            ImageList ilist = new ImageList();
            CarouselImageCollection icollect = ViewerCarousel.ImageListCollection;
            ViewerCarousel.ImageSlides = true;
            ViewerCarousel.UseOriginalImageinPreview = true;
            string[] images = Directory.GetFiles(path);
            FilePath = path;
            foreach (string i in images)
            {
                var p = Path.GetFileNameWithoutExtension(i);
                var b = new Bitmap(i);
                b.Tag = p;
                var c = new CarouselImage();
                c.ItemImage = b;
                ilist.Images.Add(b);
                icollect.Add(c);
            }

            ViewerCarousel.ImageList = ilist;
        }

        private void Selector_Load(object sender, EventArgs e)
        {
        }

        private void ViewerCarousel_OnImageSelected(object sender, EventArgs e)
        {
            var carousel = sender as Carousel;
            var i = carousel.ActiveImage.Tag.ToString();
            var s = (Source)Enum.Parse(typeof(Source), i);
            var data = new SQLiteData(s, Provider.SQLite);
            data.Show();
            this.Close();
            
        }
    }
}