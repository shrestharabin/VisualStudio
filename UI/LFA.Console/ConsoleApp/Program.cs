using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            User objUser = new User();

            //int userID = objUser.UserID;
            //string userName = objUser.UserName;
            //string password = objUser.Password;

            //if (userName == "admin")
            //{

            //}

            //objUser.UserID = 1;
            //objUser.UserName = "rabin";
            //objUser.Password = "password";

            //int count = 1;
            //var count2 = count;
            //count2 = 2;

            //var objNewUser = objUser;
            //objNewUser.UserName = "admin";

            //Console.WriteLine(objUser.UserID);
            //Console.WriteLine(objUser.UserName);
            //Console.WriteLine(objUser.Password);

            //Console.WriteLine("The value of count is {0}", count);
            //Console.WriteLine("The value of count2 is {0}", count2);

            //=>>>>>using void Authenticate
            //objUser.Authenticate();
           // objUser.Authenticate(password:"test");

           
            //=>>>>>using bool Authenticate

            //if (objUser.Authenticate(userName: "test"))
            //{
            //    Console.WriteLine("True");
                
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            //=>>>>>using string Authenticate
            string userName=objUser.Authenticate(userName: "admin");

            if (userName=="admin")
            {
                Console.WriteLine("Welcome {0} ", userName);

            }
            else
            {
                Console.WriteLine("Non admin user found!!");
            }

            Console.ReadLine();



        }
    }
}
