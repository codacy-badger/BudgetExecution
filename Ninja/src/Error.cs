// <copyright file="ErrorMessage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using Syncfusion.Windows.Forms;

namespace BudgetExecution
{
    public partial class Error : MetroForm
    {
        public Error()
        {
            InitializeComponent();
        }

        public Error(Exception ex)
        {
            InitializeComponent();
            Message = ex.Message;
            Stack = ex.StackTrace;
            Target = ex.TargetSite.ReflectedType.Name;
            Info.Text = "\n\n\n    " + Message;
        }

        // PROPERTIES
        public string Message { get; set; }

        private string Stack { get; }

        private string Target { get; }

        // METHODS
        private void OkButton_OnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void StackButton_OnClick(object sender, EventArgs e)
        {
            Info.Text = "Call Stack: \n\n" + Stack;
        }

        private void TargetButton_OnClick(object sender, EventArgs e)
        {
            Info.Text = "Target Site: \n\n" + Target;
        }
    }
}
