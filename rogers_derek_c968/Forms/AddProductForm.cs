using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rogers_derek_c968.Models;

namespace rogers_derek_c968.Forms
{
    public partial class AddProductForm : Form
    {
        // creates private working list for editing products without touching inventory
        private BindingList<Part> _associatedParts = new BindingList<Part>();
        public AddProductForm()
        {
            InitializeComponent();
            //Loads data into grids
            grid_AllParts.DataSource = Inventory.AllParts;
            grid_AssociatedParts.DataSource = _associatedParts;
        }
        //Searches for Part based ID and loads data into grid
        private void btn_PartSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_PartSearch.Text, out int id))
            {
                var result = Inventory.LookupPart(id);
                if (result != null)
                {
                    grid_AllParts.ClearSelection(); //TODO double check requirements, I might need to keep each item and append to grid
                    int index = Inventory.AllParts.IndexOf(result);
                    grid_AllParts.Rows[index].Selected = true;
                    grid_AllParts.FirstDisplayedScrollingRowIndex = index;
                }
                else
                {
                    MessageBox.Show("Part not found.");
                    txt_PartSearch.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Part ID.");
                txt_PartSearch.Clear();
            }
        }
        //adds selected candidate part over to grid for associated parts
        private void btn_AddPart_Click(object sender, EventArgs e)
        {
            //verifies part exists and isn't already associated to product
            if (grid_AllParts.CurrentRow?.DataBoundItem is Part selectedPart && !_associatedParts.Contains(selectedPart))
            {
                _associatedParts.Add(selectedPart);
            }
        }

        //removes the selected associated part
        private void btn_RemovePart_Click(object sender, EventArgs e)
        {
            if (grid_AssociatedParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    _associatedParts.Remove(selectedPart);
                }
            }
        }

        //Adds 1 to highest ID to get a new unique Product ID
        private int GenerateUniqueProductID()
        {
            return Inventory.Products.Any() ? Inventory.Products.Max(p => p.ProductID) + 1 : 1;
        }

        //Cancel button event handler, exits form
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Event handler for Save button, commits all associated parts changes to the product
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_Name.Text) ||
                    string.IsNullOrWhiteSpace(txt_Inventory.Text) ||
                    string.IsNullOrWhiteSpace(txt_Price.Text) ||
                    string.IsNullOrWhiteSpace(txt_Min.Text) ||
                    string.IsNullOrWhiteSpace(txt_Max.Text))
                {
                    MessageBox.Show("All fields must be filled.");
                    return;
                }

                string name = txt_Name.Text;
                int inventory = int.Parse(txt_Inventory.Text);
                decimal price = decimal.Parse(txt_Price.Text);
                int min = int.Parse(txt_Min.Text);
                int max = int.Parse(txt_Max.Text);

                if (min > max)
                {
                    MessageBox.Show("Min must be less than or equal to Max.");
                    return;
                }

                if (inventory < min || inventory > max)
                {
                    MessageBox.Show("Inventory must be between Min and Max.");
                    return;
                }

                // creates new ID
                int id = GenerateUniqueProductID();

                //Creates new product object with all validated inputs
                Product newProduct = new Product
                {
                    ProductID = id,
                    Name = name,
                    InStock = inventory,
                    Price = price,
                    Min = min,
                    Max = max
                };
                //Adds associated parts by iterating through working list
                foreach (Part part in _associatedParts)
                {
                    newProduct.addAssociatedPart(part);
                }

                Inventory.AddProduct(newProduct);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values for numeric fields.");
            }
        }


    }
}
