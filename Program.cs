

using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Day24
{
    class Program
    {
        public static string Reg_pattern = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Reg_pattern2 = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Reg_pattern3 = "^(abc)(.[A-Za-z]+)*@(bl).(co)([.][a-z]{2,})?$";
        public static string Reg_pattern4 = "^[0-9]{2}\\s[0-9]{10}$";



        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your First name : ");
            string Firstname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter your Last name : ");
            string Lastname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter your Email ID: ");
            string Email = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter your Mobile Number: ");
            string Mobileno = Console.ReadLine();
            Console.WriteLine();

            bool val1 = Regex.IsMatch(Firstname, Reg_pattern);
            bool val2 = Regex.IsMatch(Lastname, Reg_pattern2);
            bool val3 = Regex.IsMatch(Email, Reg_pattern3);
            bool val4 = Regex.IsMatch(Mobileno, Reg_pattern4);


            if (val1)
            {
                Console.WriteLine("Pattern is correct for given First name: {0}", Firstname);
            }
            else
                Console.WriteLine("pattern is wrong");

            if (val2)
            {
                Console.WriteLine("Pattern is correct for given Last name: {0}", Lastname);
            }
            else
                Console.WriteLine("pattern Last name is wrong");


            if (val3)
            {
                Console.WriteLine("Pattern is correct for given mail ID : {0}", Email);
            }
            else
                Console.WriteLine("pattern mail ID  is wrong");

            if (val4)
            {
                Console.WriteLine("Pattern is correct for given mobile number : {0}", Mobileno);
            }
            else
                Console.WriteLine("pattern mobile number  is wrong");
        }
    }
}



