namespace CryptoPicker.Models
{
    public class MockCryptoRepository : ICryptoRepository
    {
        public Crypto GetCryptoById(int cryptoId)
        {
            throw new System.NotImplementedException();
        }
    }
}
