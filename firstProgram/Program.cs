// question 11
// using System;
// namespace classwork
// {
//     class Practice
//    {
//     static void Main(string[] args)
//     {
//        int a=2;
//        if(a>1) //here we used greater then > operator
//        {
//            Console.WriteLine("2 is greater then 1");
//        }
//         not equal to
//         if(a<4)  //here we used less then operaor<
//         {
//             Console.WriteLine("2 is less then 4");
//         }

//     }
//    } 
// }

//Anonymous class
using System;
namespace Class
{
    static class Hello
   {
       static Hello()
       {
        }
        static int a =10;
        static int hello()
        {
            return a;
        }
        static void Main(string[] args)
    {
       var obj = new{ Name= "Faizan",Age = 47};
      Console.WriteLine(obj.Age + Hello.a);
     

    }
   } 
}





































// // question 10
// using System;
// namespace classwork
// {
//     class Practice
//    {
//     static void Main(string[] args)
//     {
//        int a=2;
//        if(a>1) //here we used greater then > operator
//        {
//            Console.WriteLine("2 is greater then 1");
//        }
//         //not equal to
//         if(a<4)  //here we used less then operaor<
//         {
//             Console.WriteLine("2 is less then 4");
//         }

//     }
//    } 
// }

































// // question 9
// using System;
// namespace classwork
// {
//     class Practice
//    {
//     static void Main(string[] args)
//     {
//        int a=2;
//        if(a==2) //here we used equal operator
//        {
//            Console.WriteLine("2 is equal to 4");
//        }
//         //not equal to
//         if(a!=4)
//         {
//             Console.WriteLine("2 is not equal to 4");
//         }

//     }
//    } 
// }






























// // question 8
// using System;
// namespace classwork
// {
//     class Practice
//    {
//     static void Main(string[] args)
//     {
//        //sizeof operator take primitive data type and return size of that 
//         Console.WriteLine(sizeof(int));

//     }
//    } 
// }





















// // question 7
// using System;
// namespace classwork
// {
//     class Practice
//    {
//     static void Main(string[] args)
//     {
//        int a = 120; //here we use assignment operator to assign 120 to a
//        a += 11;   //plus assignment operator
//        a -= 1;  //minus assignment operator
//         Console.WriteLine(a);

//     }
//    } 
// }




































// // question 6
// using System;
// namespace classwork
// {
//     class Practice
//    {
//     static void Main(string[] args)
//     {
//         int a;
//         int b;
//         Console.WriteLine("enter first intger:");
//         a=Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("enter second intger:");

//         b = Convert.ToInt32(Console.ReadLine());
//         int c = a+b;
//         Console.WriteLine(a+"+"+b+"="+c);
//     }
//    } 
// }



























// // question 6
// using System;
// namespace classwork
// {
//     class Practice
//    {
//     static void Main(string[] args)
//     {
//         int a;
//         int b;
//         Console.WriteLine("enter first intger:");
//         a=Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("enter second intger:");

//         b = Convert.ToInt32(Console.ReadLine());
//         int c = a+b;
//         Console.WriteLine(a+"+"+b+"="+c);
//     }
//    } 
// }


















// // question 5
// using System;
// namespace classwork
// {
//     class Practice
//    {
//     static void Main(string[] args)
//     {
//         String name;
//         Console.Write("Enter Your name: ");
//         name = Console.ReadLine();
//         Console.WriteLine("Hello "+ name);
//     }
//    } 
// }
























// // question 4
// using System;
// namespace classwork
// {
//     class Practice
//    {
//     static void Main(string[] args)
//     {

//         int a=20;
//         double b = (double) a;
//         // using Convert
//         Console.WriteLine("using conver toSring "+Convert.ToString(a));
//     }
//    } 
// }
// question 3
// using System;
// namespace classwork
// {
//     class Practice
//    {
//     static void Main(string[] args)
//     {

//         Console.WriteLine("size of integer is "+sizeof(int));
//         Console.WriteLine("size of char is "+sizeof(char));
//         // Console.WriteLine("size of string is "+sizeof(string));
//         Console.WriteLine("size of float is "+sizeof(float));
//         Console.WriteLine("size of double is "+sizeof(double));

//     }
//    } 
// }






















// question 2
// using System;
// namespace classwork
// {
//     class Practice
//    {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World");
//         Console.Write("Hello World from write");
//     }
//    } 
// }
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace TextHello
// {
//     class Program
//    {
//     //    private void addtwonumber(int a, int b)
//     //    {
//     //        Console.wri
//     //    }
//     static void Main(string[] args)
//     {
//         String name;
//         Console.Write("Enter Your name: ");
//         name = Console.ReadLine();
//         Console.WriteLine("Hello "+ name+args[0]);

//     }

//    } 
// }
// Single line comment
/* 
Multiple line comment
*/

/**
For whole  document or page use

*/

