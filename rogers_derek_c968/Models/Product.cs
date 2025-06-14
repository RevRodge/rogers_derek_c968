using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rogers_derek_c968.Models
{
    public class Product
    { 
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        // For editing all parts underneath/within a product
        public void AddAssociatedPart(Part part) => AssociatedParts.Add(part);
        public bool RemoveAssociatedPart(int partID)
        {
            //returns matching part or null
            var part = AssociatedParts.FirstOrDefault(p => p.PartID == partID);
            //deletes partID found
            return part != null && AssociatedParts.Remove(part);
        }

        // used linq here too but serves as a "foreach" search of partIDs
        public Part LookupAssociatedPart(int partID) => AssociatedParts.FirstOrDefault(p => p.PartID == partID);
    }
}
