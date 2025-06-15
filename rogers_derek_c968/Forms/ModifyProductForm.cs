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
    public partial class ModifyProductForm : Form
    {
        private Product _originalProduct;
        private BindingList<Part> _associatedParts = new BindingList<Part>();

        public ModifyProductForm(Product product)
        {
            InitializeComponent();
            _originalProduct = product;
            grid_AllParts.DataSource = Inventory.AllParts;
            _associatedParts = new BindingList<Part>(product.AssociatedParts.ToList());
            grid_AssociatedParts.DataSource = _associatedParts;
            LoadProductData();
        }
        private void LoadProductData()
        {
            txt_ID.Text = _originalProduct.ProductID.ToString();
            txt_Name.Text = _originalProduct.Name;
            txt_Inventory.Text = _originalProduct.InStock.ToString();
            txt_Price.Text = _originalProduct.Price.ToString();
            txt_Min.Text = _originalProduct.Min.ToString();
            txt_Max.Text = _originalProduct.Max.ToString();
        }

        //Similar to the add product save method but just commits changes to same productID instead of aa unique one
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

                Product updatedProduct = new Product
                {
                    ProductID = _originalProduct.ProductID,
                    Name = name,
                    InStock = inventory,
                    Price = price,
                    Min = min,
                    Max = max
                };

                foreach (Part part in _associatedParts)
                {
                    updatedProduct.addAssociatedPart(part);
                }

                Inventory.UpdateProduct(_originalProduct.ProductID, updatedProduct);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values for numeric fields.");
            }
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

        //Cancel button event handler, exits form
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
