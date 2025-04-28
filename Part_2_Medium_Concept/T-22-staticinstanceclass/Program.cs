using System;

class Circle
{
    // static members---> why?-->whenever we create many object and all using some common variable,or methods, and we dont to make copny of that every time a new object is created
    // to avoid that we use static,so that only one copy is created and shared by all instances
    // staic members cannot be invoked using instances,its invoked using class name
    static float PI = 3.147F;
    int radius;

    public Circle(int radius)
    {
        this.radius = radius;
    }

    public float Calculate_area()
    {
        // before make PI as static ,have to use this

        // return this.PI * this.radius * this.radius;

        // after making static,have to use class name
        return Circle.PI * this.radius * this.radius;
    }

    //creating an static method

    public static void print_r()
        {
         //;
        }
}

namespace T_22_staticinstanceclass
{
    internal class Program
    {
        public static void Main()
        {
            Circle C1 = new Circle(2);
            float area1 = C1.Calculate_area();
            Console.WriteLine("Area of the circle={0}", area1);

            Circle.print_r();
            Circle C2 = new Circle(3);
            float area2 = C2.Calculate_area();
            Console.WriteLine("Area of second circle={0}", area2);
        }
    }
}
