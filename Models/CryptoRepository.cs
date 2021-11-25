using System.Linq;

namespace CryptoPicker.Models
{
    public class CryptoRepository : ICryptoRepository
    {
        private readonly AppDbContext _appDbContext;

        public CryptoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Crypto GetCryptoById(int cryptoId)
        {
            return _appDbContext.Cryptos.FirstOrDefault(e => e.CryptoId == cryptoId);
        }
    }
}
