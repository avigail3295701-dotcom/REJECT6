using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace REJECT6
{
    internal class Program
    {
         public static void IsMatch(string message)
        {
            if(string .IsNullOrEmpty(message))
            {
                Console.WriteLine("לא הוזן מספר");
            }
            //1
            Regex reg1 = new Regex(@"^05\d");
            //2
            Regex reg2 = new Regex(@"^abc.*\d$");
            //3
            Regex reg3 = new Regex(@"^color$|^calar$");
            //4
            Regex reg4 = new Regex(@"^[aeiou]*$");
            //5
            Regex reg5 = new Regex(@"^\w{6,10}$");
            //6
            Regex reg6 = new Regex(@"^cat$|^dog$");
            //7
            Regex reg7 = new Regex(@"^\w.+@[gmail.com]|[co.il]$");

            if (reg7.IsMatch(message))
                Console.WriteLine("המחרוזת הינה תקינה");
            else
                Console.WriteLine("המחרוזת אינה תקינה");
        }
        //8
        public static void replace(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("המחרוזת ריקה"); return;
            }
            string newStr = Regex.Replace(str, @"\s+", " ");
            Console.WriteLine(newStr);
        }
        //9
        public static void split(string str1)
        {
            if (string.IsNullOrEmpty(str1))
            { 
                Console.WriteLine("לא הוזן טקסט לפיצול"); return; 
            }
             string[] arr = Regex.Split(str1, @"123");
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            IsMatch("0783295701");
            IsMatch("abcnmjhhn2");
            IsMatch("avi");
            IsMatch("aeiou");
            IsMatch("mkd145_");
            IsMatch("cat");
            IsMatch("avigail3295701@gmail.com");

            string str = "bgdh  ndusi  mjd";
            replace(str);

            string str1 = "1231234561234587123";
            split(str);
        }
    }
}
