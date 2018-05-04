using Ninja.Data.Forms;

namespace BudgetExecution
{
    public partial class FunctionalityForm : Syncfusion.Windows.Forms.MetroForm
            {
                public FunctionalityForm()
                {
                    InitializeComponent();
                }

                private void GetD6DataManager(object sender, System.EventArgs e)
                {
                    var datamanager = new DataManager(Source.DivisionAccount);
                    datamanager.Show();
                    this.Close();
                }

                private void GetR6DataManager(object sender, System.EventArgs e)
                {
                    var datamanager = new DataManager(Source.RegionAccount);
                    datamanager.Show();
                    this.Close();
                }
            }
        }