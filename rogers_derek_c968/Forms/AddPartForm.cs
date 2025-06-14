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
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();

            //In-House/Outsourced Radio button
            radio_InHouse.CheckedChanged += RadioChanged;
            radio_Outsourced.CheckedChanged += RadioChanged;
            //Sets default to In-House
            radio_InHouse.Checked = true;

        }

        //Listens for radio state change
        private void RadioChanged(object sender, EventArgs e)
        {
            if (radio_InHouse.Checked)
            {
                lbl_Special.Text = "Machine ID";
            }
            else if (radio_Outsourced.Checked)
            {
                lbl_Special.Text = "Company Name";
            }
            //Clears form on change
            txt_Special.Text = string.Empty;
        }
        // Searches all parts and creates the next number for a unique Part ID
        private int GenerateUniquePartID()
        {
            int highestID = Inventory.AllParts.Any() ? Inventory.AllParts.Max(p => p.PartID) : 0;
            return highestID + 1;
        }
        // --------------------------------------- Button Event Handling
        // Cancel button closes dialog box
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Save button validates input and adds part to inventory with auto gen'd ID
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //uses a try/catch to validate numeric input
            try
            {
                // Verifies that all fields were filled out
                if (string.IsNullOrWhiteSpace(txt_Name.Text) ||
                    string.IsNullOrWhiteSpace(txt_Inventory.Text) ||
                    string.IsNullOrWhiteSpace(txt_Price.Text) ||
                    string.IsNullOrWhiteSpace(txt_Max.Text) ||
                    string.IsNullOrWhiteSpace(txt_Min.Text) ||
                    string.IsNullOrWhiteSpace(txt_Special.Text))
                {
                    MessageBox.Show("All fields must be filled out.");
                    return;
                }
                string name = txt_Name.Text;
                int inventory = int.Parse(txt_Inventory.Text);
                decimal price = decimal.Parse(txt_Price.Text);
                int max = int.Parse(txt_Max.Text);
                int min = int.Parse(txt_Min.Text);

                //checks if user failed math class
                if (min > max)
                {
                    MessageBox.Show("Min must be less than or equal to Max.");
                    return;
                }

                if (inventory < min || inventory > max)
                {
                    MessageBox.Show("Must be between Min and Max.");
                    return;
                }

                int id = GenerateUniquePartID();

                //checks radio button state to determine where to save part
                if (radio_InHouse.Checked)
                {                    
                    int machineID = int.Parse(txt_Special.Text);
                    InHouse part = new InHouse
                    {
                        PartID = id,
                        Name = name,
                        InStock = inventory,
                        Price = price,
                        Max = max,
                        Min = min,
                        MachineID = machineID
                    };
                    Inventory.AddPart(part);
                }
                else
                {
                    string companyName = txt_Special.Text;
                    Outsourced part = new Outsourced
                    {
                        PartID = id,
                        Name = name,
                        InStock = inventory,
                        Price = price,
                        Max = max,
                        Min = min,
                        CompanyName = companyName
                    };
                    Inventory.AddPart(part);
                }
                // Closes dialog window upon successful part addition
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("All numeric fields must be valid numbers.");
            }
        }
    }
}
