using System;
class File1
{
    //string _filename;
    //string _filelocation;
    //string _filesize;
    //string _createddate;

    public string FileName { get; set; }
    public string FileLocation { get; set; }
    public string FileSize { get; set; }
    public string CreatedDate { get; set; }
}
class File2
    {
        public void method1(string[] fileNames)
        {

        }
    }
    class File3
    {
        static void Main()
        {
            File2 data = new File2();
            string[] fileNames = { "PDFFile1.pdf", "PDFFile2.pdf", "PDFFile3.pdf" };
            data.method1(fileNames);
            Console.WriteLine(fileNames);
        }
    }
