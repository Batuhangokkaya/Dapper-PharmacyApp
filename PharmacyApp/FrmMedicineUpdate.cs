using Entities.Models;
using Repositories.Concrete;

namespace PharmacyApp
{
    public partial class FrmMedicineUpdate : Form
    {
        private readonly MedicineRepository _medicineRepository;
        private int medicineId;

        public event Action? drugUpdated;

        public FrmMedicineUpdate(int selectId)
        {
            InitializeComponent();
            _medicineRepository = new MedicineRepository();

            medicineId = selectId;

            LoadMedicineList();
        }

        public void LoadMedicineList()
        {
            Medicine medicine = _medicineRepository.GetMedicineById(medicineId);

            if (medicine != null)
            {
                txtId.Text      = medicine.Id.ToString();
                txtName.Text    = medicine.Name;
                txtBarcode.Text = medicine.Barcode;
                txtPrice.Text   = medicine.Price.ToString();
                txtStock.Text   = medicine.StockQuantity.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine
            {
                Id            = Convert.ToInt32(txtId.Text),
                Name          = txtName.Text,
                Barcode       = txtBarcode.Text,
                Price         = Convert.ToDecimal(txtPrice.Text),
                StockQuantity = Convert.ToInt32(txtStock.Text)
            };
            _medicineRepository.update(medicine);

            drugUpdated?.Invoke();
            MessageBox.Show("İlaç başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}