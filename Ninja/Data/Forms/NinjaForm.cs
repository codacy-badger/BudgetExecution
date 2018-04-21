using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Budget.Ninja.Data;
using Ninja.Data;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Ninja.Data.Forms
{
    public partial class NinjaForm : MetroForm
    {
        //Constructors
        public NinjaForm()
        {
            InitializeComponent();
            NinjaData = new FormData();
            GetViewerCarouselImageList();
            ViewerCarousel.OnCarouselItemFocused += ViewerCarousel_OnImageSelected;
        }

        //Properties
        public FormData NinjaData { get; set; }
        string[] Images { get; set; }
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

        private void SummarySelector_Load(object sender, EventArgs e)
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

