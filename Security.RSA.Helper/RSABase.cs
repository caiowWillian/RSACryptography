using System.Security.Cryptography;

namespace Security.RSA.Helper
{
    public abstract class RSABase
    {
        protected RSAEncryptionPadding Padding;
        protected System.Security.Cryptography.RSA Rsa = System.Security.Cryptography.RSA.Create(); 
        public RSABase(string pem)
        {
            this.Padding = RSAEncryptionPadding.OaepSHA1;
            Rsa.ImportFromPem(pem.ToCharArray());

        }

        public RSABase(string privateKey,string publicKey, RSAEncryptionPadding padding)
        {
            this.Padding = padding;
            Rsa.ImportFromPem(privateKey);
            Rsa.ImportFromPem(publicKey);
        }

        public RSABase(string pem, RSAEncryptionPadding padding)
        {
            this.Padding = padding;
            Rsa.ImportFromPem(pem.ToCharArray());
        }
    }
}