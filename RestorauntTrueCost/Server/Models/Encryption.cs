using System.Security.Cryptography;
using System.Text;

namespace RestorauntTrueCost.Server.Models
{
    public class Encryption
    {
        public static string Encrypt(string password)
        {
            var provider = MD5.Create();
            string salt = "s0m3R@nd0msalt";
            byte[] bytes = provider.ComputeHash(Encoding.UTF8.GetBytes(salt + password));
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }
    }
}
