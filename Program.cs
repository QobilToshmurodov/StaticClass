using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string orignalText = "Salom hammaga!";
            string base64text=CryptoHelper.Encrypt(orignalText);
            orignalText=CryptoHelper.Decrypt(base64text);
            Console.WriteLine(orignalText);
            Console.WriteLine(base64text);

        }
    }
    public static class CryptoHelper
    {

       public static string Encrypt(string str1)
        {
            string originalText = str1;
            byte[] textBytes = Encoding.UTF8.GetBytes(originalText);
            string base64Text = Convert.ToBase64String(textBytes);
            return base64Text;
        }
        public static string Decrypt(string str2)
        {
            string base64Text = str2;
            byte[] textBytes = Convert.FromBase64String(base64Text);
            string originalText = Encoding.UTF8.GetString(textBytes);
            return originalText;

        }
    }
}
