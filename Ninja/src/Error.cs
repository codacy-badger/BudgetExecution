// <copyright file="ErrorMessage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

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
            this.Info.Text = "\n\n\n    " + Message;
        }

        // PROPERTIES
        public string Message { get; set; }
        string Stack { get; }
        string Target { get; }

        // METHODS
        void OkButton_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        void StackButton_OnClick(object sender, EventArgs e)
        {
            Info.Text = "Call Stack: \n\n" + Stack;
        }

        void TargetButton_OnClick(object sender, EventArgs e)
        {
            Info.Text = "Target Site: \n\n" + Target;
        }
    }
}
