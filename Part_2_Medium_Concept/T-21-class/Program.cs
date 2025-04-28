using System;

class customer
{
    string _firstname;
    string _lastname;

    public customer(string fullname, string lastname)
    {
        this._firstname = fullname;
        this._lastname = lastname;
    }

    public void print()
    {
        Console.WriteLine("Customer name is {0}", this._firstname + " " + this._lastname);
    }


}




    class Program
    {
        public  static void Main()
        {
        customer c1 = new customer("Amit","Nath");
        c1.print();
        }
    }

