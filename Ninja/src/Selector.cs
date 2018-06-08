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

    public partial class Selector : MetroForm
    {
        // CONSTRUCTORS
        public Selector()
        {
        }

        public Selector(string path)
        {
            InitializeComponent();
            NinjaData = new FormData();
            GetViewerCarouselImageList(path);
            ViewerCarousel.OnCarouselItemFocused += ViewerCarousel_OnImageSelected;
        }

        // PROPERTIES
        private string DivisionImages { get; set; }

        private string SummaryImages { get; set; }

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
            var i = ViewerCarousel.ActiveImage.Tag.ToString();
            if (i.Length > 3 || i.Equals("FTE"))
            {
                var s = (Source)Enum.Parse(typeof(Source), i.ToString());
                var a = new SummaryForm(s);
                a.Show();
            }
            else
            {
                var b = new SummaryForm(i);
                b.Show();
            }
        }
    }
}
