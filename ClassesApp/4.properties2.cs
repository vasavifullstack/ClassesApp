using System;
     class Employ_details
    {

    //here "_" underscore refers field-not having control of values.so cannot protect the data

    //string _employ_name = "vasavi reddy";
    //property always start with uppercase to control values get and set method.
    //to protect the filed .we need to use property.
    string Employ_name { get; set; }

    string Employ_ID { get; }

    string Salary { get; }

    string Employ_Location { get; set; }



    static void Main()
    {
        Employ_details details = new Employ_details();
        //both get and set the values
        details.Employ_name = "vasavi reddy";
        Console.WriteLine(details);
        //only get the value .cannot modify.
        details.Employ_ID.ToString();

        details.Employ_Location.ToString();

        details.Salary.ToString();


    }
    }
