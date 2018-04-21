using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using MetroForm = Syncfusion.Windows.Forms.MetroForm;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
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
                private void GetViewerCarouselImageList()
                {
                    ImageList ilist = new ImageList();
                    CarouselImageCollection icollect = ViewerCarousel.ImageListCollection;
                    ViewerCarousel.ImageSlides = true;
                    ViewerCarousel.UseOriginalImageinPreview = true;
                    string[] images = Directory.GetFiles(@"C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\Resources\NinjaDivisionIcons");
                    foreach (string i in images)
                    {
                        var b = new Bitmap(i);
                        b.Tag = i;
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
    }
}