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
            Job_second.Task1 abc1 = new Job_second.Task1();
            Console.WriteLine(abc1.task);
            Job_second.Task5 abc2 = new Job_second.Task5();
            Console.WriteLine(abc2.task);



        }

    }
}