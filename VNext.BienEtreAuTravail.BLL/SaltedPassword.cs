using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
namespace VNext.BienEtreAuTravail.BLL
{
    public class SaltedPassword
    {

       
        
        public const int SALT_BYTE_SIZE = 24;
        public const int HASH_BYTE_SIZE = 24;
        public int PBKDF2_ITERATIONS = DateTime.Now.Year;

        public const int ITERATION_INDEX = 0;
        public const int SALT_INDEX = 1;
        public const int PBKDF2_INDEX = 2;


        public string CreateHash(string password)
        {
            // Generate a random salt
            RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_BYTE_SIZE];
            csprng.GetBytes(salt);
            Rfc2898DeriveBytes PBKDF2 = new Rfc2898DeriveBytes(password, salt, PBKDF2_ITERATIONS);
            // Hash the password and encode the parameters
            byte[] hash = PBKDF2.GetBytes(HASH_BYTE_SIZE);
            //{ 0, 16, 104, 210, 16, 104, 210, 16, 104, 210, 16, 104, 210, 16, 104, 21 };
            return PBKDF2_ITERATIONS + ":" +
                Convert.ToBase64String(salt) + ":" +
                Convert.ToBase64String(hash);
        }

        public bool ValidatePassword(string password, string correctHash)
        {
            // Extract the parameters from the hash
            
            char[] delimiter = { ':' };
            string[] split = correctHash.Split(delimiter);
            int iterations = int.Parse(split[ITERATION_INDEX]);
            byte[] salt = Convert.FromBase64String(split[SALT_INDEX]);
            byte[] hash = Convert.FromBase64String(split[PBKDF2_INDEX]);
            Rfc2898DeriveBytes PBKDF2 = new Rfc2898DeriveBytes(password, salt, PBKDF2_ITERATIONS);

            byte[] testHash = PBKDF2.GetBytes(hash.Length);
           int y = PBKDF2.Salt.GetHashCode();

            return SlowEquals(hash, testHash);
        }
        private static bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
                diff |= (uint)(a[i] ^ b[i]);
            return diff == 0;
        }
   /*     private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            pbkdf2.IterationCount = iterations;
            Console.WriteLine(Convert.ToBase64String(pbkdf2.GetBytes(outputBytes)));
            return pbkdf2.GetBytes(outputBytes);
        }
*/

    }
}
