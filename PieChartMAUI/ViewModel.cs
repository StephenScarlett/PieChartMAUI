using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Maui.Controls;

namespace PieChartMAUI
{
    public class ViewModel
    {
        private ObservableCollection<CategoricalData> _data;

        public ObservableCollection<CategoricalData> Data => _data ??= ViewModel.CreateData();

        private static ObservableCollection<CategoricalData> CreateData()
        {
            return new ObservableCollection<CategoricalData>
            {
                new CategoricalData("Test1", 20),
                new CategoricalData("Test2", 10),
                new CategoricalData("Test3", 30),
                new CategoricalData("Test4", 10)
            };
        }
    }
}
