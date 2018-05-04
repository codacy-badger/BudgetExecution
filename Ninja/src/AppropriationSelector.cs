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
            public partial class AppropriationSelector : MetroForm
            {
                public AppropriationSelector()
                {
                    InitializeComponent();
                    GetAppropriationCarouselImageList();
                    AppropriationCarousel.OnCarouselItemFocused += AppropriationCarousel_OnImageSelected;
                }

                private void AppropriationCarousel_OnImageSelected(object sender, EventArgs e)
                {
                    //var i = AppropriationCarousel.ActiveImage.Tag.ToString( );
                    //if (i.Contains("EPASummary"))
                    //{
                    //    var a = new RegionSummary( );
                    //    a.ShowDialog( );
                    //}
                    //if (i.Contains("DivisionSummary"))
                    //{
                    //    var f = new DivisionForm( );
                    //    f.ShowDialog( );
                    //}
                    //if (i.Contains("Functionality"))
                    //{
                    //    var g = new BudgetExecutionForm( );
                    //    g.ShowDialog( );
                    //}
                    return;
                }

                private void GetAppropriationCarouselImageList()
                {
                    ImageList ilist = new ImageList();
                    CarouselImageCollection icollect = AppropriationCarousel.ImageListCollection;
                    AppropriationCarousel.ImageSlides = true;
                    AppropriationCarousel.UseOriginalImageinPreview = true;
                    string[] images = Directory.GetFiles(@"C:\Users\terry\Documents\Visual Studio 2015\Projects\Budget\Resources\fundlabel");
                    foreach (string i in images)
                    {
                        var b = new Bitmap(i);
                        b.Tag = i;
                        var c = new CarouselImage();
                        c.ItemImage = b;
                        ilist.Images.Add(b);
                        icollect.Add(c);
                    }
                    AppropriationCarousel.ImageList = ilist;
                }
            }
        }
    }
}