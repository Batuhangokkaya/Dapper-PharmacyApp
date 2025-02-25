namespace PharmacyApp
{
    partial class FrmMain
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
            dgvLists = new DataGridView();
            txtName = new TextBox();
            txtBarcode = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            lblName = new Label();
            lblBarcode = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cmoFilters = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvLists).BeginInit();
            SuspendLayout();
            // 
            // dgvLists
            // 
            dgvLists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLists.Location = new Point(259, 12);
            dgvLists.Name = "dgvLists";
            dgvLists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLists.Size = new Size(659, 237);
            dgvLists.TabIndex = 0;
            dgvLists.MouseClick += dgvLists_MouseClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(123, 23);
            txtName.TabIndex = 1;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(130, 50);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(123, 23);
            txtBarcode.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(130, 88);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(123, 23);
            txtPrice.TabIndex = 3;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(130, 126);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(123, 23);
            txtStock.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(46, 15);
            lblName.TabIndex = 5;
            lblName.Text = "İlaç Adı";
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(12, 53);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(98, 15);
            lblBarcode.TabIndex = 6;
            lblBarcode.Text = "Barkod Numarası";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 91);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(32, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Fiyat";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(12, 129);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(30, 15);
            lblStock.TabIndex = 8;
            lblStock.Text = "Stok";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(16, 226);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(97, 226);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(178, 226);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmoFilters
            // 
            cmoFilters.DropDownStyle = ComboBoxStyle.DropDownList;
            cmoFilters.FormattingEnabled = true;
            cmoFilters.Items.AddRange(new object[] { "İlaç Numarasına Göre Sırala", "İlaç Numarasına Göre Sırala (Ters)", "İsme Göre Sırala", "İsme Göre Sırala (Ters)", "Barkod Numarasına Göre Sırala", "Barkod Numarasına Göre Sırala (Ters)", "Fiyata Göre Sırala", "Fiyata Göre Sırala (Ters)", "Stok'a Göre Sırala", "Stok'a Göre Sırala (Ters)" });
            cmoFilters.Location = new Point(130, 165);
            cmoFilters.Name = "cmoFilters";
            cmoFilters.Size = new Size(121, 23);
            cmoFilters.TabIndex = 12;
            cmoFilters.SelectedIndexChanged += cmoFilters_SelectedIndexChanged;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 261);
            Controls.Add(cmoFilters);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblBarcode);
            Controls.Add(lblName);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtBarcode);
            Controls.Add(txtName);
            Controls.Add(dgvLists);
            Name = "FrmMain";
            Text = "İlaç";
            ((System.ComponentModel.ISupportInitialize)dgvLists).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLists;
        private TextBox txtName;
        private TextBox txtBarcode;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Label lblName;
        private Label lblBarcode;
        private Label lblPrice;
        private Label lblStock;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cmoFilters;
    }
}
