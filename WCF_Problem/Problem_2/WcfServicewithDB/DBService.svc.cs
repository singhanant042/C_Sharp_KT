using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IDBService
    {
        public string Insert(InsertUser user)
        {
            string msg;
            SqlConnection con = new SqlConnection("Server=HPE-5CG4442NF3\\SQLEXPRESS;Database=WcfTesting;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into employee_table(ID,Username,Password,Country,Email) values( @ID,@UserName,@Password,@Country,@Email)", con);


            cmd.Parameters.AddWithValue("@ID", user.ID);
            cmd.Parameters.AddWithValue("@Username", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Country", user.Country);
            cmd.Parameters.AddWithValue("@Email", user.Email);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                msg = "Data inserted successfully";

            }
            else
            {
                msg = "Data insertion fail";
            }
            con.Close();
            return msg;

        }

        public gettestdata GetInfo()
        {
            gettestdata g = new gettestdata();
            SqlConnection con = new SqlConnection("Server=HPE-5CG4442NF3\\SQLEXPRESS;Database=WcfTesting;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserTab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("employee_table");
            da.Fill(dt);
            g.employee_table = dt;
            return g;

        }


        public string Update(UpdateUser u)
        {
            string msg = "";
            SqlConnection con = new SqlConnection("Server=HPE-5CG4442NF3\\SQLEXPRESS;Database=WcfTesting;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE employee_table SET username=@Username, password=@Password, country=@Country, email=@Email WHERE id=@ID", con);


            cmd.Parameters.AddWithValue("@ID", u.ID);
            cmd.Parameters.AddWithValue("@Username", u.Username);
            cmd.Parameters.AddWithValue("@Password", u.Password);
            cmd.Parameters.AddWithValue("@Country", u.Country);
            cmd.Parameters.AddWithValue("@Email", u.Email);

            int result = cmd.ExecuteNonQuery();
            if(result==1)
            {
                msg = "Updated Successfully";
            }
            else
            {
                msg = "Failed";
            }
            con.Close();
            return msg;

        }


        public string Delete(DeleteUser d)
        {
            string msg = "";
            SqlConnection con = new SqlConnection("Server=HPE-5CG4442NF3\\SQLEXPRESS;Database=WcfTesting;Integrated Security=True;");
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete employee_table where id=@ID",con);

            cmd.Parameters.AddWithValue("@ID", d.ID);


            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                msg = "Delete Successfully";
            }
            else
            {
                msg = "Failed";
            }
            con.Close();
            return msg;
        }
    }
}
