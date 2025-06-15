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
    public partial class ModifyPartForm : Form
    {
        private Part _originalPart;
        public ModifyPartForm(Part partToModify)
        {
            InitializeComponent();
            _originalPart = partToModify;

            // InHouse/OutSourced radio button 
            radio_InHouse.CheckedChanged += RadioChanged;
            radio_Outsourced.CheckedChanged += RadioChanged;

            LoadPartData();
        }
        //Loads original part data for editing
        private void LoadPartData()
        {
            txt_ID.Text = _originalPart.PartID.ToString();
            txt_Name.Text = _originalPart.Name;
            txt_Inventory.Text = _originalPart.InStock.ToString();
            txt_Price.Text = _originalPart.Price.ToString();
            txt_Max.Text = _originalPart.Max.ToString();
            txt_Min.Text = _originalPart.Min.ToString();

            if (_originalPart is InHouse inHouse)
            {
                radio_InHouse.Checked = true;
                lbl_Special.Text = "Machine ID";
                txt_Special.Text = inHouse.MachineID.ToString();
            }
            else if (_originalPart is Outsourced outsourced)
            {
                radio_Outsourced.Checked = true;
                lbl_Special.Text = "Company Name";
                txt_Special.Text = outsourced.CompanyName;
            }
        }
        //Listens for radio state change, might not be fully necessary since the LoadPart mthod does this
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
            
        }
        //Modified Version of the Save method from my AddPartForm
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
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

                // Create new part (with same ID)
                Part updatedPart;

                if (radio_InHouse.Checked)
                {
                    if (!int.TryParse(txt_Special.Text, out int machineID))
                    {
                        MessageBox.Show("Machine ID must be a valid number.");
                        return;
                    }

                    updatedPart = new InHouse
                    {
                        PartID = _originalPart.PartID, // <---Pulls old Part ID
                        Name = name,
                        InStock = inventory,
                        Price = price,
                        Max = max,
                        Min = min,
                        MachineID = machineID
                    };
                }
                else
                {
                    string companyName = txt_Special.Text;

                    updatedPart = new Outsourced
                    {
                        PartID = _originalPart.PartID, // <---Pulls old Part ID
                        Name = name,
                        InStock = inventory,
                        Price = price,
                        Max = max,
                        Min = min,
                        CompanyName = companyName
                    };
                }

                // Replace the part in Inventory with new attributes, then closes the form
                Inventory.UpdatePart(_originalPart.PartID, updatedPart);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("All numeric fields must be valid numbers.");
            }
        }
    }
}
