using System;

using Project.TeamA;
using Project.TeamB;

// we can also use namespace alias

//using PA = Project.TeamA;
//using PB = Project.TeamB;


    class Program
    {
       public  static void Main()
        {
        //classA.printA();
        //Project.TeamB.classB.printB();
        // PA.classA.printA();
        // PB.classB.printB();
        Project.TeamA.ClassA.Main();
        Project.TeamB.ClassB.Main();

        }
    }

/*
namespace Project
{
    namespace TeamA
    {
         class classA
        {
             public  static void printA()
            {
                Console.WriteLine("Team A");
            }
        }
    }
    namespace TeamB
    {
        class classB
        {
            public  static void   printB() { 
            Console.WriteLine("Team B");

                }
        }
    }
}
*/