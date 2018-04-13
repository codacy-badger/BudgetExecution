using Budget.Ninja.Data;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja.Data.Forms
{
    public partial class DataMaster : Syncfusion.Windows.Forms.MetroForm
    {
        public DataMaster()
        {
            InitializeComponent();
        }

        private void gridRecordNavigationControl1_Click(object sender, EventArgs e)
        {

        }

        private void DataMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'R6.P6' table. You can move, or remove it, as needed.
            this.P6Adapter.Fill(this.E6.P6);

        }
    }
}
