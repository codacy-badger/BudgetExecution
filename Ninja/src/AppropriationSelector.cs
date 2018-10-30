// <copyright file="AppropriationSelector.cs" company="PlaceholderCompany">
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

    public partial class AppropriationSelector : MetroForm
    {
        public AppropriationSelector()
        {
            InitializeComponent();
            GetAppropriationCarouselImageList(Info.AppropriationImages);
            AppropriationCarousel.OnCarouselItemFocused += AppropriationCarousel_OnImageSelected;
        }

        public AppropriationSelector(string path)
        {
            InitializeComponent();
            FilePath = path;
            GetAppropriationCarouselImageList(path);
            AppropriationCarousel.OnCarouselItemFocused += AppropriationCarousel_OnImageSelected;
        }

        // PROPERTIES
        private string FilePath { get; }

        // METHODS
        private void AppropriationCarousel_OnImageSelected(object sender, EventArgs e)
        {
            try
            {
                Carousel carousel = sender as Carousel;
                string i = carousel.ActiveImage.Tag.ToString();
                Source s = (Source)Enum.Parse(typeof(Source), i);
                SummaryForm sf = new SummaryForm(s, Provider.SQLite);
                sf.Show();
                Close();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GetAppropriationCarouselImageList(string path)
        {
            try
            {
                ImageList ilist = new ImageList();
                CarouselImageCollection icollect = AppropriationCarousel.ImageListCollection;
                AppropriationCarousel.ImageSlides = true;
                AppropriationCarousel.UseOriginalImageinPreview = true;
                string[] images = Directory.GetFiles(path);
                foreach (string i in images)
                {
                    Bitmap b = new Bitmap(i);
                    b.Tag = i;
                    CarouselImage c = new CarouselImage();
                    c.ItemImage = b;
                    ilist.Images.Add(b);
                    icollect.Add(c);
                }

                AppropriationCarousel.ImageList = ilist;
            }
            catch (Exception e)
            {
                new Error(e).ShowDialog();
            }
        }
    }
}
