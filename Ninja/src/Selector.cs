using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ninja.Data;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.IO;
using System.Drawing;
using Ninja.Data.Forms;


namespace BudgetExecution
{
    public partial class Selector : MetroForm
    {
        string DivisionImages { get; set; }
        string SummaryImages { get; set; }
        //Constructors
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

        //Properties
        public FormData NinjaData { get; set; }
        string[] Images { get; set; }

        //Methods
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
            if (ViewerCarousel.ActiveImage.Tag.ToString().Length > 3)
            {
                var s = (Source)Enum.Parse(typeof(Source), ViewerCarousel.ActiveImage.Tag.ToString());
                var a = new SummaryForm(s);
                a.Show();
            }
            var i = ViewerCarousel.ActiveImage.Tag.ToString();
            var b = new SummaryForm(i);
            b.Show();
        }
    }
}

