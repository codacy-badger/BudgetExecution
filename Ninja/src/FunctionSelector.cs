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

    public partial class FunctionSelector : MetroForm
    {
        // CONSTRUCTORS
        public FunctionSelector()
        {
            InitializeComponent();
            FunctionImages = Info.FunctionImages;
            NinjaData = new FormData();
            GetViewerCarouselImageList(FunctionImages);
            ViewerCarousel.OnCarouselItemFocused += ViewerCarousel_OnImageSelected;
        }

        public FunctionSelector(string path)
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
            var s = (Function)Enum.Parse(typeof(Function), i);
            switch(s)
            {
                case Function.SQLiteData:
                    var sd = new DatabaseSelector(Info.DatabaseImages);
                    sd.Show();
                    this.Close();
                    break;
                case Function.BudgetTools:
                    var bt = new BudgetTools();
                    bt.Show();
                    break;
                case Function.DataTools:
                    var dt = new BudgetTools();
                    dt.Show();
                    break;
                case Function.ExcelImporter:
                    var ei = new ExcelImporter();
                    ei.Show();
                    break;
                case Function.PdfDataReader:
                    var pdfdr = new PdfDataReader();
                    pdfdr.Show();
                    break;
            }
            this.Close();
        }
    }
}
