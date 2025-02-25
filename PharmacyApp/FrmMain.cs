using Entities.Models;
using Repositories.Concrete;

namespace PharmacyApp
{
    public partial class FrmMain : Form
    {
        MedicineRepository _medicineRepository;

        public FrmMain()
        {
            InitializeComponent();
            _medicineRepository = new MedicineRepository();

            LoadGrid();
        }

        public void LoadGrid()
        {
            dgvLists.DataSource = _medicineRepository.GetAllMedicines();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine
            {
                Name          = txtName.Text,
                Barcode       = txtBarcode.Text,
                Price         = Convert.ToDecimal(txtPrice.Text),
                StockQuantity = Convert.ToInt32(txtStock.Text)
            };
            _medicineRepository.add(medicine);

            LoadGrid();
            MessageBox.Show("Ýlaç baþarýyla Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvLists.CurrentRow.Cells[0].Value);
            _medicineRepository.delete(id);

            LoadGrid();
            MessageBox.Show("Ýlaç baþarýyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvLists.CurrentRow.Cells[0].Value);
            FrmMedicineUpdate frmMain = new FrmMedicineUpdate(id);
            frmMain.drugUpdated += LoadGrid;
            frmMain.ShowDialog();
        }

        private void dgvLists_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow row = dgvLists.CurrentRow;
            Medicine medicine = (Medicine)row.DataBoundItem;

            txtName.Text    = medicine.Name;
            txtBarcode.Text = medicine.Barcode;
            txtPrice.Text   = medicine.Price.ToString();
            txtStock.Text   = medicine.StockQuantity.ToString();
        }

        private void cmoFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmoFilters.SelectedIndex; // Seçilen index
            string selectedItem = cmoFilters.SelectedItem?.ToString(); // Seçilen deðer

            if (selectedIndex == 0)
            {
                dgvLists.DataSource = _medicineRepository.GetOrderByASCId();
            }
            else if (selectedIndex == 1)
            {
                dgvLists.DataSource = _medicineRepository.GetOrderByDescendingId();
            }
            else if (selectedIndex == 2)
            {
                dgvLists.DataSource = _medicineRepository.GetOrderByASCName();
            }
            else if (selectedIndex == 3)
            {
                dgvLists.DataSource = _medicineRepository.GetOrderByDescendingName();
            }
            else if (selectedIndex == 4)
            {
                dgvLists.DataSource = _medicineRepository.GetOrderByASCBarcode();
            }
            else if (selectedIndex == 5)
            {
                dgvLists.DataSource = _medicineRepository.GetOrderByDescendingBarcode();
            }
            else if (selectedIndex == 6)
            {
                dgvLists.DataSource = _medicineRepository.GetOrderByASCPrice();
            }
            else if (selectedIndex == 7)
            {
                dgvLists.DataSource = _medicineRepository.GetOrderByDescendingPrice();
            }
            else if (selectedIndex == 8)
            {
                dgvLists.DataSource = _medicineRepository.GetOrderByASCStock();
            }
            else if (selectedIndex == 9)
            {
                dgvLists.DataSource = _medicineRepository.GetOrderByDescendingStock();
            }
        }
    }
}