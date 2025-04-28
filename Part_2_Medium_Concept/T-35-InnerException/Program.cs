using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_35_InnerException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                try
                {
                    Console.WriteLine("Enter the first number");
                    int FN = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number");
                    int SN = int.Parse(Console.ReadLine());

                    int ans = FN / SN;

                    Console.WriteLine("Result={0}", ans);
                }

                catch (Exception ex)
                {

                    string path = @"C:\Users\sinanant\C#\Log_1.txt";
                    if (File.Exists(path))
                    {
                        StreamWriter str = new StreamWriter(path);
                        str.Write(ex.GetType().Name);
                        str.Close();
                        Console.WriteLine("Something wrong");
                    }

                    else
                    {
                        throw new FileNotFoundException(path + " is not present", ex);
                    }

                }
            }
            catch (Exception ex_1)
            {
                Console.WriteLine("Current Exception={0}", ex_1.GetType().Name);
                Console.WriteLine("Inner Exception={0}", ex_1.InnerException.GetType().Name);
            }
        }

    }
}
