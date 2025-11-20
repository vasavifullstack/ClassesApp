using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    //1.Cannot be instantiated (you cannot create an object from it)
    //2.Can contain only static members(static methods, static variables, static properties)
    //3.Is loaded only once in memory
    //4.Is used for utility/helper methods.
    //5.static members call by using classname
    //6.all  members of the static class related to class itself only.
    //7.we cannot use the this keyword instead using the classname itself only directly.
    //Rules-Cannot create an object
    //All members inside must be static.
    //Static classes cannot contain constructors
    //(But they can have a static constructor.)
    ///Static classes cannot be inherited
    //(You cannot use : baseClass)
    static class Static_Class
    {
        static int ID = 5656;
        static double salary = 200000.00d;

        static void details()
        {
            Console.WriteLine(Static_Class.ID);
        }
        static string[] empname()
        {
            return new string[] { "vasavi reddy", "sreenu reddy", "siva reddy", "vijay" };
           
                      }
        static void Main()
        {
            // Static_Class data = new Static_Class();-can not create the object for member of a class.
            int empid=Static_Class.ID;
            Console.WriteLine(empid);
            string[] empnames=Static_Class.empname();
            Console.WriteLine(empnames);


            }
    }

}
