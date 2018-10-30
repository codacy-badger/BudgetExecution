// <copyright file="DatabaseSelector.cs" company="PlaceholderCompany">
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
            NinjaData = new FormData();
            FilePath = Info.DatabaseImages;
            GetViewerCarouselImageList(FilePath);
            ViewerCarousel.OnCarouselItemFocused += ViewerCarousel_OnImageSelected;
        }

        public DatabaseSelector(string path)
        {
            InitializeComponent();
            NinjaData = new FormData();
            FilePath = path;
            GetViewerCarouselImageList(FilePath);
            ViewerCarousel.OnCarouselItemFocused += ViewerCarousel_OnImageSelected;
        }

        // PROPERTIES
        private string FilePath { get; set; }

        private string[] Images { get; set; }

        public FormData NinjaData { get; set; }

        // METHODS
        private void GetViewerCarouselImageList(string path)
        {
            try
            {
                ImageList ilist = new ImageList();
                CarouselImageCollection icollect = ViewerCarousel.ImageListCollection;
                ViewerCarousel.ImageSlides = true;
                ViewerCarousel.UseOriginalImageinPreview = true;
                string[] images = Directory.GetFiles(path);
                FilePath = path;
                foreach (string i in images)
                {
                    string p = Path.GetFileNameWithoutExtension(i);
                    Bitmap b = new Bitmap(i);
                    b.Tag = p;
                    CarouselImage c = new CarouselImage();
                    c.ItemImage = b;
                    ilist.Images.Add(b);
                    icollect.Add(c);
                }

                ViewerCarousel.ImageList = ilist;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void Selector_Load(object sender, EventArgs e)
        {
        }

        private void ViewerCarousel_OnImageSelected(object sender, EventArgs e)
        {
            try
            {
                Carousel carousel = sender as Carousel;
                if (carousel != null)
                {
                    string i = carousel.ActiveImage.Tag.ToString();
                    Source s = (Source)Enum.Parse(typeof(Source), i);
                    SQLiteData sqlitedata = new SQLiteData(s, Provider.SQLite);
                    sqlitedata.Show();
                }

                Close();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
