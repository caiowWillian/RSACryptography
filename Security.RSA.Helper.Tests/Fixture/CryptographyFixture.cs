using System;
using System.Security.Cryptography;

namespace Security.RSA.Helper.Tests.Fixture
{
    public class CryptographyFixture
    {
        public Cryptography Private;
        public Cryptography Public;

        public string[] DecryptedTexts = new string[]
        {
            "teste1",
            "teste@#@#$@#$@"
        };

        public string[] EncryptTexts = new string[2];

        public CryptographyFixture()
        {
            var pem = new RsaPemGenerated(new RSACryptoServiceProvider());
            Public = new Cryptography(pem.GetPublicKey(),RSAEncryptionPadding.OaepSHA256);
            Private = new Cryptography(pem.GetPrivateKey(),RSAEncryptionPadding.OaepSHA256);
            Console.WriteLine("*******************************************");
            for(int i = 0; i < DecryptedTexts.Length; i++)
            {
                EncryptTexts[i] = Private.Encrypt(DecryptedTexts[i]);
            }
        }
    }
}