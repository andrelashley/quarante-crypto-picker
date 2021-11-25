using System;
using System.Collections.Generic;

namespace CryptoPicker.Models
{
    public class Entry
    {
        public int EntryId { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Crypto> Cryptos { get; set; }
    }
}
