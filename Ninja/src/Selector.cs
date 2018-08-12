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

        private void ViewerCarousel_OnImageSelected(object sender, EventArgs e)
        {
            Carousel carousel = sender as Carousel;
            string i = carousel.ActiveImage.Tag.ToString();
            if (i == "Appropriation")
            {
                Selector f = new Selector(Info.AppropriationImages);
                f.Show();
                this.Close();
            }
            else
            {
                Source s = (Source)Enum.Parse(typeof(Source), i);
                SummaryForm summary = new SummaryForm(s);
                summary.Show();
                Close();
            }
        }
    }
}
