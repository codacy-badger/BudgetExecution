using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace BudgetExecution
{
    public partial class FunctionalityForm : MetroForm
    {
        public FunctionalityForm()
        {
            InitializeComponent();
            NinjaData = new FormData();
            GetFunctionCarouselImageList(Info.FunctionImages);
        }

        // PROPERTIES
        private string[] Images { get; set; }

        private FormData NinjaData { get; }

        // METHODS
        private void GetFunctionCarouselImageList(string path)
        {
            ImageList ilist = new ImageList();
            CarouselImageCollection icollect = FunctionCarousel.ImageListCollection;
            FunctionCarousel.ImageSlides = true;
            FunctionCarousel.UseOriginalImageinPreview = true;
            string[] images = Directory.GetFiles(path);
            foreach(string i in images)
            {
                string p = Path.GetFileNameWithoutExtension(i);
                Bitmap b = new Bitmap(i);
                b.Tag = p;
                CarouselImage c = new CarouselImage();
                c.ItemImage = b;
                ilist.Images.Add(b);
                icollect.Add(c);
            }

            FunctionCarousel.ImageList = ilist;
        }

        private void FunctionCarousel_OnImageSelected(object sender, EventArgs e)
        {
            string i = FunctionCarousel.ActiveImage.Tag.ToString();
            Source s = (Source) Enum.Parse(typeof(Source), i);
            SummaryForm a = new SummaryForm(s, Provider.SQLite);
            a.Show();
        }

        private void GetD6DataManager(object sender, EventArgs e)
        {
            SQLiteData datamanager = new SQLiteData();
            datamanager.Show();
            Close();
        }

        private void GetR6DataManager(object sender, EventArgs e)
        {
            SQLiteData datamanager = new SQLiteData();
            datamanager.Show();
            Close();
        }

        private void FunctionCarousel_Click(object sender, EventArgs e)
        {
        }
    }
}
