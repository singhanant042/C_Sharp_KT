using System;



    class Program
    {
        static void Main1()
    {
        Console.WriteLine("Welcome_1");
        //this one will not execute,only main is the starting point of the program
        //if u want to run this code too,u have to put this main1() method into the main method
    }
        static void Main()
        {
        Console.WriteLine("Welcome");
        Main1();
        }
    }
