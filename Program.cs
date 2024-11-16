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
            try
            {
                // Create a new instance of CustomDSASignature
                var customDSA = new CustomDSASignature(1024);

                // Sign a message
                string message = "This is a test message for digital signature.";
                byte[] signature = customDSA.SignMessage(message, HashAlgorithmName.SHA1);

                Console.WriteLine($"Signature: {Convert.ToBase64String(signature)} \r\n");

                // Export the public key
                string publicKey = customDSA.ExportPublicKey();
                Console.WriteLine($"Public Key: {publicKey} \r\n");

                // Verify the signature with a new instance (using the public key)
                var verifier = new CustomDSASignature(1024);
                verifier.ImportPublicKey(publicKey);

                bool isValid = verifier.VerifyMessage(message, signature, HashAlgorithmName.SHA1);
                Console.WriteLine("Signature Valid: " + isValid);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
