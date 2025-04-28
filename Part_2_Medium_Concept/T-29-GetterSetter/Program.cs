using System;


public class student
{
    private int _id;
    private string name;
    private int mark;

    public void set_id(int id)
    {
        if (id < 0)
        {
            throw new Exception("Student id cannot be negative");
        }
        this._id = id;
    }

    public int get_id()
    {
        return this._id;
    }

    public void set_name(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Name cannot be null or empty");
        }
    }
    public string get_name()
    {
        // return this.name;
        return string.IsNullOrEmpty(this.name) ? "No name" : this.name;
    }

    public void  set_mark(int mark)
    {
        if(mark <  0 || mark > 100)
        {
            throw new Exception("Invalid data");
        }
        this.mark = mark;
    }

    public int get_mark()
    {
        return this.mark;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        student s1 = new student();
        s1.set_id(1);
        Console.WriteLine(s1.get_id());
        s1.set_name("Anant Singh");
        s1.get_name();
        s1.set_mark(-1);
    }
}

