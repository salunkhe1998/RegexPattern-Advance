using System.Text.RegularExpressions;

namespace Day24
{
    class Program
    {
        public static string Reg_pattern = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Reg_pattern2 = "^[A-Z]{1}[A-Za-z]{2,}$";

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your First name : ");
            string Firstname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter your Last name : ");
            string Lastname = Console.ReadLine();
            Console.WriteLine();
            bool val1 = Regex.IsMatch(Firstname, Reg_pattern);
            bool val2 = Regex.IsMatch(Lastname, Reg_pattern2);

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
                Console.WriteLine("pattern is wrong");
        }
    }
}

