using System.Security.Cryptography;
using System;
namespace Security.RSA.Helper
{
    public class Cryptography : RSABase
    {
        public Cryptography(string pem) : base(pem)
        {
        }

        public Cryptography(string pem, RSAEncryptionPadding padding) : base(pem, padding)
        {
        }

        public string Encrypt(string data)
        {
            var bytes = System.Text.Encoding.Unicode.GetBytes(data);
            return Convert.ToBase64String(Rsa.Encrypt(bytes,Padding));
        }

        public string Decrypt(string data)
        {
            var bytes = Convert.FromBase64String(data);
            return System.Text.Encoding.UTF8.GetString(Rsa.Decrypt(bytes,Padding));
        }
    }
}