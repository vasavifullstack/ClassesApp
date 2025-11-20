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

    static void showMessage(string filename, string fileLocation,string fileSize,string filecreatedDate) {
        //string interpolation
    //static string filecreatedDate = "Mar-01-2025";
        Console.WriteLine($"file name {filename}and location {fileLocation} and size {fileSize} and filecreated {filecreatedDate}");
    }

    static void Main() 
    
    { 
       
        string studentfilename=FieldBasics.filename;
        //Console.WriteLine(studentfilename);


        string studentlocation=FieldBasics.fileLocation;
        string studentfilesize = FieldBasics.fileSize;
        string studentfilecreated = FieldBasics.filecreatedDate;


        //DateTime date = FieldBasics.applyResumeDateAndTime;
        //Console.WriteLine(date);
        FieldBasics.showMessage(studentfilename, studentlocation,studentfilesize,studentfilecreated);




        }
    }
