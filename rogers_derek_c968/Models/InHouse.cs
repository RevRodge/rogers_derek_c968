using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace rogers_derek_c968.Models
{
    public class InHouse : Part
    {
        private int machID;
        public int MachineID { get; set; }
        public InHouse() { }
        public InHouse(int partID, string name, int inventory, decimal price, int max, int min)
        {
            PartID = partID;
            PartName = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
        }

        public InHouse(int partID, string name, int inventory, decimal price, int max, int min, int machID)
        {
            PartID = partID;
            PartName = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
            MachineID = machID;
        }
    }
}
