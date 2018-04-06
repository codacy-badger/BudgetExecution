using Syncfusion.Windows.Forms.Tools;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroForm = Syncfusion.Windows.Forms.MetroForm;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public partial class SummarySelector : MetroForm
            {
                public SummarySelector()
                {
                    InitializeComponent();
                    GetViewerCarouselImageList();
                    ViewerCarousel.OnCarouselItemFocused += ViewerCarousel_OnImageSelected;
                }

                private void GetViewerCarouselImageList()
                {
                    ImageList ilist = new ImageList();
                    CarouselImageCollection icollect = ViewerCarousel.ImageListCollection;
                    ViewerCarousel.ImageSlides = true;
                    ViewerCarousel.UseOriginalImageinPreview = true;
                    string[] images = Directory.GetFiles(@"C:\Users\terry\Documents\Visual Studio 2015\Projects\Budget\Resources\Summary");
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
                    if (i.Contains("P7"))
                    {
                        var a = new SummaryForm();
                        a.ShowDialog();
                    }
                    if (i.Contains("P8"))
                    {
                        var f = new SummaryForm();
                        f.ShowDialog();
                    }
                    if (i.Contains("Functionality"))
                    {
                        var g = new FunctionalityForm();
                        g.ShowDialog();
                    }
                    if (i.Contains("Appropriation"))
                    {
                        var h = new AppropriationSelector();
                        h.ShowDialog();
                    }
                    return;
                }
            }
        }
    }
}