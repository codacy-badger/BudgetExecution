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
    public partial class FunctionalityForm : Syncfusion.Windows.Forms.MetroForm
    {
        public FunctionalityForm()
        {
            InitializeComponent();
            NinjaData = new FormData();
            GetFunctionCarouselImageList(Info.FunctionImages);
        }

        // PROPERTIES
        string[] Images { get; set; }
        FormData NinjaData { get; set; }

        // METHODS
        private void GetFunctionCarouselImageList(string path)
        {
            ImageList ilist = new ImageList();
            CarouselImageCollection icollect = FunctionCarousel.ImageListCollection;
            FunctionCarousel.ImageSlides = true;
            FunctionCarousel.UseOriginalImageinPreview = true;
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
            FunctionCarousel.ImageList = ilist;

        }
        private void FunctionCarousel_OnImageSelected(object sender, EventArgs e)
        {

            var i = FunctionCarousel.ActiveImage.Tag.ToString();
            var a = new SummaryForm(i);
            a.Show();
        }
        private void GetD6DataManager(object sender, System.EventArgs e)
        {
            var datamanager = new DataManager(Source.DivisionAccount, Provider.SQLite);
            datamanager.Show();
            this.Close();
        }

        private void GetR6DataManager(object sender, System.EventArgs e)
        {
            var datamanager = new DataManager(Source.RegionAccount, Provider.SQLite);
            datamanager.Show();
            this.Close();
        }

        private void FunctionCarousel_Click(object sender, EventArgs e)
        {

        }
    }
}