using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using LFA.Data;


namespace ConsoleApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
         //---------------------------------------------------------------------------------------------------------------------------------------
            //22May2016
           //insert data through Stored Procedure
            Console.WriteLine("Role Entry Form:");
            Console.WriteLine("--------------------");
            Console.Write("Role Name: ");
            string strRoleName = Console.ReadLine();
            Console.Write("Role Description: ");
            string strRoleDescription = Console.ReadLine();

            string strConn = @"Password=rabin;Persist Security Info=True;User ID=sa;Initial Catalog=LFABlog;Data Source=NLI016A\RSQLSERVER";

            using (SqlConnection conn =new SqlConnection(strConn))
            {
                using (SqlCommand cmd=new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "spSaveRole";
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@RoleId", 0);
                    cmd.Parameters.AddWithValue("@RoleName",strRoleName);
                    cmd.Parameters.AddWithValue("@RoleDescription", strRoleDescription);

                    conn.Open();

                    try
                    {
                        var output = cmd.ExecuteScalar();
                        Console.WriteLine(output);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.ToString());
                    }
                }
                Console.Read();
            }

            
        //---------------------------------------------------------------------------------------------------------------------------------------
            //19May2016
           //OleDbConnection con=new OleDbConnection(); //for universal database connection
            
            SqlConnection conn1 = new SqlConnection(@"Password=rabin;Persist Security Info=True;User ID=sa;Initial Catalog=LFABlog;Data Source=NLI016A\RSQLSERVER");

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection=conn1;
            cmd1.CommandText="Select * from dbo.Roles";
            cmd1.CommandType=CommandType.Text;

            conn1.Open();
            SqlDataReader dr=cmd1.ExecuteReader();
            List<LFARole> lstRoles = new List<LFARole>();

            Console.WriteLine("Role Name \t Role Description");
            Console.WriteLine("--------------------------------------");
            while (dr.Read())
            {
                LFARole objRole = new LFARole();
                objRole.RoleId = int.Parse(dr[0].ToString());
                objRole.RoleName = dr["Rolename"].ToString();
                objRole.RoleDescription = dr[2].ToString();
                lstRoles.Add(objRole);
            }

            foreach (var objRole in lstRoles)
            {
                Console.WriteLine("{0} \t\t {1}", objRole.RoleName, objRole.RoleDescription); 
            }
            //Console.WriteLine(dr["RoleName"]);
            dr.Close();
            conn1.Close();

            Console.Read();
            //------------------------------
            //week3.1
            int y = new int();
            y = 2;
            Console.WriteLine( y.Multiply());

            Console.ReadLine();
            
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
            //string userName=objUser.Authenticate(userName: "admin");

            //if (userName=="admin")
            //{
            //    Console.WriteLine("Welcome {0} ", userName);

            //}
            //else
            //{
            //    Console.WriteLine("Non admin user found!!");
            //}


           // =>>>>>using string Authenticate with multiple returning value
            //string userName=objUser.Authenticate(userName: "admin");

            //if (userName=="admin")
            //{
            //    Console.WriteLine("Welcome {0} ", userName);

            //}
            //else
            //{
            //    Console.WriteLine("Non admin user found!!");
            //}



            BaseClass objBase = new BaseClass();
            objBase.display();

            DerivedOverwrite objDerived = new DerivedOverwrite();
            objDerived.display();

            DerivedOverwrite objDerivedOverwrite = new DerivedOverwrite();

            BaseClass objBaseOverwrite = (BaseClass)objDerivedOverwrite;
            objBaseOverwrite.display();

            DerivedOverride objDerivedOverride = new DerivedOverride();
            BaseClass objBase2 = (BaseClass)objDerivedOverride;
            objBase2.display();

            Console.ReadLine();

            string[] arr = new string[] { "one", "two", "three" };
            Console.WriteLine("Manual Print:");
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine("----------------------");

            Console.WriteLine("Using For Loop:");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("----------------------");

            Console.WriteLine("Using Foreach loop:");
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();



        }
    }
}
