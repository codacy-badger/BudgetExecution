// <copyright file="AppropriationSelector.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using MetroForm = Syncfusion.Windows.Forms.MetroForm;

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
            string i = AppropriationCarousel.ActiveImage.Tag.ToString( );
            if (i.Contains("Functionality"))
            {
                Selector g = new Selector(Info.AppropriationImages);
                g.Show();
                this.Close();
            }
            return;
        }

        private void GetAppropriationCarouselImageList()
        {
            ImageList ilist = new ImageList();
            CarouselImageCollection icollect = AppropriationCarousel.ImageListCollection;
            AppropriationCarousel.ImageSlides = true;
            AppropriationCarousel.UseOriginalImageinPreview = true;
            string[] images = Directory.GetFiles(@"C:\Users\terry\Documents\Visual Studio 2017\Projects\BudgetExecution\Ninja\Resources\AppropriationImages");
            foreach (string i in images)
            {
                Bitmap b = new Bitmap(i);
                b.Tag = i;
                CarouselImage c = new CarouselImage();
                c.ItemImage = b;
                ilist.Images.Add(b);
                icollect.Add(c);
            }

            AppropriationCarousel.ImageList = ilist;
        }
    }
}
