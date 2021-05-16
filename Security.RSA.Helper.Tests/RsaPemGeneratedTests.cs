using Security.RSA.Helper.Tests.Fixture;
using Xunit;

namespace Security.RSA.Helper.Tests
{
    public class RsaPemGeneratedTests : IClassFixture<RsaPemGeneratedFixture>
    {
        private RsaPemGeneratedFixture _rsaPemGeneratedFixture;

        public RsaPemGeneratedTests(RsaPemGeneratedFixture rsaPemGeneratedFixture)
        {
            _rsaPemGeneratedFixture = rsaPemGeneratedFixture;
        }

        [Fact]
        public void GetPublicKeyTest()
        {
            string publicKey = _rsaPemGeneratedFixture._pem.GetPublicKey();
            Assert.Contains(RsaPemGeneratedFixture.HEADER_PUBLIC_KEY,publicKey);
            Assert.Contains(RsaPemGeneratedFixture.FOOTER_PUBLIC_KEY,publicKey);
        }

        [Fact]
        public void GetPrivateKeyTest()
        {
            string privateKey = _rsaPemGeneratedFixture._pem.GetPrivateKey();

            Assert.Contains(RsaPemGeneratedFixture.HEADER_PRIVATE_KEY,privateKey);
            Assert.Contains(RsaPemGeneratedFixture.FOOTER_PRIVATE_KEY,privateKey);
        }
    }
}
