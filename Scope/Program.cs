using System;

namespace Scope
{
    class Program
    {
        // static variable that's accesible to all methods of this class
        private static int x = 1;
        //Main creaes and initializes local varaible x
        //and calls methods UseLocalVariable and UseStaticVariable
        static void Main()
        {
            int x = 5; // method's local vairable x
            Console.WriteLine($"Local x in method Main is {x}");

            // UseLocalVariable has its own local x
            UseLocalVariable();

            // UseStaicVaraible uses class Scopes's static variable x
            UseStaticVariable();

            // UseLocalVariable reinitalizes its own local vairable x
            UseLocalVariable();

            // class Scope's static variable x retians its value 
            UseStaticVariable();
        }
        //Create and reinitalizes its own local vairable  x during each call
        static void UseLocalVariable()
        {
            int x = 25; // initializes each tme UseLocalVariable is called

            Console.WriteLine($"\nlocal x before exiting method UselocalVariable is {x}");
            ++x; //modifeis this methods local variable
            Console.WriteLine($"local x before exiting method UseLocalVariable is {x}");
        }

        //modify class Scope's static varaible x during each call 
        static void UseStaticVariable()
        {
            Console.WriteLine("\nstatic variable x on entering method" + $"UseStaicVariable is {x}");
            x *= 10; // method class Scope's static variable x before entering
            Console.WriteLine("static variable x before exiting" + $"method UseStaticVariable is {x}");
        }
    }
}
