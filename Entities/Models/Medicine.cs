using System.ComponentModel;

namespace Entities.Models
{
    public class Medicine
    {
        [DisplayName("İlaç Numarası")]
        public int Id { get; set; }
        [DisplayName("İlaç İsmi")]
        public string Name { get; set; }
        [DisplayName("Barkod Numarası")]
        public string Barcode { get; set; }
        [DisplayName("Fiyat")]
        public decimal Price { get; set; }
        [DisplayName("Stok Adeti")]
        public int StockQuantity { get; set; }
    }
}