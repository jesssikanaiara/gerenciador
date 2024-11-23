using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.IdentityModel.Tokens;

namespace GerenciadorApi.Helpers
{
    public class EncryptHelper
    {
        public static string EncryptPassword(string password)
        {
            byte[] salt = System.Text.UTF8Encoding.UTF8.GetBytes(password);
                
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            
            return hashed;
        }

        public static string GenerateRandomHash()
        {
            return Base64UrlEncoder.Encode(Guid.NewGuid().ToByteArray());
        }
    }
}