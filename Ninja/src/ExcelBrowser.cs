// <copyright file="ErrorMessage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;

    using Syncfusion.Windows.Forms;

    public partial class ExcelBrowser : MetroForm
    {
        public ExcelBrowser()
        {
            InitializeComponent();
        }

        public ExcelBrowser(string message)
        {
            InitializeComponent();
            MessageText = message;
            Info.Text = "\n  " + MessageText;
        }

        // PROPERTIES
        public string MessageText { get; set; }

        // METHODS
        private void OkButton_OnClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}