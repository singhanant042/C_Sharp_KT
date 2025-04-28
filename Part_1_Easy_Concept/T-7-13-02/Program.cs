using System;


namespace T_7_13_02
{
     class Program
    {
        static void Main1()
        {
            int? tic_on_sale = null;
            int avl_tic = tic_on_sale ?? 0;
            Console.WriteLine("Available Tickets={0}", avl_tic);
        }
        static void Main(string[] args)
        {
            string name= null;
           //  int i=null
           // above is wrong,integer cannot be a null value
           // but it can be made nullable
           // have to add " ?" after int
           int? i= null;
            Main1();
        }
       
    }
}
