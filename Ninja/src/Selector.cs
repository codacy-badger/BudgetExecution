// <copyright file="Selector.cs" company="PlaceholderCompany">
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

        private string FilePath { get; set; }

        public FormData NinjaData { get; set; }

        private string[] Images { get; set; }

        // METHODS
        public void GetViewerCarouselImageList(string path)
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

        private void Selector_Load(object sender, EventArgs e)
        {
        }

        public void ViewerCarousel_OnImageSelected(object sender, EventArgs e)
        {
            Carousel carousel = sender as Carousel;
            if (carousel?.ActiveImage.Tag != null)
            {
                string i = carousel.ActiveImage.Tag.ToString();
                switch (i)
                {
                    case "SummaryImages":
                        Selector f = new Selector(Info.SummaryImages);
                        f.Show();
                        Close();
                        return;

                    case "DatabaseImages":
                        var ds = new Selector(Info.DatabaseImages);
                        ds.Show();
                        Close();
                        return;
                    case "Division":
                        Selector d = new Selector(Info.DivisionImages);
                        d.Show();
                        Close();
                        return;
                    case "FunctionImages":
                        var fi = new Selector(Info.FunctionImages);
                        fi.Show();
                        Close();
                        return;
                    case "Appropriation":
                        Selector aps = new Selector(Info.AppropriationImages);
                        aps.Show();
                        Close();
                        return;

                    case "ObjectClass":
                        Selector obs = new Selector(Info.ObjectClass);
                        obs.Show();
                        Close();
                        return;
                }

                Source source = (Source)Enum.Parse(typeof(Source), i);
                SummaryForm sf = new SummaryForm(source, Provider.SQLite);
                sf.Show();
                Close();
            }
        }

        private void ImageItem_OnHover(object sender, EventArgs e)
        {
        }
    }
}
