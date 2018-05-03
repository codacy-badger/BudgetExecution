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

namespace Budget.Ninja.Data
{
    public partial class Selector : MetroForm
    {
        //Constructors
        public Selector()
        {
            InitializeComponent();
            NinjaData = new FormData();
            GetViewerCarouselImageList();
            ViewerCarousel.OnCarouselItemFocused += ViewerCarousel_OnImageSelected;
        }

        //Properties
        public FormData NinjaData { get; set; }
        string[] Images { get; set; }

        //Methods
        private void GetViewerCarouselImageList()
        {
            ImageList ilist = new ImageList();
            CarouselImageCollection icollect = ViewerCarousel.ImageListCollection;
            ViewerCarousel.ImageSlides = true;
            ViewerCarousel.UseOriginalImageinPreview = true;
            string[] images = Directory.GetFiles(@"C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\Resources\NinjaDivisionImages");
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
            var a = new SummaryForm(i);
            a.Show();
        }
    }
}

