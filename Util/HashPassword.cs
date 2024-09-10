using Dental_Clinic.Models;

namespace Dental_Clinic.Util
{
    public static class HashPassword
    {
        public static string EncryptPassword(string password)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            return passwordHash;
        }

        public static bool PasswordIsValid(string passwordHash, string password)
        {
            return !BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }
    }
}
