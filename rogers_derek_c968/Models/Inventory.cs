using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel; //for using DataGridView

namespace rogers_derek_c968.Models
{
    public static class Inventory
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>(); //Holds inhouse and outsourced parts

        //adds products
        public static void AddProduct(Product product) => Products.Add(product);

        //removes products
        public static bool RemoveProduct(int productID)
        {
            var product = LookupProduct(productID);
            return product != null && Products.Remove(product);
        }

        public static Product LookupProduct(int productID) => Products.FirstOrDefault(p => p.ProductID == productID);

        //Uses linq search to find index of product and assigns it a new index to updated attribute
        public static void UpdateProduct(int productID, Product updated)
        {
            var index = Products.ToList().FindIndex(p => p.ProductID == productID);
            if (index >= 0)
                Products[index] = updated;
        }
        //adds part
        public static void AddPart(Part part) => AllParts.Add(part);

        //removes part
        public static bool DeletePart(Part part) => AllParts.Remove(part);

        //linq search for part based on partID
        public static Part LookupPart(int partID) => AllParts.FirstOrDefault(p => p.PartID == partID);

        //same as above... but for parts
        public static void UpdatePart(int partID, Part updated)
        {
            var index = AllParts.ToList().FindIndex(p => p.PartID == partID);
            if (index >= 0)
                AllParts[index] = updated;
        }
    }
}
