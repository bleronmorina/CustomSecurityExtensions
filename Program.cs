using System;
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

            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            byte[] hash = SHA1.Create().ComputeHash(messageBytes);

            return _dsa.SignHash(hash, null); 
        }
        public bool VerifyMessage(string message, byte[] signature, HashAlgorithmName hashAlgorithm)
        {
            if (string.IsNullOrEmpty(message) || signature == null)
                throw new ArgumentException("Message and signature cannot be null or empty.");

            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            byte[] hash = SHA1.Create().ComputeHash(messageBytes);

            return _dsa.VerifyHash(hash, null, signature);
        }

        public string ExportPublicKey()
        {
            return Convert.ToBase64String(_dsa.ExportCspBlob(false));
        }

        public void ImportPublicKey(string base64Key)
        {
            byte[] keyBytes = Convert.FromBase64String(base64Key);
            _dsa.ImportCspBlob(keyBytes);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
