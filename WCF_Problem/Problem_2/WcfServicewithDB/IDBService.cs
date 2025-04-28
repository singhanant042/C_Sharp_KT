using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDBService
    {

        [OperationContract]
        string Insert(InsertUser user);


        [OperationContract]
        gettestdata GetInfo();

        [OperationContract]
        string Update(UpdateUser u);

        [OperationContract]
        string Delete(DeleteUser d);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
     public class gettestdata
    {
        [DataMember]
        public DataTable employee_table
        {
            get;
            set;
        }
    }
    
    
    
    [DataContract]
    public class InsertUser
    {
        int id;
        string username = "";
        string password = "";
        string country = "";
        string email = "";



        [DataMember]
        public int ID
        {
            get {
                return id;
                    }

            set
            {
                id = value;
            }
        }

        [DataMember]
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value;  }
        }

        [DataMember]
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }

    [DataContract]
    
    public class UpdateUser
    {
        int id;
        string username = "";
        string password = "";
        string country = "";
        string email = "";

        [DataMember]
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        [DataMember]
        public String Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        [DataMember]
        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        [DataMember]

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        [DataMember]

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }


    }

    [DataContract]

    public class  DeleteUser
    {
        int id;

        [DataMember]

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
