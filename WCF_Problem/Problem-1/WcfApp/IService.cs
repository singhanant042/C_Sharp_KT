using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        void Write_file(string path,string content);




        [OperationContract]
        string get_content(string msg);

        [OperationContract]
        string get_path(string path);

        [OperationContract]
        string  Read_file(string path);
       
    }

}
