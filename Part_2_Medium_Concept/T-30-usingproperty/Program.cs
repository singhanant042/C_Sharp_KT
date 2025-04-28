using System;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Xml.Schema;

public class student
{
    private int id;
    private string name;
    private int age=25;

    // we can also use auto implemented property
    public string Email
    {
        get;
        set;
    }
    public int Age
    {
     

        get
        {
            return this.age;
        }
    }
    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be null");
            }
            this.name = value;
        }

        get
        {
            return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
        }
    }

    public int ID
    {
        set
        {
            if (value<0)
            {
                throw new Exception("Id cannot be negative");
            }
            this.id = value; 
        }

        get
        {
            return this.id;
        }
    
    }

   
}

namespace T_30_usingproperty
{
    internal class Program
    {
        static void Main(string[] args)
        {

            student s1 = new student();
         
            s1.ID = 2;
            s1.Email = "anantsingh@gmail.com";
            Console.WriteLine(s1.Email);
            s1.Name = "Anant Singh";
            Console.WriteLine("Name is {0}",s1.Name);
            Console.WriteLine("ID={0}", s1.ID);
            student s2 = new student();
            s2.ID = 4 ;
            Console.WriteLine("ID={0}", s2.ID);
            s2.Name = null;
            Console.WriteLine("Name is {0}",s2.Name);
           
        }
    }
}
