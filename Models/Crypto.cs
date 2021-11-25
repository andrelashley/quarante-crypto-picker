using System.ComponentModel.DataAnnotations.Schema;

namespace CryptoPicker.Models
{
    public class Crypto
    {
        public int CryptoId { get; set; }
        public int Position { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string PercentChange { get; set; }
        public string Volume { get; set; }
        public int EntryId { get; set; }
        public Entry Entry { get; set; }
    }
}
