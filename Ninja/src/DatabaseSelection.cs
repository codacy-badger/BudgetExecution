// <copyright file="FunctionalityForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public partial class DatabaseSelection : Syncfusion.Windows.Forms.MetroForm
    {
        public DatabaseSelection()
        {
            InitializeComponent();
            NinjaData = new FormData();
            GetFunctionCarouselImageList(Info.FunctionImages);
        }

        // PROPERTIES
        private string[] Images { get; set; }

        private FormData NinjaData { get; set; }

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
            var datamanager = new SQLiteData();
            datamanager.Show();
            this.Close();
        }

        private void GetR6DataManager(object sender, System.EventArgs e)
        {
            var datamanager = new SQLiteData();
            datamanager.Show();
            this.Close();
        }

        private void FunctionCarousel_Click(object sender, EventArgs e)
        {
        }
    }
}