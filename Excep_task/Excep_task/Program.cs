using System;
using System.ComponentModel.Design;

namespace taskex
{
    public class EmailValidator
    {
        public static bool Validate(string a)
        {

            if ( a.Length <= 10)
            {
                throw new Exception("Short Email Exception!");
            }

            if (!a.EndsWith("@mail.com"))
            {
                throw new Exception("Not an email adress Exception");
            }

            return true;

       
        }
    }


    class Program
    {

        public static void Main(string[] args)
        {
            EmailValidator val = new EmailValidator();
            

            try
            {
                bool isValid = EmailValidator.Validate("ali.aliyev@mail.com");
                Console.WriteLine(isValid);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

    }



}