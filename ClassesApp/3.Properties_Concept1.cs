using System;
class Student
{
    private string name; // private field

    public string Name   // Property
    {
        get { return name; }
        set { name = value; }
    }


    static void Main()
    {
        Student s = new Student();
        s.Name = "John";      // set
        Console.WriteLine(s.Name);   // get
    }
}