using System;
using System.IO;
public class Custom_class

{
    public static void Main()
    {
        throw new User_custom_class("somthing wrong");
    }
}

public class User_custom_class:Exception
{
    public User_custom_class():base()
    {

    }
    public  User_custom_class(string msg):base(msg)
    {
       
    }

    public User_custom_class(string msg,Exception inner):base(msg,inner)
    {

    }
}

