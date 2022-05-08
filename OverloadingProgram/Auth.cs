using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadingProgram
{
    public class Authentication
    {
        public bool LoginUser(string email, string password)
        {
            if (email == "ayaj123@gmail.com" && password == "12345")
            {
                return true;
            }
            return false;
        }
        public bool LoginUser(string mobile)
        {
            if (!string.IsNullOrEmpty(mobile))
            {
                //send otp
                return true ;

            }
            return false ;
        }
    }
}
