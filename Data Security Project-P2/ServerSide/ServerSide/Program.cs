using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Utilities.IO.Pem;

namespace ServerSide
{
    public  class HarshCode
    {
        static string publicKeyFiles = File.ReadAllText(@"C:\Users\freec\Desktop\Data Security Project\publicKey.xml");
       static string privateKeyFiles = File.ReadAllText(@"C:\Users\freec\Desktop\Data Security Project\privateKey.xml");

      
        
        public static string RSAEncrypt(string content)
        {
          // string publickey = @"<RSAKeyValue><Modulus>0wE26IHp4U9OLtPhJ+fT8ej6aWORFP8pd++MjUuhkQQm/zhcImbxQbjxtSAftz+kkDwGDFJpSldQPyigOGcUx7PofTc6VhiFik9E9SsxV9n0iEEtqUndDfmBJfPAWt+4UDMwKakgZqFoapDuwjKlTErFvKCyKCs+qN9OZvZwKWk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
            string publickey = publicKeyFiles;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] cipherbytes;
            rsa.FromXmlString(publickey);
            cipherbytes = rsa.Encrypt(Encoding.UTF8.GetBytes(content), false);

            return Convert.ToBase64String(cipherbytes);

        }