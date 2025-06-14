using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace rogers_derek_c968.Models
{
    public class OutSourced : Part
    {
        private string compName;
        public string CompName { get; set; }
        public OutSourced() { }
        public OutSourced(int partID, string name, int inventory, decimal price, int max, int min)
        {
            PartID = partID;
            PartName = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
        }
        public OutSourced(int partID, string name, int inventory, decimal price, int max, int min, string compName)
        {
            PartID = partID;
            PartName = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
            CompName = compName;
        }
    }
}
