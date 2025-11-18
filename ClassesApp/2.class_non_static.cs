using System;
using System.Text;
class non_FieldBasics
{
    //Fields are nothting but kind of variables which can hold the values. Value can be anything.
    //non_static members
     string filename = "vasavi_resume.pdf";
     string fileLocation = @"D:\Students\Resume";
     string fileSize = "3kb";
     string filecreatedDate = "Mar-01-2025";

    static DateTime applyResumeDateAndTime = DateTime.Now;

    void showmessage(string filename, string fileLocation)
    {
        //string interpolation
        Console.WriteLine($"file name {this.filename}and location {this.fileLocation}");
    }
    void entireStudent(String filename, string fileLocation,  string fileSize,string filecreatedDate)
    {
        Console.WriteLine("vasavi reddy");
        Console.WriteLine($"file name {this.filename}and location {this.fileLocation}");

    }
    void entireStudent1(non_FieldBasics details)
    {
        Console.WriteLine("hii");
        Console.WriteLine(filename);
        Console.WriteLine(fileLocation);
        Console.WriteLine(fileSize);
        Console.WriteLine(filecreatedDate);

    }

    static void Main()

    {
        //instance of a class by using new keyword and create reference variable to capture the instance
       non_FieldBasics fields = new non_FieldBasics();
        
     


        string studentfilename = fields.filename;
        Console.WriteLine(studentfilename);

        string studentlocation=fields.fileLocation;
       Console.WriteLine(studentlocation); 

        string FileSize=fields.fileSize;
        Console.WriteLine(FileSize);
        
        string createData=fields.filecreatedDate;
        Console.WriteLine(createData);
        //DateTime datatime = fields.applyResumeDateAndTime;
        //Console.WriteLine(datatime);s
        fields.showmessage(studentfilename, studentlocation);


        //instance of second method of same class
        non_FieldBasics fields1 = new non_FieldBasics();
        //update "vasavi_resume.pdf" to "sreenu reddy_resume.pdf".
        fields1.filename = "sreenu reddy_resume.pdf";
        fields1.fileLocation = @"c\sample\resume";
        fields1.fileSize = "5KB";
        fields1.filecreatedDate = "Aprile-6-2025";
        //Console.WriteLine(fields1.filename);
        //Console.WriteLine(fields1.fileLocation);
        //Console.WriteLine(fields1.fileSize);
        //Console.WriteLine(fields1.filecreatedDate);
        //fields1.entireStudent(studentfilename, studentlocation, FileSize, createData);

        //passing the argument as a instance of class like fields1 or class like  non_FieldBasics
        fields1.entireStudent1(fields1);
        fields1.entireStudent(fields1.filename, fields1.fileLocation,fields1.fileSize,fields1.filecreatedDate);
    }


}
