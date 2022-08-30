// Q16 : program to implement multiple interfaces in the same class
// using System;
// namespace interFace
// {
//     interface inf1
//     {
//         void Method1();
//     }
//     interface inf2
//     {
//         void Method2();
//     }

//     class imp:inf1,inf2
//     {
//         public void Method1()
//         {
//             Console.WriteLine("Interface inf1  Method");
//         }
//         public void Method2()
//         {
//             System.Console.WriteLine("Interface inf2 Method");
//         }
//     }
// class program
// {
//     static void Main()
//     {
//           imp i = new imp();
//           i.Method1();
//           i.Method2();
//           inf1 j = new imp();
//           j.Method1();

//     }
  
// }
// }




// Q 17: C# program to implement multiple interfaces with the same method in the same class

// using System;
// namespace interFace
// {
//     interface inf1
//     {
//         void Method1();
//     }
//     interface inf2
//     {
//         void Method1();
//     }

//     class imp:inf1,inf2
//     {
//          void inf2.Method1()
//         {
//             Console.WriteLine("Interface inf1  Method");
//         }
//          void inf1.Method1()
//         {
//             System.Console.WriteLine("Interface inf2 Method");
//         }
//     }
// class program
// {
//     static void Main()
//     {
//         inf1 i = new imp();
//         inf2 j = new imp();
//         i.Method1();
//         j.Method1();
//     }
  
// }
// }


//  Q:18 interface implementation with multi-level inheritence 

// using System;
// namespace interFace
// {
//     interface inf1
//     {
//         void Method1();
//     }
//     interface inf2 :inf1
//     {
//         void Method2();
//     }

//     class imp:inf2
//     {
//          public void Method1()
//         {
//             Console.WriteLine("Interface inf1  Method");
//         }
//         public void Method2()
//         {
//             System.Console.WriteLine("Interface inf2 Method");
//         }
//     }
// class program
// {
//     static void Main()
//     {
//         inf1 i = new imp();
//         inf2 j = new imp();
//         i.Method1();
//         j.Method2();
//     }
  
// }
// }




// Q:19 implement interface in structure  

// using System;
// namespace interFace
// {
//     interface inf1
//     {
//         void Method1();
//     }
//     interface inf2 :inf1
//     {
//         void Method2();
//     }

//     struct imp:inf2
//     {
//           void inf1.Method1()
//         {
//             Console.WriteLine("Interface inf1  Method");
//         }
//          void inf2.Method2()
//         {
//             Console.WriteLine("Interface inf2 Method");
//         }
//     }
// class program
// {
//     static void Main()
//     {
//         inf1 i = new imp();
//         inf2 j = new imp();
//         i.Method1();
//         j.Method2();
//     }
  
// }
// }



// Q:20  C# program to implement multiple-inheritance using the interface

// using System;
// namespace interFace
// {
//     interface inf1
//     {
//         void Method1();
//     }
//     class A:inf1
//     {
//         public void Method1()
//         {
//             Console.WriteLine("Interface inf1  Method");
//         }
//     }
//     interface inf2
//     {
//         void Method2();
//     }

//     class B:inf2
//     {
//         public void Method2()
//         {
//             Console.WriteLine("Interface inf2 Method");
//         }

//     }

//     class imp:inf1,inf2
//     {
//         A i = new A();
//         B j = new B();
       

//          public void Method1()
//         {
            
//             i.Method1();
//         }
//         public void Method2()
//         {       
//              j.Method2();
//         }
//     }
// class program
// {
//     static void Main()
//     {
//         imp i = new imp();
//         i.Method1();
//         i.Method2();
        
//     }     
        
// }
// }






// Q21:  C# program to implement hierarchical inheritance using the interface

// using System;
// namespace interFace
// {
//     interface inf1
//     {
//         void Method1();
//     }
//     class A:inf1
//     {
//         public void Method1()
//         {
//             Console.WriteLine(" Class A: Interface inf1  Method");
//         }
//     }
//         class B:inf1
//     {
//         public void Method1()
//         {
//             Console.WriteLine(" Class B: Interface inf1Method");
//         }

