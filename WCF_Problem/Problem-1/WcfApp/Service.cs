using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;

namespace WcfApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in both code and config file together.
    public class Service : IService
    {
        private string content;
        private string file_path;
        public string get_content(string msg)
        {
            content = msg;
            return content;
        }

       public string get_path(string path)
        {
            file_path = path;
            return file_path;
        }
        public void Write_file(string path,string content)
        {
            //Console.WriteLine("Enter the content to write in File");
            //string content = Console.ReadLine();

            if (File.Exists(path)){

                using (StreamWriter str = new StreamWriter(path))
                {
                    str.Write(content);
                }
            }
            else
            {
                throw new Exception("File does not exists");
            }
        }

        public string Read_file(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader str = new StreamReader(path))
                {
                   return str.ReadToEnd();  
                }
            }
            else
            {
                return "File does not exist";
            }
        }

    }
}
