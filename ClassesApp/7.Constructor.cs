
//constructor -is a special method inside of a class which is automatically executes
    //once you create the instance.

    //constructor name and class name should be same.
    //constructor is method can accept the parameter
using System;
class FileDetailsConstructors
{

    string filename = "Student1_Resume.docx";
    string filelocation = @"D:\Students\Resumes";
    string filesize = "2Kb";
    string createddate = "Mar-01-2024";
    DateTime createdDateTime = DateTime.Now;



    // pass the multi parameters to the constuctor and check.
    public FileDetailsConstructors(string resumeName)
    {
        ///Code here..
        ///
        Console.WriteLine("File object created");
        Console.WriteLine(this.filename); // "Student1_Resume.docx"

        //this.filename = "Sam_reusme.docx";
        this.filename = resumeName;

    }

    static void Main()
    {
        FileDetailsConstructors file1 = new FileDetailsConstructors("Studnet2_resume.docx");

        //Note : i have changed the filename inside of the constrcutor.

        Console.WriteLine(file1.filename);  //Sam_reusme.docx
    }




}
