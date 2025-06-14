using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