//     }

// class program
// {
//     static void Main()
//     {
//         A a = new A();
//         B b = new B();
//         a.Method1();
//         b.Method1();
//     }     
        
// }
// }



// Q22://C# program to implement the same abstract method 
//in multiple classes.

// using System;

// abstract class Abs
// {
//     //Method Declaration
//     public abstract void Method();
// }

// class Sample1 : Abs
// {
//     //Method definition
//     public override void Method()
//     {
//         Console.WriteLine("Sample1:Method() called");
//     }
// }

// class Sample2 : Abs
// {
//     //Method definition
//     public override void Method()
//     {
//         Console.WriteLine("Sample2:Method() called");
//     }
// }


// class Program
// {
//     public static void Main(String[] args)
//     {
//         Abs M;

//         M = new Sample1();
//         M.Method();

//         M = new Sample2();
//         M.Method();
//     }
// }






//C# program to implement multiple-inheritance 
//using abstract class and interface

// using System;

// abstract class Abs1
// {
//     //Method Declaration
//     public abstract void Method1();
// }

// //Parent class 1
// class Sample1 : Abs1
// {
//     public override void Method1()
//     {
//         Console.WriteLine("Method1() called");
//     }
// }

// interface MyInf2
// {
//     //Method Declaration
//     void Method2();
// }

// //Parent class 2
// class Sample2 : MyInf2
// {
//     public void Method2()
//     {
//         Console.WriteLine("Method2() called");
//     }
// }

// class Sample3 : Sample1, MyInf2
// {
//     Sample1 S1 = new Sample1();
//     Sample2 S2 = new Sample2();

//     public void Method1()
//     {
//         S1.Method1();
//     }

//     public void Method2()
//     {
//         S2.Method2();
//     }
// }

// class Program
// {
//     public static void Main(String[] args)
//     {
//         Sample3 S = new Sample3();

//         S.Method1();
//         S.Method2();
//     }
// }



// C# program to demonstrate the use of reflection 
//to get namespace and base type.

// using System;
// using System.Reflection;

// class RefDemo
// {
//     static void Main()
//     {
//         Type type;
        
//         type = typeof(Int64);
//         Console.WriteLine("Data Type Name : "+ type.Name        );
//         Console.WriteLine("Full Type Name : "+ type.FullName    );
//         Console.WriteLine("Namespace      : "+ type.Namespace   );
//         Console.WriteLine("Base Type      : "+ type.BaseType    );
//     }
// }





//C# program to demonstrate indexer overloading.

// using System;

// class IndexOver
// {
//     int [] arr = new int[3];
//     public int this[int index]
//     {
//         get
//         {
//             return arr[index];
//         }

//         set
//         {
//             arr[index] = value;
//         }
//     }


//     public int this[float index]
//     {

//         get
//         {
//             return arr[2];
//         }

//         set
//         {
//             arr[2] = value;
//         }
//     } 

//     static void Main(string[] args)
//     {
//         IndexOver Ob = new IndexOver();

//         Ob[0] = 10;
//         Ob[1] = 20;

//         //Float indexer called
//         Ob[1.2F] = 30;

//         Console.WriteLine("Ob[0]     :" + Ob[0]     );
//         Console.WriteLine("Ob[1]     :" + Ob[1]     );
//         Console.WriteLine("Ob[1.2F]  :" + Ob[1.2F]  );
//     }
// }






//C# Program to call math operations using delegates.

// using System;

// delegate int MyDel(int num);

// public class MathClass
// {
//     public static int Qube(int num)
//     {
//         return num*num*num;
//     }

//     public static int Square(int num)
//     {
//         return num*num;
//     }
// }

// class Sample 
// {
//     static void Main()
//     {
//         MyDel[] opers = { MathClass.Square,MathClass.Qube};
//         int result = 0;

//         for (int i = 0; i < opers.Length; i++)
//         {
//             result = opers[i](10);
//             Console.WriteLine("Operation[{0}]:", i);
//             Console.WriteLine("\tResult: "+result);
//         }
//     }
// }



//C# program to demonstrate the Enum

// using System;

