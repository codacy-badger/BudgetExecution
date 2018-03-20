#region Using Directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#endregion

namespace Ninja
{
    public partial class NavigationForm : Syncfusion.Windows.Forms.MetroForm
    {
        public NavigationForm( )
        {
            InitializeComponent( );
        }
        void SetConfiguration( )
        {
            Size = new Size(1800, 1000);
            MaximumSize = new Size(1800, 1000);
            BackColor = Color.Black;
            BorderColor = SystemColors.MenuHighlight;
            ForeColor = SystemColors.MenuHighlight;
            MetroColor = Color.Black;
            ShowIcon = false;
            ShowInTaskbar = true;
            CaptionBarColor = Color.Black;
            CaptionForeColor = SystemColors.MenuHighlight;
            BorderThickness = 1;
            CaptionAlign = HorizontalAlignment.Left; 
        }
    }
}
