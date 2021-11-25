using System;
using System.Collections.Generic;
using System.Linq;

namespace CryptoPicker.Models
{
    public class EntryRepository : IEntryRepository
    {
        private readonly AppDbContext _appDbContext;

        public EntryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Entry> AllEntries
        {
            get
            {
                return _appDbContext.Entries;
            }
        }

        public Entry GetEntryById(int entryId)
        {
            return _appDbContext.Entries.FirstOrDefault(e => e.EntryId == entryId);
        }
    }
}
