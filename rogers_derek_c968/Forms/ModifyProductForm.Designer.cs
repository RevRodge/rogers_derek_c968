namespace rogers_derek_c968.Forms
{
    partial class ModifyProductForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox = new GroupBox();
            btn_PartSearch = new Button();
            lbl_AllParts = new Label();
            lbl_AssociatedParts = new Label();
            txt_PartSearch = new TextBox();
            btn_AddPart = new Button();
            grid_AssociatedParts = new DataGridView();
            assocPartID = new DataGridViewTextBoxColumn();
            assocPartName = new DataGridViewTextBoxColumn();
            assocInventory = new DataGridViewTextBoxColumn();
            assocPrice = new DataGridViewTextBoxColumn();
            assocMin = new DataGridViewTextBoxColumn();
            assocMax = new DataGridViewTextBoxColumn();
            grid_AllParts = new DataGridView();
            PartID = new DataGridViewTextBoxColumn();
            PartName = new DataGridViewTextBoxColumn();
            InventoryLevel = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Min = new DataGridViewTextBoxColumn();
            Max = new DataGridViewTextBoxColumn();
            btn_Save = new Button();
            btn_Cancel = new Button();
            btn_RemovePart = new Button();
            txt_Min = new TextBox();
            txt_Name = new TextBox();
            txt_Inventory = new TextBox();
            txt_Price = new TextBox();
            txt_Max = new TextBox();
            txt_ID = new TextBox();
            lbl_Min = new Label();
            lbl_Max = new Label();
            lbl_Inventory = new Label();
            lbl_Price = new Label();
            lbl_Name = new Label();
            lbl_ID = new Label();
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_AddPart.Click += new System.EventHandler(this.btn_AddPart_Click);
            this.btn_RemovePart.Click += new System.EventHandler(this.btn_RemovePart_Click);
            this.btn_PartSearch.Click += new System.EventHandler(this.btn_PartSearch_Click);
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_AssociatedParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_AllParts).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = SystemColors.ControlLight;
            groupBox.Controls.Add(btn_PartSearch);
            groupBox.Controls.Add(lbl_AllParts);
            groupBox.Controls.Add(lbl_AssociatedParts);
            groupBox.Controls.Add(txt_PartSearch);
            groupBox.Controls.Add(btn_AddPart);
            groupBox.Controls.Add(grid_AssociatedParts);
            groupBox.Controls.Add(grid_AllParts);
            groupBox.Controls.Add(btn_Save);
            groupBox.Controls.Add(btn_Cancel);
            groupBox.Controls.Add(btn_RemovePart);
            groupBox.Controls.Add(txt_Min);
            groupBox.Controls.Add(txt_Name);
            groupBox.Controls.Add(txt_Inventory);
            groupBox.Controls.Add(txt_Price);
            groupBox.Controls.Add(txt_Max);
            groupBox.Controls.Add(txt_ID);
            groupBox.Controls.Add(lbl_Min);
            groupBox.Controls.Add(lbl_Max);
            groupBox.Controls.Add(lbl_Inventory);
            groupBox.Controls.Add(lbl_Price);
            groupBox.Controls.Add(lbl_Name);
            groupBox.Controls.Add(lbl_ID);
            groupBox.Font = new Font("Segoe UI", 11F);
            groupBox.Location = new Point(12, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(1095, 671);
            groupBox.TabIndex = 2;
            groupBox.TabStop = false;
            groupBox.Text = "Modify Product";
            // 
            // btn_PartSearch
            // 
            btn_PartSearch.BackColor = SystemColors.ButtonFace;
            btn_PartSearch.Font = new Font("Segoe UI", 10F);
            btn_PartSearch.Location = new Point(663, 24);
            btn_PartSearch.Name = "btn_PartSearch";
            btn_PartSearch.Size = new Size(87, 31);
            btn_PartSearch.TabIndex = 25;
            btn_PartSearch.Text = "Search";
            btn_PartSearch.UseVisualStyleBackColor = false;
            // 
            // lbl_AllParts
            // 
            lbl_AllParts.AutoSize = true;
            lbl_AllParts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_AllParts.Location = new Point(430, 57);
            lbl_AllParts.Name = "lbl_AllParts";
            lbl_AllParts.Size = new Size(137, 19);
            lbl_AllParts.TabIndex = 24;
            lbl_AllParts.Text = "All Candidate Parts";
            // 
            // lbl_AssociatedParts
            // 
            lbl_AssociatedParts.AutoSize = true;
            lbl_AssociatedParts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_AssociatedParts.Location = new Point(430, 342);
            lbl_AssociatedParts.Name = "lbl_AssociatedParts";
            lbl_AssociatedParts.Size = new Size(235, 19);
            lbl_AssociatedParts.TabIndex = 23;
            lbl_AssociatedParts.Text = "Parts Associated with this Product";
            // 
            // txt_PartSearch
            // 
            txt_PartSearch.Location = new Point(770, 26);
            txt_PartSearch.Name = "txt_PartSearch";
            txt_PartSearch.Size = new Size(304, 27);
            txt_PartSearch.TabIndex = 22;
            // 
            // btn_AddPart
            // 
            btn_AddPart.BackColor = SystemColors.ButtonFace;
            btn_AddPart.Font = new Font("Segoe UI", 10F);
            btn_AddPart.Location = new Point(999, 288);
            btn_AddPart.Name = "btn_AddPart";
            btn_AddPart.Size = new Size(75, 31);
            btn_AddPart.TabIndex = 21;
            btn_AddPart.Text = "Add";
            btn_AddPart.UseVisualStyleBackColor = false;
            // 
            // grid_AssociatedParts
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grid_AssociatedParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grid_AssociatedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_AssociatedParts.Columns.AddRange(new DataGridViewColumn[] { assocPartID, assocPartName, assocInventory, assocPrice, assocMin, assocMax });
            grid_AssociatedParts.Location = new Point(430, 364);
            grid_AssociatedParts.Name = "grid_AssociatedParts";
            grid_AssociatedParts.Size = new Size(644, 199);
            grid_AssociatedParts.TabIndex = 20;
            // 
            // assocPartID
            // 
            assocPartID.HeaderText = "Part ID";
            assocPartID.Name = "assocPartID";
            // 
            // assocPartName
            // 
            assocPartName.HeaderText = "Part Name";
            assocPartName.Name = "assocPartName";
            // 
            // assocInventory
            // 
            assocInventory.HeaderText = "Inventory";
            assocInventory.Name = "assocInventory";
            // 
            // assocPrice
            // 
            assocPrice.HeaderText = "Price";
            assocPrice.Name = "assocPrice";
            // 
            // assocMin
            // 
            assocMin.HeaderText = "Min";
            assocMin.Name = "assocMin";
            // 
            // assocMax
            // 
            assocMax.HeaderText = "Max";
            assocMax.Name = "assocMax";
            // 
            // grid_AllParts
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grid_AllParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grid_AllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_AllParts.Columns.AddRange(new DataGridViewColumn[] { PartID, PartName, InventoryLevel, Price, Min, Max });
            grid_AllParts.Location = new Point(430, 83);
            grid_AllParts.Name = "grid_AllParts";
            grid_AllParts.Size = new Size(644, 199);
            grid_AllParts.TabIndex = 19;
            // 
            // PartID
            // 
            PartID.HeaderText = "Part ID";
            PartID.Name = "PartID";
            // 
            // PartName
            // 
            PartName.HeaderText = "Part Name";
            PartName.Name = "PartName";
            // 
            // InventoryLevel
            // 
            InventoryLevel.HeaderText = "Inventory";
            InventoryLevel.Name = "InventoryLevel";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Min
            // 
            Min.HeaderText = "Min";
            Min.Name = "Min";
            // 
            // Max
            // 
            Max.HeaderText = "Max";
            Max.Name = "Max";
            // 
            // btn_Save
            // 
            btn_Save.BackColor = SystemColors.ButtonFace;
            btn_Save.Font = new Font("Segoe UI", 10F);
            btn_Save.Location = new Point(918, 625);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 31);
            btn_Save.TabIndex = 16;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = SystemColors.ButtonFace;
            btn_Cancel.Font = new Font("Segoe UI", 10F);
            btn_Cancel.Location = new Point(999, 625);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 31);
            btn_Cancel.TabIndex = 17;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_RemovePart
            // 
            btn_RemovePart.BackColor = SystemColors.ButtonFace;
            btn_RemovePart.Font = new Font("Segoe UI", 10F);
            btn_RemovePart.Location = new Point(999, 569);
            btn_RemovePart.Name = "btn_RemovePart";
            btn_RemovePart.Size = new Size(75, 31);
            btn_RemovePart.TabIndex = 18;
            btn_RemovePart.Text = "Delete";
            btn_RemovePart.UseVisualStyleBackColor = false;
            // 
            // txt_Min
            // 
            txt_Min.Location = new Point(264, 400);
            txt_Min.Name = "txt_Min";
            txt_Min.Size = new Size(100, 27);
            txt_Min.TabIndex = 13;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(139, 273);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(211, 27);
            txt_Name.TabIndex = 12;
            // 
            // txt_Inventory
            // 
            txt_Inventory.Location = new Point(139, 313);
            txt_Inventory.Name = "txt_Inventory";
            txt_Inventory.Size = new Size(211, 27);
            txt_Inventory.TabIndex = 11;
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(139, 359);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(211, 27);
            txt_Price.TabIndex = 9;
            // 
            // txt_Max
            // 
            txt_Max.Location = new Point(90, 400);
            txt_Max.Name = "txt_Max";
            txt_Max.Size = new Size(100, 27);
            txt_Max.TabIndex = 8;
            // 
            // txt_ID
            // 
            txt_ID.Enabled = false;
            txt_ID.Location = new Point(139, 228);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(211, 27);
            txt_ID.TabIndex = 7;
            // 
            // lbl_Min
            // 
            lbl_Min.AutoSize = true;
            lbl_Min.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_Min.Location = new Point(213, 400);
            lbl_Min.Name = "lbl_Min";
            lbl_Min.Size = new Size(34, 19);
            lbl_Min.TabIndex = 5;
            lbl_Min.Text = "Min";
            lbl_Min.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Max
            // 
            lbl_Max.AutoSize = true;
            lbl_Max.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_Max.Location = new Point(36, 400);
            lbl_Max.Name = "lbl_Max";
            lbl_Max.Size = new Size(38, 19);
            lbl_Max.TabIndex = 4;
            lbl_Max.Text = "Max";
            lbl_Max.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Inventory
            // 
            lbl_Inventory.AutoSize = true;
            lbl_Inventory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_Inventory.Location = new Point(36, 313);
            lbl_Inventory.Name = "lbl_Inventory";
            lbl_Inventory.Size = new Size(74, 19);
            lbl_Inventory.TabIndex = 3;
            lbl_Inventory.Text = "Inventory";
            lbl_Inventory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Price
            // 
            lbl_Price.AutoSize = true;
            lbl_Price.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_Price.Location = new Point(36, 359);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(78, 19);
            lbl_Price.TabIndex = 2;
            lbl_Price.Text = "Price/Cost";
            lbl_Price.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_Name.Location = new Point(36, 273);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(49, 19);
            lbl_Name.TabIndex = 1;
            lbl_Name.Text = "Name";
            lbl_Name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_ID.Location = new Point(36, 228);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(23, 19);
            lbl_ID.TabIndex = 0;
            lbl_ID.Text = "ID";
            lbl_ID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ModifyProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 696);
            Controls.Add(groupBox);
            Name = "ModifyProductForm";
            Text = "ModifyProductForm";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_AssociatedParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_AllParts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private Button btn_PartSearch;
        private Label lbl_AllParts;
        private Label lbl_AssociatedParts;
        private TextBox txt_PartSearch;
        private Button btn_AddPart;
        private DataGridView grid_AssociatedParts;
        private DataGridViewTextBoxColumn assocPartID;
        private DataGridViewTextBoxColumn assocPartName;
        private DataGridViewTextBoxColumn assocInventory;
        private DataGridViewTextBoxColumn assocPrice;
        private DataGridViewTextBoxColumn assocMin;
        private DataGridViewTextBoxColumn assocMax;
        private DataGridView grid_AllParts;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn PartName;
        private DataGridViewTextBoxColumn InventoryLevel;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Min;
        private DataGridViewTextBoxColumn Max;
        private Button btn_Save;
        private Button btn_Cancel;
        private Button btn_RemovePart;
        private TextBox txt_Min;
        private TextBox txt_Name;
        private TextBox txt_Inventory;
        private TextBox txt_Price;
        private TextBox txt_Max;
        private TextBox txt_ID;
        private Label lbl_Min;
        private Label lbl_Max;
        private Label lbl_Inventory;
        private Label lbl_Price;
        private Label lbl_Name;
        private Label lbl_ID;
    }
}