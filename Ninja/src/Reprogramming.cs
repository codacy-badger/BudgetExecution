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

    public partial class Ta3 : Syncfusion.Windows.Forms.MetroForm
    {
        public Ta3()
        {
            InitializeComponent();
        }


        private void CalculatorButton_OnClick(object sender, EventArgs e)
        {
            var c = new CalculatorForm();
            c.Show();
        }
        
    }
}
