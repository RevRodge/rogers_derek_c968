namespace rogers_derek_c968
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            title = new Label();
            btn_PartSearch = new Button();
            gridView_Parts = new DataGridView();
            gridView_Prod = new DataGridView();
            btn_ProdSearch = new Button();
            txtbx_PartSearch = new TextBox();
            txtbx_ProdSearch = new TextBox();
            btn_PartAdd = new Button();
            btn_PartMod = new Button();
            btn_PartDel = new Button();
            btn_ProdDel = new Button();
            btn_ProdMod = new Button();
            btn_ProdAdd = new Button();
            btn_Exit = new Button();
            this.btn_PartAdd.Click += new System.EventHandler(this.btn_PartAdd_Click);
            this.btn_PartMod.Click += new System.EventHandler(this.btn_PartMod_Click);
            this.btn_PartDel.Click += new System.EventHandler(this.btn_PartDel_Click);
            this.btn_ProdAdd.Click += new System.EventHandler(this.btn_ProdAdd_Click);
            this.btn_ProdMod.Click += new System.EventHandler(this.btn_ProdMod_Click);
            this.btn_ProdDel.Click += new System.EventHandler(this.btn_ProdDel_Click);
            this.btn_PartSearch.Click += new System.EventHandler(this.btn_PartSearch_Click);
            this.btn_ProdSearch.Click += new System.EventHandler(this.btn_ProdSearch_Click);
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            grpBox_Parts = new GroupBox();
            grpBox_Prod = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)gridView_Parts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView_Prod).BeginInit();
            grpBox_Parts.SuspendLayout();
            grpBox_Prod.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            title.Location = new Point(9, 6);
            title.Name = "title";
            title.Size = new Size(280, 25);
            title.TabIndex = 0;
            title.Text = "Inventory Management System";
            // 
            // btn_PartSearch
            // 
            btn_PartSearch.BackColor = SystemColors.ButtonFace;
            btn_PartSearch.Location = new Point(175, 2);
            btn_PartSearch.Name = "btn_PartSearch";
            btn_PartSearch.Size = new Size(77, 28);
            btn_PartSearch.TabIndex = 3;
            btn_PartSearch.Text = "Search\r\n";
            btn_PartSearch.UseVisualStyleBackColor = false;
            // 
            // gridView_Parts
            // 
            gridView_Parts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView_Parts.Location = new Point(6, 36);
            gridView_Parts.Name = "gridView_Parts";
            gridView_Parts.Size = new Size(470, 251);
            gridView_Parts.TabIndex = 4;
            // 
            // gridView_Prod
            // 
            gridView_Prod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView_Prod.Location = new Point(0, 33);
            gridView_Prod.Name = "gridView_Prod";
            gridView_Prod.Size = new Size(470, 254);
            gridView_Prod.TabIndex = 5;
            // 
            // btn_ProdSearch
            // 
            btn_ProdSearch.BackColor = SystemColors.ButtonFace;
            btn_ProdSearch.Location = new Point(170, -3);
            btn_ProdSearch.Name = "btn_ProdSearch";
            btn_ProdSearch.Size = new Size(77, 30);
            btn_ProdSearch.TabIndex = 6;
            btn_ProdSearch.Text = "Search\r\n";
            btn_ProdSearch.UseVisualStyleBackColor = false;
            // 
            // txtbx_PartSearch
            // 
            txtbx_PartSearch.Location = new Point(258, 3);
            txtbx_PartSearch.Name = "txtbx_PartSearch";
            txtbx_PartSearch.Size = new Size(217, 27);
            txtbx_PartSearch.TabIndex = 7;
            // 
            // txtbx_ProdSearch
            // 
            txtbx_ProdSearch.Location = new Point(253, 0);
            txtbx_ProdSearch.Name = "txtbx_ProdSearch";
            txtbx_ProdSearch.Size = new Size(217, 27);
            txtbx_ProdSearch.TabIndex = 8;
            // 
            // btn_PartAdd
            // 
            btn_PartAdd.BackColor = SystemColors.ButtonFace;
            btn_PartAdd.Location = new Point(238, 295);
            btn_PartAdd.Name = "btn_PartAdd";
            btn_PartAdd.Size = new Size(75, 33);
            btn_PartAdd.TabIndex = 9;
            btn_PartAdd.Text = "Add";
            btn_PartAdd.UseVisualStyleBackColor = false;
            // 
            // btn_PartMod
            // 
            btn_PartMod.BackColor = SystemColors.ButtonFace;
            btn_PartMod.Location = new Point(319, 296);
            btn_PartMod.Name = "btn_PartMod";
            btn_PartMod.Size = new Size(75, 33);
            btn_PartMod.TabIndex = 10;
            btn_PartMod.Text = "Modify";
            btn_PartMod.UseVisualStyleBackColor = false;
            btn_PartMod.Click += btn_PartMod_Click;
            // 
            // btn_PartDel
            // 
            btn_PartDel.BackColor = SystemColors.ButtonFace;
            btn_PartDel.Location = new Point(400, 295);
            btn_PartDel.Name = "btn_PartDel";
            btn_PartDel.Size = new Size(75, 33);
            btn_PartDel.TabIndex = 11;
            btn_PartDel.Text = "Delete";
            btn_PartDel.UseVisualStyleBackColor = false;
            // 
            // btn_ProdDel
            // 
            btn_ProdDel.BackColor = SystemColors.ButtonFace;
            btn_ProdDel.Location = new Point(395, 296);
            btn_ProdDel.Name = "btn_ProdDel";
            btn_ProdDel.Size = new Size(75, 29);
            btn_ProdDel.TabIndex = 14;
            btn_ProdDel.Text = "Delete";
            btn_ProdDel.UseVisualStyleBackColor = false;
            // 
            // btn_ProdMod
            // 
            btn_ProdMod.BackColor = SystemColors.ButtonFace;
            btn_ProdMod.Location = new Point(314, 296);
            btn_ProdMod.Name = "btn_ProdMod";
            btn_ProdMod.Size = new Size(75, 29);
            btn_ProdMod.TabIndex = 13;
            btn_ProdMod.Text = "Modify";
            btn_ProdMod.UseVisualStyleBackColor = false;
            // 
            // btn_ProdAdd
            // 
            btn_ProdAdd.BackColor = SystemColors.ButtonFace;
            btn_ProdAdd.Location = new Point(233, 296);
            btn_ProdAdd.Name = "btn_ProdAdd";
            btn_ProdAdd.Size = new Size(75, 29);
            btn_ProdAdd.TabIndex = 12;
            btn_ProdAdd.Text = "Add";
            btn_ProdAdd.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = SystemColors.ButtonFace;
            btn_Exit.Font = new Font("Segoe UI", 11F);
            btn_Exit.Location = new Point(946, 438);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(75, 37);
            btn_Exit.TabIndex = 15;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // grpBox_Parts
            // 
            grpBox_Parts.Controls.Add(btn_PartAdd);
            grpBox_Parts.Controls.Add(gridView_Parts);
            grpBox_Parts.Controls.Add(txtbx_PartSearch);
            grpBox_Parts.Controls.Add(btn_PartDel);
            grpBox_Parts.Controls.Add(btn_PartSearch);
            grpBox_Parts.Controls.Add(btn_PartMod);
            grpBox_Parts.Font = new Font("Segoe UI", 11F);
            grpBox_Parts.Location = new Point(12, 63);
            grpBox_Parts.Name = "grpBox_Parts";
            grpBox_Parts.Size = new Size(481, 334);
            grpBox_Parts.TabIndex = 16;
            grpBox_Parts.TabStop = false;
            grpBox_Parts.Text = "Parts";
            // 
            // grpBox_Prod
            // 
            grpBox_Prod.Controls.Add(btn_ProdAdd);
            grpBox_Prod.Controls.Add(gridView_Prod);
            grpBox_Prod.Controls.Add(btn_ProdDel);
            grpBox_Prod.Controls.Add(btn_ProdMod);
            grpBox_Prod.Controls.Add(txtbx_ProdSearch);
            grpBox_Prod.Controls.Add(btn_ProdSearch);
            grpBox_Prod.Font = new Font("Segoe UI", 11F);
            grpBox_Prod.Location = new Point(551, 63);
            grpBox_Prod.Name = "grpBox_Prod";
            grpBox_Prod.Size = new Size(472, 334);
            grpBox_Prod.TabIndex = 17;
            grpBox_Prod.TabStop = false;
            grpBox_Prod.Text = "Products";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1035, 496);
            Controls.Add(btn_Exit);
            Controls.Add(title);
            Controls.Add(grpBox_Parts);
            Controls.Add(grpBox_Prod);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridView_Parts).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView_Prod).EndInit();
            grpBox_Parts.ResumeLayout(false);
            grpBox_Parts.PerformLayout();
            grpBox_Prod.ResumeLayout(false);
            grpBox_Prod.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private GroupBox grpBox_Parts;
        private GroupBox grpBox_Prod;
        private Button btn_PartSearch;
        private TextBox txtbx_PartSearch;
        private DataGridView gridView_Parts;
        private DataGridView gridView_Prod;
        private Button btn_ProdSearch;        
        private TextBox txtbx_ProdSearch;
        private Button btn_PartAdd;
        private Button btn_PartMod;
        private Button btn_PartDel;
        private Button btn_ProdDel;
        private Button btn_ProdMod;
        private Button btn_ProdAdd;
        private Button btn_Exit;
        
    }
}
