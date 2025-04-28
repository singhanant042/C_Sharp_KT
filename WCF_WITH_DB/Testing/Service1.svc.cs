using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceDB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
         public string InsertUserDetails(UserDetails userinfo)
        {
            string message;
            SqlConnection con = new SqlConnection("Server=HPE-5CG4442NF3\\SQLEXPRESS;Database=WcfTesting;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into employee_table(Username,Password,Country,Email) values(@Username,@Password,@Country,@Email)", con);
            cmd.Parameters.AddWithValue("@Username", userinfo.Username);
            cmd.Parameters.AddWithValue("@Password", userinfo.Password);
            cmd.Parameters.AddWithValue("@Country", userinfo.Country);
            cmd.Parameters.AddWithValue("@Email", userinfo.Email);

            int result = cmd.ExecuteNonQuery();
            if (result==1)
            {
                message = userinfo.Username + "Details inserted successfully";
            }
            else
            {
                message = userinfo.Username + "Details not inserted";
            }
            con.Close();
            return message;


            
        }

    }
}
