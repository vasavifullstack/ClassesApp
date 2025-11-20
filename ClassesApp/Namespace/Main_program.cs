using Job_first;
using Job_second;
using Job_third;
using System;
using System.Security.Cryptography;
namespace Mainprogram
{

    //A namespace in C# is a container used to organize classes, interfaces, enums, structs, and other namespaces into a structured way.
    // It helps avoid name conflicts and makes code clean and manageable.

    //Predefined Namespace (Built-in)

    //System,  System.Collections.Generic ,   System.IO,  System.Net


   

    
    class MainProgram
    {
        public static void Main()
        {
            Job_first.Task1 abc = new Job_first.Task1();
            Console.WriteLine(abc.task);
            Job_second.Task1 abc1 = new Job_second.Task1();
            Console.WriteLine(abc1.task);
            Job_second.Task5 abc2 = new Job_second.Task5();
            Console.WriteLine(abc2.task);



        }

    }
}