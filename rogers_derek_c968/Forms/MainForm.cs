using System;
using System.Windows.Forms;
using rogers_derek_c968.Forms;
using rogers_derek_c968.Models;

namespace rogers_derek_c968
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //If no data exists, this creates some for testing
            if (Inventory.AllParts.Count == 0 && Inventory.Products.Count == 0)
            {
                Inventory.AddPart(new InHouse { PartID = 1, Name = "Fuse Housing", InStock = 100, Price = 0.50m, Min = 10, Max = 200, MachineID = 123 });
                Inventory.AddPart(new Outsourced { PartID = 2, Name = "Transistor", InStock = 50, Price = 1.25m, Min = 5, Max = 100, CompanyName = "Globo Corp" });

                var prod = new Product
                {
                    ProductID = 1,
                    Name = "Humanoid Robot",
                    InStock = 25,
                    Price = 9.99m,
                    Min = 5,
                    Max = 50
                };
                prod.addAssociatedPart(Inventory.AllParts[0]);
                Inventory.AddProduct(prod);
            }

            //Load grid view with existing inventory contents
            gridView_Parts.DataSource = Inventory.AllParts;
            gridView_Prod.DataSource = Inventory.Products;
        }

        // ----------------------- Button Event Handlers
        private void btn_Exit_Click(object sender, EventArgs e) // exit button
        {
            Application.Exit();
        }
        // ----------------------- Search Function Handlers
        private void btn_PartSearch_Click(object sender, EventArgs e) //searches parts based on text field
        {
            if (int.TryParse(txtbx_PartSearch.Text, out int id))
            {
                var part = Inventory.LookupPart(id);
                if (part != null)
                {
                    gridView_Parts.ClearSelection();
                    int index = Inventory.AllParts.IndexOf(part);
                    gridView_Parts.Rows[index].Selected = true;
                    gridView_Parts.FirstDisplayedScrollingRowIndex = index;
                }
                else
                {
                    MessageBox.Show("No Parts Found.");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid Part ID.");
            }
        }
        private void btn_ProdSearch_Click(Object sender, EventArgs e) //searches products based on text field
        {
            if (int.TryParse(txtbx_ProdSearch.Text, out int id))
            {
                var product = Inventory.LookupProduct(id);
                if (product != null)
                {
                    gridView_Prod.ClearSelection();
                    int index = Inventory.Products.IndexOf(product);
                    gridView_Prod.Rows[index].Selected = true;
                    gridView_Prod.FirstDisplayedScrollingRowIndex = index;
                }
                else
                {
                    MessageBox.Show("No Products Found.");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid Product ID.");
            }
        }
        // ----------------------- Part/Product Editing Button Handlers
        private void btn_PartAdd_Click(Object sender, EventArgs e) //Adds Part
        {
            new AddPartForm().ShowDialog();
            gridView_Parts.Refresh();
        }
        private void btn_PartMod_Click(object sender, EventArgs e) //Modifies Part
        {
            if (gridView_Parts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                new ModifyPartForm(selectedPart).ShowDialog();                                  
                gridView_Parts.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a part to modify.");
            }
        }
        private void btn_PartDel_Click(Object sender, EventArgs e) //Dletes Part
        {
            if (gridView_Parts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                DialogResult confirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (!Inventory.DeletePart(selectedPart))
                        MessageBox.Show("Failed to delete part.");
                }
            }
        }
        private void btn_ProdAdd_Click(object sender, EventArgs e) //Adds Product
        {
            new AddProductForm().ShowDialog();
            gridView_Prod.Refresh();
        }
        private void btn_ProdMod_Click(object sender, EventArgs e) //Mods Product
        {
            if (gridView_Prod.CurrentRow?.DataBoundItem is Product selectedProduct)
            {
                new ModifyProductForm(selectedProduct).ShowDialog();
                gridView_Prod.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a product to modify.");
            }
        }
        private void btn_ProdDel_Click(object sender, EventArgs e)//Deletes Product
        {
            if (gridView_Prod.CurrentRow?.DataBoundItem is Product selectedProduct)
            {
                if (selectedProduct.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete a product with associated parts.");
                    return;
                }

                DialogResult confirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (!Inventory.RemoveProduct(selectedProduct.ProductID))
                        MessageBox.Show("Failed to delete product.");
                }
            }
        }


    }
}
