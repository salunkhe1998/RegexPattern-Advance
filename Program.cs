

using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Day24
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("enter your First  name");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter your Last  name");
            string lname = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("enter HOW many emails u want to validate");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter your mail");
                string mail = Console.ReadLine();
                demo d1 = new demo();
                d1.validmail(mail);
            }
            Console.WriteLine();


            Console.WriteLine("enter your mobile number");
            string mb = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter your password ");
            string pwd = Console.ReadLine();
            Console.WriteLine();

            demo d = new demo();
            try
            {
                d.validname(name);
            }
            catch (InvalidException e)
            {
                Console.WriteLine("Oops {0} ! ", e.Message);
            }
        }
    }


    // bool val1 = Regex.IsMatch(name, Reg_pattern1);
    // bool val2 = Regex.IsMatch(lname, Reg_pattern2);
    // bool val3 = Regex.IsMatch(mail, Reg_pattern3);
    //  bool val4 = Regex.IsMatch(mb, Reg_pattern4);
    //bool val5 = Regex.IsMatch(pwd, Reg_pattern5);

    public class demo
    {

        public Regex Reg_pattern1 = new Regex(@"^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex Reg_pattern2 = new Regex(@"^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex Reg_pattern3 = new Regex(@"^[A-Za-z0-9]+([.+-][A-Za-z0-9]+)*@[A-Za-z0-9]+[.][a-z]{2,}([.][a-z]{2,})?$");
        public Regex Reg_pattern4 = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex Reg_pattern5 = new Regex(@"^.*(?=.{8,})(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&+=]).*$");
        public Regex Reg_pattern5_1 = new Regex(@"^[a-zA-Z]{8,}([0-9]+)?$");
        public Regex Reg_pattern5_2 = new Regex(@"^[A-Z]{1,}[a-zA-Z]{7,}([0-9]+)?$");
        public Regex Reg_pattern5_3 = new Regex(@"^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{8,}([0-9]+)?$");
        // public Regex First_Name_Regex = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        // public static string Reg_pattern2 = "^[A-Z]{1}[A-Za-z]{2,}$";
        /* public static string Reg_pattern3 = "^[A-Za-z0-9]+([.+-][A-Za-z0-9]+)*@[A-Za-z0-9]+[.][a-z]{2,}([.][a-z]{2,})?$";
         public static string Reg_pattern4 = "^[0-9]{2}\\s[0-9]{10}$";
         public static string Reg_pattern5 = "^.*(?=.{8,})(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&+=]).*$";
         public static string Reg_pattern5_1 = "^[a-zA-Z]{8,}([0-9]+)?$";
         public static string Reg_pattern5_2 = "^[A-Z]{1,}[a-zA-Z]{7,}([0-9]+)?$";
         public static string Reg_pattern5_3 = "^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{8,}([0-9]+)?$";*/





        // public string validname(string name) => Reg_pattern1.IsMatch(name) ? "First Name is valid" : throw new InvalidException("Invalid First Name\nMinimum length three characters \nFirst letter should be " + "capital");


        public bool validname(string name)
        {

            bool val1 = Reg_pattern1.IsMatch(name);

            if (val1)
            {
                Console.WriteLine("Pattern is correct for given First name: {0}", name);
                return true;
            }

            else
            {
                throw new InvalidException("invalid name");
                Console.WriteLine("pattern First name is wrong");
                return false;
            }
        }


        public bool validlname(string lname)
        {
            bool val2 = Reg_pattern2.IsMatch(lname);
            if (val2)
            {
                Console.WriteLine("Pattern is correct for given Last name: {0}", lname);
                return true;
            }
            else
            {
                Console.WriteLine("pattern Last name is wrong");
                return false;
            }

        }


        public bool validmail(string mail)
        {
            bool val3 = Reg_pattern3.IsMatch(mail);
            if (val3)
            {
                Console.WriteLine("Pattern is correct for given mail ID : {0}", mail);
                return true;
            }
            else
            {
                Console.WriteLine("pattern mail ID  is wrong");
                return false;
            }
        }

        public bool validmobile(string mb)
        {
            bool val4 = Reg_pattern4.IsMatch(mb);
            if (val4)
            {
                Console.WriteLine("Pattern is correct for given mobile number : {0}", mb);
                return true;
            }
            else
            {
                Console.WriteLine("pattern mobile number  is wrong");
                return false;
            }

        }
        public bool validpwd1(string pwd)
        {
            bool val5 = Reg_pattern5_1.IsMatch(pwd);
            if (val5)
            {
                Console.WriteLine("Pattern is correct for given password : {0}", pwd);
                return true;
            }
            else
            {
                Console.WriteLine("pattern password  is wrong");
                return false;
            }
        }
        public bool validpwd2(string pwd)
        {
            bool val5 = Reg_pattern5_2.IsMatch(pwd);
            if (val5)
            {
                Console.WriteLine("Pattern is correct for given password : {0}", pwd);
                return true;
            }
            else
            {
                Console.WriteLine("pattern password  is wrong");
                return false;
            }
        }
        public bool validpwd3(string pwd)
        {
            bool val5 = Reg_pattern5_3.IsMatch(pwd);
            if (val5)
            {
                Console.WriteLine("Pattern is correct for given password : {0}", pwd);
                return true;
            }
            else
            {
                Console.WriteLine("pattern password  is wrong");
                return false;
            }
        }
        public bool validpwd(string pwd)
        {
            bool val5 = Reg_pattern5.IsMatch(pwd);
            if (val5)
            {
                Console.WriteLine("Pattern is correct for given password : {0}", pwd);
                return true;
            }
            else
            {
                Console.WriteLine("pattern password  is wrong");
                return false;
            }
        }
    }
}