// enum COLOR
// {
//     RED,GREEN,YELLOW,BLACK,WHITE, BLUE
// }

// class EnumDemo
// {
//     static void PrintColor(COLOR color)
//     {
//         switch (color)
//         { 
//             case COLOR.RED:
//                 Console.WriteLine("Color is Red,    value: "+COLOR.RED);
//                 break;
//             case COLOR.GREEN:
//                 Console.WriteLine("Color is Green,  value: " + COLOR.GREEN);
//                 break;
//             case COLOR.YELLOW:
//                 Console.WriteLine("Color is Yellow, value: " + COLOR.YELLOW);
//                 break;
//             case COLOR.BLACK:
//                 Console.WriteLine("Color is Black,  value: " + COLOR.BLACK);
//                 break;
//             case COLOR.WHITE:
//                 Console.WriteLine("Color is White,  value: " + COLOR.WHITE);
//                 break;
//             case COLOR.BLUE:
//                 Console.WriteLine("Color is Blue,   value: " + COLOR.BLUE);
//                 break;
//         }
//     }
//     static void Main(string[] args)
//     {
//         PrintColor(COLOR.RED    );
//         PrintColor(COLOR.GREEN  );
//         PrintColor(COLOR.BLUE   );
//     }
// }


//Q: Dynamic Polymorphism

// namespace Area
// {


// class Shape
// {
//     protected int width = 0;
//     protected int height = 0;
//     protected int area = 0;
//     public virtual void Area(int height, int width)
//     {
//         area = width*height;
//         Console.WriteLine("Shape Class Area:" + area);
//     }
// }

// class Rectangle : Shape
// {
//         public override void Area(int height, int width)
//         {
//             this.height=height;
//             this.width=width;
//             area= width*height;
//             Console.WriteLine("Rectangle Class Area:" + area);
//         }
// }
// class Triangle : Shape
// {
//             public override void Area(int height, int width)
//         {
//             this.height=height;
//             this.width=width;
//             area= width*height/2;
//             Console.WriteLine("Triangle Class Area:" + area);
//         }
// }

// class test
// {
//     static void Main()
//  {
//     Triangle t = new Triangle();
//     Rectangle r = new Rectangle();
//     r.Area(10,5);
//     t.Area(5,10);
// }
// }
// }


// namespace Area
// {


// public class IndexOver
// {
// public int [] arr = new int[5];

// public int this[int index]
// {
//     get
//     {
//       return arr[index];
//     }
//     set
//     {
//       arr[index] = value;
//     }
// }


// public int this[float index]
// {
//     get
//     {
//       return arr[2];
//     }
//     set
//     {
//       arr[2] = value;
//     }
// }

//     static void Main()
// {
//     IndexOver a = new IndexOver();
//     a[0]=10; 
//     a[1.2F]=25;
//     System.Console.WriteLine(a[0]);
//     System.Console.WriteLine(a[1.2F]);
// }
// }
// }



// multiple inheritense using abstract and interface
// namespace Inheritense
// {
//     interface inf
//     {
//         void hello();

//     }

//     public abstract class abs
//     {
//       public abstract void bye();
//     }

//     public class Inherit:abs,inf
//     {
//         public void hello()
//         {
//             System.Console.WriteLine("Hello");
//         }
//         public override void bye()
//         {
//             System.Console.WriteLine("Bye");
//         }
//     }

// public class test
// {
// static void Main()
// {
//     Inherit i = new Inherit();
//     i.hello();
//     i.bye();
// }
// }
// }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System. Threading. Tasks;

namespace Basic_Example
{
  class Program
{
    static void Main(string[] args)
{
Scooter sc = new Scooter();
sc.ScooterType();
Car c = new Car();
c.CarType();
}
}
class Tyre
{
protected void TyreType()
{
Console.WriteLine("This is Tubeless Tyre");
}
}
class Scooter: Tyre
{
public void ScooterType() 
{
Console.WriteLine("Scooter Color is Red");
TyreType();
}
}
class Car:Tyre
{
public void CarType()
{
Console.WriteLine("Car Type: Ferrari");
TyreType();
}
}
}

