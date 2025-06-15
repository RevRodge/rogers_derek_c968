namespace rogers_derek_c968.Forms
{
    partial class AddProductForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox = new GroupBox();
            btn_Cancel = new Button();
            btn_Save = new Button();
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
            btn_RemovePart = new Button();
            grid_AllParts = new DataGridView();
            grid_AssociatedParts = new DataGridView(); 
            btn_AddPart = new Button();
            txt_PartSearch = new TextBox();
            lbl_AssociatedParts = new Label();
            lbl_AllParts = new Label();
            btn_PartSearch = new Button();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_AllParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_AssociatedParts).BeginInit();
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
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Add Product";
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
            // grid_AllParts
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grid_AllParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grid_AllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_AllParts.Location = new Point(430, 83);
            grid_AllParts.Name = "grid_AllParts";
            grid_AllParts.Size = new Size(644, 199);
            grid_AllParts.TabIndex = 19;
            PartID = new DataGridViewTextBoxColumn();
            PartID.HeaderText = "Part ID";
            PartID.Name = "partID";

            PartName = new DataGridViewTextBoxColumn();
            PartName.HeaderText = "Part Name";
            PartName.Name = "partName";

            InventoryLevel = new DataGridViewTextBoxColumn();
            InventoryLevel.HeaderText = "Inventory";
            InventoryLevel.Name = "inventory";

            Price = new DataGridViewTextBoxColumn();
            Price.HeaderText = "Price";
            Price.Name = "price";

            Min = new DataGridViewTextBoxColumn();
            Min.HeaderText = "Min";
            Min.Name = "min";

            Max = new DataGridViewTextBoxColumn();
            Max.HeaderText = "Max";
            Max.Name = "max";

            grid_AllParts.Columns.AddRange(new DataGridViewColumn[] {
                PartID,
                PartName,
                InventoryLevel,
                Price,
                Min,
                Max
            });
            // 
            // grid_AssociatedParts
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grid_AssociatedParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grid_AssociatedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_AssociatedParts.Location = new Point(430, 364);
            grid_AssociatedParts.Name = "grid_AssociatedParts";
            grid_AssociatedParts.Size = new Size(644, 199);
            grid_AssociatedParts.TabIndex = 20;
            var assocPartID = new DataGridViewTextBoxColumn();
            assocPartID.HeaderText = "Part ID";
            assocPartID.Name = "assocPartID";

            var assocPartName = new DataGridViewTextBoxColumn();
            assocPartName.HeaderText = "Part Name";
            assocPartName.Name = "assocPartName";

            var assocInventory = new DataGridViewTextBoxColumn();
            assocInventory.HeaderText = "Inventory";
            assocInventory.Name = "assocInventory";

            var assocPrice = new DataGridViewTextBoxColumn();
            assocPrice.HeaderText = "Price";
            assocPrice.Name = "assocPrice";

            var assocMin = new DataGridViewTextBoxColumn();
            assocMin.HeaderText = "Min";
            assocMin.Name = "assocMin";

            var assocMax = new DataGridViewTextBoxColumn();
            assocMax.HeaderText = "Max";
            assocMax.Name = "assocMax";

            grid_AssociatedParts.Columns.AddRange(new DataGridViewColumn[] {
                assocPartID,
                assocPartName,
                assocInventory,
                assocPrice,
                assocMin,
                assocMax
            });


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
            // txt_PartSearch
            // 
            txt_PartSearch.Location = new Point(770, 26);
            txt_PartSearch.Name = "txt_PartSearch";
            txt_PartSearch.Size = new Size(304, 27);
            txt_PartSearch.TabIndex = 22;
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
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 695);
            Controls.Add(groupBox);
            Name = "AddProductForm";
            Text = "AddProductForm";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_AllParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_AssociatedParts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
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
        private Button btn_Cancel;
        private Button btn_Save;
        private Button btn_RemovePart;
        private DataGridView grid_AllParts;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn PartName;
        private DataGridViewTextBoxColumn InventoryLevel;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Min;
        private DataGridViewTextBoxColumn Max;
        private Button btn_AddPart;
        private DataGridView grid_AssociatedParts;
        private Label lbl_AllParts;
        private Label lbl_AssociatedParts;
        private TextBox txt_PartSearch;
        private Button btn_PartSearch;
    }
}