using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Maui.Controls;


namespace PieChartMAUI
{
    public class CategoricalData : NotifyPropertyChangedBase
    {
        private string name;
        private int value;

        public CategoricalData(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public string Name
        {
            get { return this.name; }
            set { this.UpdateValue(ref this.name, value); }
        }

        public int Value
        {
            get { return this.value; }
            set { this.UpdateValue(ref this.value, value); }
        }

    }
}
