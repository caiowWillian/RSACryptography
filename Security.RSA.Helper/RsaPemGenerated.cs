using System.Security.Cryptography;

namespace Security.RSA.Helper
{
    public class RsaPemGenerated
    {
        private RSACryptoServiceProvider _provider;
        
        public RsaPemGenerated(RSACryptoServiceProvider provider)
        {
            _provider = provider;
        }

        public string GetPublicKey()
        {
            return PemGeneratedUtil.ExportPublicKey(_provider);
        }

        public string GetPrivateKey()
        {
            return PemGeneratedUtil.ExportPrivateKey(_provider);
        }

    }
}