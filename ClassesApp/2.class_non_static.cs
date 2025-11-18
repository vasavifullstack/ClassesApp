using System;
class non_FieldBasics
{
    //Fields are nothting but kind of variables which can hold the values. Value can be anything.
    //non_static members
     string filename = "vasavi_resume.pdf";
     string fileLocation = @"D:\Students\Resume";
     string fileSize = "3kb";
     string filecreatedDate = "Mar-01-2025";

    static DateTime applyResumeDateAndTime = DateTime.Now;



    static void Main()

    {
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
        //Console.WriteLine(datatime);


    }
}
