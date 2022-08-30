using System;
namespace SameMethod
{
    public class A
    {
    public int add(int x, int y)
    {
       return x + y;
    }

     }
    public class B:A
    {

    public int add(int x, int y)
    {
        return x + y;
    }

    }
    class Test
    {

    
        static void Main(string[] args)
        {
           A b = new A();
           A a = new B();
           int e = b.add(8,15);
           int f = a.add(7,5);
           Console.WriteLine(e + " " + f);


        }
}
}   