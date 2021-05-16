using System.Text.RegularExpressions;
using Security.RSA.Helper.Tests.Fixture;
using Xunit;

namespace Security.RSA.Helper.Tests
{
    public class CryptographyTests : IClassFixture<CryptographyFixture>
    {
        
        private CryptographyFixture _cryptography;

        public CryptographyTests(CryptographyFixture cryptography)
        {
            _cryptography = cryptography;
        }

        private bool IsBase64(string base64)
        {
            base64 = base64.Trim();
            return (base64.Length % 4 == 0) && Regex.IsMatch(base64, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);
        }

        [Theory()]
        [InlineData("teste123")]
        [InlineData("teste@#!@#!")]
        public void EncryptTest(string data)
        {
            Assert.True(IsBase64(_cryptography.Public.Encrypt(data)));
        }

        [Fact]
        public void DecryptTest()
        {
           string decry;
           string txt;
           for(int i = 0; i < _cryptography.EncryptTexts.Length; i++)
           {
                decry = _cryptography.Private.Decrypt(_cryptography.EncryptTexts[i]);
                txt = _cryptography.DecryptedTexts[i];
                Assert.True(txt.CompareTo(decry) == 0);
           }          
        }
    }
}