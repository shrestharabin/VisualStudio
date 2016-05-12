using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    /// <summary>
    /// 
    /// </summary>
    class User
    {
        #region public Members
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        #endregion

        
        //public void Authenticate(string userName = "admin", string password = "password")
        //{
        //    if ((userName == "admin") && (password == "password"))
        //    {
        //        Console.WriteLine("welcome {0} you are logged in as Administrator", userName);
        //    }
        //    else if ((userName == "user") && (Password == "password"))
        //    {
        //        Console.WriteLine("welcome {0} you are logged in as Normal User", userName);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid login");
        //    }
        //}


        //public bool Authenticate(string userName = "admin", string password = "password")
        //{
        //    return
        //    ((userName == "admin") && (password == "password")) || ((userName == "user") && (Password == "password"));
        //}

        //public string Authenticate(string userName = "admin", string password = "password")
        //{
        //    return userName; 
            
        //}

        public string GetUser(string userName = "admin", string password = "password")
        {
            return userName;

        }

    }
}