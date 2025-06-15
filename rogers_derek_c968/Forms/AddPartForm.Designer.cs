namespace rogers_derek_c968.Forms
{
    partial class AddPartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox = new GroupBox();
            btn_Cancel = new Button();
            btn_Save = new Button();
            radio_Outsourced = new RadioButton();
            radio_InHouse = new RadioButton();
            txt_Min = new TextBox();
            txt_Name = new TextBox();
            txt_Inventory = new TextBox();
            txt_Special = new TextBox();
            txt_Price = new TextBox();
            txt_Max = new TextBox();
            txt_ID = new TextBox();
            lbl_Special = new Label();
            lbl_Min = new Label();
            lbl_Max = new Label();
            lbl_Inventory = new Label();
            lbl_Price = new Label();
            lbl_Name = new Label();
            lbl_ID = new Label();
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.radio_InHouse.CheckedChanged += new System.EventHandler(this.RadioChanged);
            this.radio_Outsourced.CheckedChanged += new System.EventHandler(this.RadioChanged);
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = SystemColors.ControlLight;
            groupBox.Controls.Add(btn_Cancel);
            groupBox.Controls.Add(btn_Save);
            groupBox.Controls.Add(radio_Outsourced);
            groupBox.Controls.Add(radio_InHouse);
            groupBox.Controls.Add(txt_Min);
            groupBox.Controls.Add(txt_Name);
            groupBox.Controls.Add(txt_Inventory);
            groupBox.Controls.Add(txt_Special);
            groupBox.Controls.Add(txt_Price);
            groupBox.Controls.Add(txt_Max);
            groupBox.Controls.Add(txt_ID);
            groupBox.Controls.Add(lbl_Special);
            groupBox.Controls.Add(lbl_Min);
            groupBox.Controls.Add(lbl_Max);
            groupBox.Controls.Add(lbl_Inventory);
            groupBox.Controls.Add(lbl_Price);
            groupBox.Controls.Add(lbl_Name);
            groupBox.Controls.Add(lbl_ID);
            groupBox.Font = new Font("Segoe UI", 11F);
            groupBox.Location = new Point(8, 6);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(397, 421);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Add Part";
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = SystemColors.ButtonFace;
            btn_Cancel.Location = new Point(221, 361);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 31);
            btn_Cancel.TabIndex = 17;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = SystemColors.ButtonFace;
            btn_Save.Location = new Point(113, 361);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 31);
            btn_Save.TabIndex = 16;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            //btn_Save.Click += btn_Save_Click;
            // 
            // radio_Outsourced
            // 
            radio_Outsourced.AutoSize = true;
            radio_Outsourced.Font = new Font("Segoe UI", 9F);
            radio_Outsourced.Location = new Point(242, 16);
            radio_Outsourced.Name = "radio_Outsourced";
            radio_Outsourced.Size = new Size(87, 19);
            radio_Outsourced.TabIndex = 15;
            radio_Outsourced.TabStop = true;
            radio_Outsourced.Text = "Outsourced";
            radio_Outsourced.UseVisualStyleBackColor = true;
            // 
            // radio_InHouse
            // 
            radio_InHouse.AutoSize = true;
            radio_InHouse.Font = new Font("Segoe UI", 9F);
            radio_InHouse.Location = new Point(141, 16);
            radio_InHouse.Name = "radio_InHouse";
            radio_InHouse.Size = new Size(74, 19);
            radio_InHouse.TabIndex = 14;
            radio_InHouse.TabStop = true;
            radio_InHouse.Text = "In-House";
            radio_InHouse.UseVisualStyleBackColor = true;
            // 
            // txt_Min
            // 
            txt_Min.Location = new Point(281, 229);
            txt_Min.Name = "txt_Min";
            txt_Min.Size = new Size(70, 27);
            txt_Min.TabIndex = 13;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(140, 102);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(211, 27);
            txt_Name.TabIndex = 12;
            // 
            // txt_Inventory
            // 
            txt_Inventory.Location = new Point(140, 142);
            txt_Inventory.Name = "txt_Inventory";
            txt_Inventory.Size = new Size(211, 27);
            txt_Inventory.TabIndex = 11;
            // 
            // txt_Special
            // 
            txt_Special.Location = new Point(140, 277);
            txt_Special.Name = "txt_Special";
            txt_Special.Size = new Size(211, 27);
            txt_Special.TabIndex = 10;
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(140, 188);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(211, 27);
            txt_Price.TabIndex = 9;
            // 
            // txt_Max
            // 
            txt_Max.Location = new Point(140, 229);
            txt_Max.Name = "txt_Max";
            txt_Max.Size = new Size(70, 27);
            txt_Max.TabIndex = 8;
            // 
            // txt_ID
            // 
            txt_ID.Enabled = false;
            txt_ID.Location = new Point(140, 57);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(211, 27);
            txt_ID.TabIndex = 7;
            // 
            // lbl_Special
            // 
            lbl_Special.AutoSize = true;
            lbl_Special.Font = new Font("Segoe UI", 10F);
            lbl_Special.Location = new Point(29, 277);
            lbl_Special.Name = "lbl_Special";
            lbl_Special.Size = new Size(79, 19);
            lbl_Special.TabIndex = 6;
            lbl_Special.Text = "Machine ID";
            lbl_Special.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Min
            // 
            lbl_Min.AutoSize = true;
            lbl_Min.Font = new Font("Segoe UI", 10F);
            lbl_Min.Location = new Point(242, 229);
            lbl_Min.Name = "lbl_Min";
            lbl_Min.Size = new Size(33, 19);
            lbl_Min.TabIndex = 5;
            lbl_Min.Text = "Min";
            lbl_Min.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Max
            // 
            lbl_Max.AutoSize = true;
            lbl_Max.Font = new Font("Segoe UI", 10F);
            lbl_Max.Location = new Point(73, 229);
            lbl_Max.Name = "lbl_Max";
            lbl_Max.Size = new Size(35, 19);
            lbl_Max.TabIndex = 4;
            lbl_Max.Text = "Max";
            lbl_Max.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Inventory
            // 
            lbl_Inventory.AutoSize = true;
            lbl_Inventory.Font = new Font("Segoe UI", 10F);
            lbl_Inventory.Location = new Point(37, 142);
            lbl_Inventory.Name = "lbl_Inventory";
            lbl_Inventory.Size = new Size(68, 19);
            lbl_Inventory.TabIndex = 3;
            lbl_Inventory.Text = "Inventory";
            lbl_Inventory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Price
            // 
            lbl_Price.AutoSize = true;
            lbl_Price.Font = new Font("Segoe UI", 10F);
            lbl_Price.Location = new Point(37, 188);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(71, 19);
            lbl_Price.TabIndex = 2;
            lbl_Price.Text = "Price/Cost";
            lbl_Price.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI", 10F);
            lbl_Name.Location = new Point(60, 102);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(45, 19);
            lbl_Name.TabIndex = 1;
            lbl_Name.Text = "Name";
            lbl_Name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI", 10F);
            lbl_ID.Location = new Point(82, 59);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(23, 19);
            lbl_ID.TabIndex = 0;
            lbl_ID.Text = "ID";
            lbl_ID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 434);
            Controls.Add(groupBox);
            Name = "AddPartForm";
            Text = "AddPartForm";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private Label lbl_Special;
        private Label lbl_Min;
        private Label lbl_Max;
        private Label lbl_Inventory;
        private Label lbl_Price;
        private Label lbl_Name;
        private Label lbl_ID;
        private TextBox txt_ID;
        private TextBox txt_Name;
        private TextBox txt_Inventory;
        private TextBox txt_Special;
        private TextBox txt_Price;
        private TextBox txt_Max;
        private TextBox txt_Min;
        private RadioButton radio_Outsourced;
        private RadioButton radio_InHouse;
        private Button btn_Cancel;
        private Button btn_Save;
    }
}