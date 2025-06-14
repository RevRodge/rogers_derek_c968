using System;
using System.Windows.Forms;
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
            if (Inventory.AllParts.Count == 0 && Inventory.Products.Count == 0)
            {
                //TODO: make some test data to add if nothing exists
            }
            //Load grid view with inventory contents
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

        }
        private void btn_ProdSearch_Click(Object sender, EventArgs e) //searches products based on text field
        {
            
        }

        // ----------------------- Part/Product Editing Button Handlers
        private void btn_PartAdd_Click(Object sender, EventArgs e) //Adds Part
        {

        }
        private void btn_PartMod_Click(object sender, EventArgs e) //Modifies Part
        {

        }
        private void btn_PartDel_Click(Object sender, EventArgs e) //Dletes Part
        {

        }
        private void btn_ProdAdd_Click(object sender, EventArgs e) //Adds Product
        {

        }
        private void btn_ProdMod_Click(object sender, EventArgs e) //Mods Product
        {

        }
        private void btn_ProdDel_Click(object sender, EventArgs e)//Deletes Product
        {

        }


        }
}
