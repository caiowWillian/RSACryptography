# RSACryptography
It is a library to facilitate the use of RSA: System.Security.Cryptography

## What the libary makes?
- Generated RSA public key in pem format
- Generated RSA private key in pem format
- Encrypt a string
- Decrypt a string

## How to install
to add the package you have two optins

- Add using nuget
- clone this repository

#### using nuget you execute this command in your project
```c#
dotnet add package Security.RSA.Helper --version 1.0.0
```

#### install cloning this repository
clone repository
```c#
git clone https://github.com/caiowWillian/RSACryptography.git
```
add the reference in your .csproj
```c#
dotnet add reference <yourpath>/Security.RSA.Helper.csproj
```

## How I test my library
I have unit tests in <a href="https://github.com/caiowWillian/RSACryptography/tree/main/Security.RSA.Helper.Tests">Recurity.RSA.Helper.Tests</a>

To run unit tests using in Security.RSA.Helper.Tests
```c#
dotnet test
```

## generating keys
```c#
var _pem = new RsaPemGenerated(new RSACryptoServiceProvider())
var publicKey = _pem.GetPublicKey();
var privateKey = _pem.GetPrivateKey()
```
## Encrypting and Decrypting
```c#
var public = new Cryptography(pem.GetPublicKey(),RSAEncryptionPadding.OaepSHA256);
var private = new Cryptography(pem.GetPrivateKey(),RSAEncryptionPadding.OaepSHA256);

var encryptData = public.Encrypt(data);
var decryptDAta = private.Decrypt(encryptData);
```
