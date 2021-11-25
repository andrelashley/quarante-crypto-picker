using System;
using System.Collections.Generic;

namespace CryptoPicker.Models
{
    public class MockEntryRepository : IEntryRepository
    {
        public IEnumerable<Entry> AllEntries => throw new NotImplementedException();

        public Entry GetEntryById(int entryId)
        {
            throw new NotImplementedException();
        }
    }
}
