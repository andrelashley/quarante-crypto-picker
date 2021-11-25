using CryptoPicker.Models;
using Microsoft.AspNetCore.Mvc;

namespace CryptoPicker.Controllers
{
    public class EntryController : Controller
    {
        private readonly IEntryRepository _entryRepository;

        public EntryController(IEntryRepository entryRepository)
        {
            _entryRepository = entryRepository;
        }

        public ViewResult List()
        {
            return View(_entryRepository.AllEntries);
        }
    }
}
