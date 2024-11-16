using CustomSecurityExtensions;
using System.Security.Cryptography;


try
{
    var customDSA = new CustomDSASignature(1024);

    var message = "This is a test message for digital signature.";
    var signature = customDSA.SignMessage(message);

    Console.WriteLine($"Signature: {Convert.ToBase64String(signature)} \r\n");

    var publicKey = customDSA.ExportPublicKey();
    Console.WriteLine($"Public Key: {publicKey} \r\n");

    var verifier = new CustomDSASignature(1024);
    verifier.ImportPublicKey(publicKey);

    var isValid = verifier.VerifyMessage(message, signature);
    Console.WriteLine($"Signature Valid: {isValid}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
