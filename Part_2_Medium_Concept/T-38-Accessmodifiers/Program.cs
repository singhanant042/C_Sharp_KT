using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class _base
{
    protected int id;
}

public class derived : _base
{
    public void print()
    {
        //derived d = new derived();
        //d.id = 10;

        this.id = 2;

    }
}
public class  Mainclass
{
    public static void Main()
    {

    }
}