

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    static class Logger
    {

        //fileds
        static string _filename = "webapplication.txt";
        static string _filedec = "you have to logged";

        //properties 
        static string Filename { get; set; }

        //constructor
        static Logger()
        {
            Logger.Filename = _filename;

        }
        static void LogMessage(string level ,string msg)
        {
            Console.WriteLine($"{DateTime.Now}  :- {level} {msg}");
        }
        static void InfoMessage(string msg)
        {
            Logger.LogMessage("Info", msg);
        }
        static void WarnMessage(string msg)
        {
            Logger.LogMessage("Warn", msg);
        }
        static void ErrorMessage(string msg)
        {
            Logger.LogMessage("Error", msg);
        }
        static void Main()
        {
            Console.WriteLine($"Log file name field is {Logger._filename}");
            Console.WriteLine($"Log file name field is {Logger._filedec}");
            Console.WriteLine($"Log file name prop is {Logger.Filename}");
            Logger.InfoMessage("Applicaiton started");

            Logger.WarnMessage("YOu have entered the wrong password . if you do again account will be block");

            Logger.ErrorMessage("Somehting is wrong .... Please cehck again");

            Logger.InfoMessage("Applicaiton Stopped");


        }

    }
}