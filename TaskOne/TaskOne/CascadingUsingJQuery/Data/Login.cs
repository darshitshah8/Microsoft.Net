using CascadingUsingJQuery.Models;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace CascadingUsingJQuery.Data
{
    public class Login
    {
        private readonly IConfiguration _config;

        public Login(IConfiguration config)
        {
            _config = config;
        }
        public bool SignInAccount(UserModel acc, HttpContext httpContext)
        {
            bool isLoginSuccessful = false;

            using (SqlConnection con = new SqlConnection(_config.GetConnectionString("UserConnection")))
            {
                con.Open();
                // Check if username and password match in the database
                SqlCommand checkUserCmd = new SqlCommand("SELECT Count(*) FROM Users WHERE UserName = @UserName AND Password = @Password", con);
                checkUserCmd.Parameters.AddWithValue("@UserName", acc.UserName);
                checkUserCmd.Parameters.AddWithValue("@Password", Encrypt(acc.Password));

                try
                {
                    int userCount = Convert.ToInt32(checkUserCmd.ExecuteScalar());

                    if (userCount != 0)
                    {
                        httpContext.Session.SetString("UserName", acc.UserName.ToString());
                        isLoginSuccessful = true;  // Username and password match
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return isLoginSuccessful;
        }
        public int SignUpAccount(UserModel acc)
        {
            string connectionString = _config.GetConnectionString("UserConnection");


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("InsertUser", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@UserName", acc.UserName);
                com.Parameters.AddWithValue("@Email", acc.Email);
                com.Parameters.AddWithValue("@Password", Encrypt(acc.Password));
                int i = com.ExecuteNonQuery();
                return i;
            }
        }
        private string Encrypt(string clearText)
        {
            string encryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }

            return clearText;
        }
        private string Decrypt(string cipherText)
        {
            string encryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }

            return cipherText;
        }
    }
}
