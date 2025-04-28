using System;
using System.IO;

public class Enums
{
    public static void Main()
    {
         int[] value= (int[])Enum.GetValues(typeof(Gender));
        foreach(int i in value)
        {
            Console.WriteLine(i);
        }

           string[] Name=Enum.GetNames(typeof(Gender));
        foreach(string s in Name)
        {
            Console.WriteLine(s);
        }

    }
}

public enum Gender
{
    Unknown,
    Male=45,
    Female,
}
