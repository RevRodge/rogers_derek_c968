using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rogers_derek_c968.Models
{
    public abstract class Part
    {
        private int partID;
        private string name;
        private int inventory;
        private decimal price;
        private int max;
        private int min;

        public int PartID {  get; set; }
        public string PartName { get; set; }
        public int Inventory {  get; set; }
        public string Price
        {
            get { return price.ToString("C"); }
            set { } // TODO Parse to values
        }
        public int Max { get; set; }
        public int Min { get; set; }
    }
}
