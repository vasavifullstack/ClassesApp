
using System;
using System.Runtime.CompilerServices;

 class Constant_readonly
    {
    //compile time-before the debugging process.-constant variables
    //In Compile time - shared across all instances. 

    //constant variable once assigned .we cannot change the value.
    //readonly variable same functionality. we can change values at constructor level only
    //.we needd to instance in runtime.we cannot the change the values in methods.

    //runtime-after the debugging process.
    //readonly  - i and do assing the value in runtime only in consturctor.
    //runtime  Assingted through the constuctror.

    const double pi = 3.14159;   // 

    const string MisardCompanySLogin = "Be MAD, Step Forward";

    readonly string createdDate = "Mar-05-2025";

    public Constant_readonly()
    {
        this.createdDate = "april-5-2025";
        //this.pi = 12.45;

    }
    public void getMethod()
    {

    }

    static void Main()
    {
    //    string pi = "12.56";
    //    Console.Write(pi);

    //    string createdDate = "april-5-2023";
    //    Console.WriteLine(createdDate);

        Constant_readonly constAndReadOnly = new Constant_readonly();
        Console.WriteLine(constAndReadOnly.createdDate);  //april-09-2025
       // Constant_readonly.pi = 10.98;
    }




}

