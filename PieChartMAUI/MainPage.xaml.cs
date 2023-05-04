using System.Diagnostics;
using System.Xml.Linq;
using Telerik.Maui.Controls.Compatibility.DataGrid;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using Telerik.Maui.Controls.Compatibility.Common.Data;

namespace PieChartMAUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        ViewModel Viewmodel;

        public MainPage()
        {
            InitializeComponent();

            this.Viewmodel = new ViewModel();
            this.BindingContext = Viewmodel;
        }

        private void AddFunc(object sender, EventArgs e)
        {
            this.Viewmodel.Data.Add(new CategoricalData(this.entryName.Text, Int32.Parse(this.entryValue.Text)));
        }

        private void UpdateFunc(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Viewmodel.Data.Count; i++)
            {
                if (this.Viewmodel.Data[i].Name.Equals(this.entryName.Text))
                {
                    this.Viewmodel.Data[i].Value = Int32.Parse(this.entryValue.Text);
                    Trace.WriteLine("Match:" + i);

                }
                else
                {
                    Trace.WriteLine("No Match:" + i);
                }

            }
        }


        private void DltFunc(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Viewmodel.Data.Count; i++)
            {
                if (this.Viewmodel.Data[i].Name.Equals(this.entryName.Text))
                {
                    this.Viewmodel.Data.RemoveAt(i);
                }
            }

        }

        private void GetFunc(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Viewmodel.Data.Count; i++)
            {
                if (this.Viewmodel.Data[i].Name.Equals(this.entryName.Text))
                {
                    Trace.WriteLine("Name: " + this.Viewmodel.Data[i].Name + " Value: " + this.Viewmodel.Data[i].Value);
                }
            }
        }
    }
}