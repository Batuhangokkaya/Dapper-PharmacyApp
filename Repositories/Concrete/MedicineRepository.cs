using Dapper;
using Entities.Models;
using Repositories.Abstract;

namespace Repositories.Concrete
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly RepositoryContext _connectionString;

        public MedicineRepository()
        {
            _connectionString = new RepositoryContext();
        }

        public void add(Medicine medicine)
        {
            using (var db = _connectionString.CreateConnection())
            {
                string query = "INSERT INTO Medicines (Name, Barcode, Price, StockQuantity) VALUES (@name, @barcode, @price, @stockQuantity)";
                db.Execute(query, new { name = medicine.Name, barcode = medicine.Barcode, price = medicine.Price, stockQuantity = medicine.StockQuantity });
            }
        }

        public void delete(int id)
        {
            using (var db = _connectionString.CreateConnection())
            {
                string query = "DELETE FROM Medicines WHERE Id = @id";
                db.Execute(query, new { id = id });
            }
        }

        public void update(Medicine medicine)
        {
            using (var db = _connectionString.CreateConnection())
            {
                string query = "UPDATE Medicines SET Name = @name, Barcode = @barcode, Price = @price, StockQuantity = @stockQuantity WHERE Id = @id";
                db.Execute(query, new { id = medicine.Id, name = medicine.Name, barcode = medicine.Barcode, price = medicine.Price, stockQuantity = medicine.StockQuantity });
            }
        }

        public IEnumerable<Medicine> GetAllMedicines()
        {
            using (var db = _connectionString.CreateConnection())
            {
                return db.Query<Medicine>("SELECT * FROM Medicines");
            }
        }

        public Medicine GetMedicineById(int id)
        {
            using (var db = _connectionString.CreateConnection())
            {
                string query = "SELECT * FROM Medicines WHERE Id = @id";
                return db.Query<Medicine>(query, new { id })
                    .FirstOrDefault();
            }
        }

        public IEnumerable<Medicine> GetOrderByASCId()
        {
            using (var db = _connectionString.CreateConnection())
            {
                return db.Query<Medicine>("SELECT * FROM Medicines")
                    .OrderBy(x => x.Id)
                    .ToList();
            }
        }

        public IEnumerable<Medicine> GetOrderByDescendingId()
        {
            using (var db = _connectionString.CreateConnection())
            {
                return db.Query<Medicine>("SELECT * FROM Medicines")
                    .OrderByDescending(x => x.Id)
                    .ToList();
            }
        }

        public IEnumerable<Medicine> GetOrderByASCName()
        {
            using (var db = _connectionString.CreateConnection())
            {
                return db.Query<Medicine>("SELECT * FROM Medicines")
                    .OrderBy(x => x.Name)
                    .ToList();
            }
        }

        public IEnumerable<Medicine> GetOrderByDescendingName()
        {
            using (var db = _connectionString.CreateConnection())
            {
                return db.Query<Medicine>("SELECT * FROM Medicines")
                    .OrderByDescending(x => x.Name)
                    .ToList();
            }
        }

        public IEnumerable<Medicine> GetOrderByASCBarcode()
        {
            using (var db = _connectionString.CreateConnection())
            {
                return db.Query<Medicine>("SELECT * FROM Medicines")
                    .OrderBy(x => x.Barcode)
                    .ToList();
            }
        }

        public IEnumerable<Medicine> GetOrderByDescendingBarcode()
        {
            using (var db = _connectionString.CreateConnection())
            {
                return db.Query<Medicine>("SELECT * FROM Medicines")
                    .OrderByDescending(x => x.Barcode)
                    .ToList();
            }
        }

        public IEnumerable<Medicine> GetOrderByASCPrice()
        {
            using (var db = _connectionString.CreateConnection())
            {
                return db.Query<Medicine>("SELECT * FROM Medicines")
                    .OrderBy(x => x.Price)
                    .ToList();
            }
        }

        public IEnumerable<Medicine> GetOrderByDescendingPrice()
        {
            using (var db = _connectionString.CreateConnection())
            {
                return db.Query<Medicine>("SELECT * FROM Medicines")
                    .OrderByDescending(x => x.Price)
                    .ToList();
            }
        }

        public IEnumerable<Medicine> GetOrderByASCStock()
        {
            using (var db = _connectionString.CreateConnection())
            {
                return db.Query<Medicine>("SELECT * FROM Medicines")
                    .OrderBy(x => x.StockQuantity)
                    .ToList();
            }
        }

        public IEnumerable<Medicine> GetOrderByDescendingStock()
        {
            using (var db = _connectionString.CreateConnection())
            {
                return db.Query<Medicine>("SELECT * FROM Medicines")
                    .OrderByDescending(x => x.StockQuantity)
                    .ToList();
            }
        }
    }
}