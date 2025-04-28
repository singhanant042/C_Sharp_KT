using System;
using System.IO;
namespace T_34_Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader str = null;
            try
            {

                str = new StreamReader(@"C:\Users\sinanant\C#\Data.txt");
                Console.WriteLine(str.ReadToEnd());
                //str.Close();

            }

            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            catch (FileNotFoundException ex)
            {
                //Console.WriteLine(ex.FileName);
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Please check if file {0} exist", ex.FileName);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                if (str != null) { 
                str.Close();
                Console.WriteLine("Checking");
                }
            }
        }
    }
}
