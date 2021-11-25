namespace CryptoPicker.Models
{
    public interface ICryptoRepository
    {
        Crypto GetCryptoById(int cryptoId);
    }
}
