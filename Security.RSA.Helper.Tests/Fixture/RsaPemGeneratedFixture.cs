using System.Security.Cryptography;
using Xunit;

namespace Security.RSA.Helper.Tests.Fixture
{
    public class RsaPemGeneratedFixture
    {
        public RsaPemGenerated _pem;
        public const string HEADER_PUBLIC_KEY = "-----BEGIN PUBLIC KEY-----";
        public const string FOOTER_PUBLIC_KEY = "-----END PUBLIC KEY-----"; 
        public const string HEADER_PRIVATE_KEY = "-----BEGIN RSA PRIVATE KEY-----";
        public const string FOOTER_PRIVATE_KEY = "-----END RSA PRIVATE KEY-----";
        public RsaPemGeneratedFixture()
        {
            _pem = new RsaPemGenerated(new RSACryptoServiceProvider());
        }
    }
}
