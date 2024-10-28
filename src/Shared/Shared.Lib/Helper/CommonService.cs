using System.Security.Cryptography;
using System.Text;

namespace Shared.Lib.Helper
{
    public static class CommonService
    {
        public static string EncryptText(string input, string key)
        {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
            TripleDES tripleDES = TripleDES.Create();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string DecryptText(string emailLink, string salt)
        {
            byte[] inputArray = Convert.FromBase64String(emailLink);
            TripleDES tripleDES = TripleDES.Create();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(salt);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        public static string RandomText(int digit = 6)
        {
            try
            {
                Random generator = new();
                return generator.Next(0, 1000000).ToString($"D{digit}");
            }
            catch
            {
                throw;
            }
        }

        public static string CreateRandomPassword()
        {
            int length = 16;
            // Create a string of characters, numbers, special characters that allowed in the password  
            string validCharsSetOne = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
            string validCharsSetTwo = "abcdefghijklmnopqrstuvwxyz";
            string validCharsSetThree = "~=!@#$%^&*_-+";
            string validCharsSetFour = "0123456789";
            Random random = new Random();

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                if (i >= 0 && i <= 3)
                    chars[i] = validCharsSetOne[random.Next(0, validCharsSetOne.Length)];
                else if (i >= 4 && i <= 7)
                    chars[i] = validCharsSetTwo[random.Next(0, validCharsSetTwo.Length)];
                else if (i == 8 || i == 10 || i == 13 || i == 14)
                    chars[i] = validCharsSetThree[random.Next(0, validCharsSetThree.Length)];
                else if (i == 9 || i == 11 || i == 12 || i == 15)
                    chars[i] = validCharsSetFour[random.Next(0, validCharsSetFour.Length)];
            }
            return new string(chars);
        }
    }
}
