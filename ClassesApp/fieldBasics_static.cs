using System;
 class FieldBasics
    {
    //Fields are nothting but kind of variables which can hold the values. Value can be anything.
    //static members
    static string filename = "vasavi_resume.pdf";
    static string fileLocation = @"D:\Students\Resume";
    static string fileSize = "3kb";
    static string filecreatedDate = "Mar-01-2025";

    static DateTime applyResumeDateAndTime = DateTime.Now;



    static void Main() 
    
    { 
       
        string studentfilename=FieldBasics.filename;
        Console.WriteLine(studentfilename);

        DateTime date = FieldBasics.applyResumeDateAndTime;
        Console.WriteLine(date);



        }
    }
