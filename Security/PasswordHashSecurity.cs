
using System.Security.Cryptography;
using System.Text;

namespace SanAndres_Api.Security
{
  public static class PasswordHashSecurity
  {
    public static string HashPassword(string password, Guid saltGuid)
    {
      using (var sha256 = SHA256.Create())
      {
        var saltBytes = saltGuid.ToByteArray();
        var combinedBytes = new byte[saltBytes.Length + password.Length];

        Array.Copy(saltBytes, combinedBytes, saltBytes.Length);
        Array.Copy(Encoding.UTF8.GetBytes(password), 0, combinedBytes, saltBytes.Length, password.Length);

        var hashedBytes = sha256.ComputeHash(combinedBytes);
        return Convert.ToBase64String(hashedBytes);
      }
    }


    public static bool VerifyPassword(string storedPassword, string inputPassword, Guid saltGuid)
    {
      var hashedInputPassword = HashPassword(inputPassword, saltGuid);
      return hashedInputPassword == storedPassword;
    }
  }
}
