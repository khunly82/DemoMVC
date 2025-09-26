using System.Security.Cryptography;
using System.Text;

namespace DemoMVC.Utils
{
    public static class PasswordUtils
    {

        public static string Hash(string password)
        {
            // 36 char
            string salt = Guid.NewGuid().ToString();

            byte[] hash = SHA512.HashData(Encoding.UTF8.GetBytes(salt + password));

            return salt + Convert.ToBase64String(hash);
        }

        public static string Hash(string password, string salt)
        {
            byte[] hash = SHA512.HashData(Encoding.UTF8.GetBytes(salt + password));

            return salt + Convert.ToBase64String(hash);
        }

        public static bool Verify(string password, string hashPassword) 
        {
            string salt = hashPassword[..36];

            byte[] hash = SHA512.HashData(Encoding.UTF8.GetBytes(salt + password));

            return Convert.ToBase64String(hash) == hashPassword[36..];
        }
    }
}
