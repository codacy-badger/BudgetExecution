#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion


namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    public partial class Message : Syncfusion.Windows.Forms.MetroForm
    {
        public Message()
        {
            InitializeComponent();
        }
        
        public Message(Exception ex)
        {
            InitializeComponent();
            Error = ex.Message;
            Stack = ex.StackTrace;
            Target = ex.TargetSite.ReflectedType.Name;
            this.Info.Text = "\n\n\n    " + Error;
        }

        // PROPERTIES
        public string Error { get; set; }
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
