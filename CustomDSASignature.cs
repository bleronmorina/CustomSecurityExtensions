using System.Security.Cryptography;
using System.Text;

namespace CustomSecurityExtensions
{
    public class CustomDSASignature
    {
        private readonly DSACryptoServiceProvider _dsa;

        public CustomDSASignature(int keySize)
        {
            _dsa = new DSACryptoServiceProvider(keySize);
        }

        public byte[] SignMessage(string message, HashAlgorithmName hashAlgorithm)
        {
            if (string.IsNullOrEmpty(message))
                throw new ArgumentException("Message cannot be null or empty.");

            var messageBytes = Encoding.UTF8.GetBytes(message);
            var hash = SHA1.HashData(messageBytes);

            return _dsa.SignHash(hash, null);
        }
        public bool VerifyMessage(string message, byte[] signature, HashAlgorithmName hashAlgorithm)
        {
            if (string.IsNullOrEmpty(message) || signature == null)
                throw new ArgumentException("Message and signature cannot be null or empty.");

            var messageBytes = Encoding.UTF8.GetBytes(message);
            var hash = SHA1.HashData(messageBytes);

            return _dsa.VerifyHash(hash, null, signature);
        }

        public string ExportPublicKey()
        {
            return Convert.ToBase64String(_dsa.ExportCspBlob(false));
        }

        public void ImportPublicKey(string base64Key)
        {
            var keyBytes = Convert.FromBase64String(base64Key);
            _dsa.ImportCspBlob(keyBytes);
        }
    }
}
