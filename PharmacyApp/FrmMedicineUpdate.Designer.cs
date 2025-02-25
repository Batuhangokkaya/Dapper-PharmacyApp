namespace PharmacyApp
{
    partial class FrmMedicineUpdate
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
            lblStock = new Label();
            lblPrice = new Label();
            lblBarcode = new Label();
            lblName = new Label();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            txtBarcode = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            btnUpdate = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(12, 167);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(30, 15);
            lblStock.TabIndex = 16;
            lblStock.Text = "Stok";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 129);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(32, 15);
            lblPrice.TabIndex = 15;
            lblPrice.Text = "Fiyat";
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(12, 91);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(98, 15);
            lblBarcode.TabIndex = 14;
            lblBarcode.Text = "Barkod Numarası";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(46, 15);
            lblName.TabIndex = 13;
            lblName.Text = "İlaç Adı";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(130, 164);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(123, 23);
            txtStock.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(130, 126);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(123, 23);
            txtPrice.TabIndex = 11;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(130, 88);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(123, 23);
            txtBarcode.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(123, 23);
            txtName.TabIndex = 9;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(130, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(123, 23);
            txtId.TabIndex = 17;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(91, 204);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(181, 204);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 19;
            btnClose.Text = "Kapat";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmMedicineUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 239);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(txtId);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblBarcode);
            Controls.Add(lblName);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtBarcode);
            Controls.Add(txtName);
            Name = "FrmMedicineUpdate";
            Text = "İlaç Güncelle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStock;
        private Label lblPrice;
        private Label lblBarcode;
        private Label lblName;
        private TextBox txtStock;
        private TextBox txtPrice;
        private TextBox txtBarcode;
        private TextBox txtName;
        private TextBox txtId;
        private Button btnUpdate;
        private Button btnClose;
    }
}