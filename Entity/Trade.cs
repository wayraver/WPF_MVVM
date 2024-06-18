using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace WPF_MVVM.Entity
{
    public class Trade
    {
        public decimal Volume
        {
            get => _volume;
            set
            {
                Volume = value;
                if (Volume > 0)
                {
                    Side = Side.Long;
                }
                else if (Volume < 0)
                {
                    Side = Side.Short;
                }

            }
        }
        decimal _volume; 

        public decimal Price;
        public Side Side = Side.None;
        public DateTime DateTime = DateTime.MinValue;
        public string SecName;

    }
}
