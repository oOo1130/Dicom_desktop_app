using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Repositories
{
    public static class HashGenerator
    {
        private const int SALT_BYTE_SIZE = 24;
        private const int HASH_BYTE_SIZE = 24;
        private const int PBKDF2_ITERATIONS = 1000;
       
        public static string GenerateSlatedHash(string data, string salt)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(data, salt.GetBytes());
            pbkdf2.IterationCount = PBKDF2_ITERATIONS;
            return pbkdf2.GetBytes(HASH_BYTE_SIZE).Getstring();
        }

        public static string CreateNewSaltValue()
        {
            RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_BYTE_SIZE];
            csprng.GetBytes(salt);
            return salt.Getstring();
        }

        public static string PasswordHash(string password)
        {    
            byte[] _salt,_hash;
            string salt = CreateNewSaltValue();
            //new RNGCryptoServiceProvider().GetBytes(_salt = new byte[SALT_BYTE_SIZE]);
            _hash = new Rfc2898DeriveBytes(password, salt.GetBytes(), PBKDF2_ITERATIONS).GetBytes(HASH_BYTE_SIZE);
            string hash = _hash.Getstring();
            return hash;
       }

        public static string[] GetPasswordHashAndSalt(string password)
        {
            byte[] _salt, _hash;
            string salt = CreateNewSaltValue();
            //new RNGCryptoServiceProvider().GetBytes(_salt = new byte[SALT_BYTE_SIZE]);
            _hash = new Rfc2898DeriveBytes(password, salt.GetBytes(), PBKDF2_ITERATIONS).GetBytes(HASH_BYTE_SIZE);
            string hash = _hash.Getstring();

            string[] arr = new string[3];
            arr[0] = hash;
            arr[1] = salt;

            return arr;
        }

    }
}
