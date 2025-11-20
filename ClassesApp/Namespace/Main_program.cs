using System;
using Job_first;
using Job_second;
using Job_third;
namespace Mainprogram
{
    class MainProgram
    {
        public static void Main()
        {
            Job_first.Task1 abc = new Job_first.Task1();
            Console.WriteLine(abc.task);



        }

    }
}