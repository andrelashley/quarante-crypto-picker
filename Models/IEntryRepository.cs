using System.Collections.Generic;

namespace CryptoPicker.Models
{
    public interface IEntryRepository
    {
        IEnumerable<Entry> AllEntries { get; }
        Entry GetEntryById(int entryId);
    }
}
