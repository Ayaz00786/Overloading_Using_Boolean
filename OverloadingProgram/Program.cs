
using System;

namespace OverloadingProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Authentication auth=new Authentication();

            string mobile = "9340336471";
            string email = "ayaj123@gmail.com";
            string password = "12345";

            Console.WriteLine( auth.LoginUser(email,password));

        }
    }
}
