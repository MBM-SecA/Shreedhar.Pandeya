using System;
using System.IO;

public class FileIO
{
    public void LearnFileHandling()
    {
    //     string filename = (@"C:\Users\User\Desktop\C# github repo\Readme.txt");
    //     if(File.Exists(filename))
    //    { string FIleCOntent = File.ReadAllText(@"C:\Users\User\Desktop\C# github repo\Readme.txt");
    //     Console.WriteLine(FIleCOntent);

    //    }
     string filename = "file.txt";
        if(File.Exists(filename))
       { string FIleCOntent = File.ReadAllText(filename);
       
        Console.WriteLine(FIleCOntent);

       }
       File.WriteAllText(filename, "This is just a text file");

       


    }
    public void LearnFileInfo()
    {
        string filename = "file.txt";
        FileInfo fileInfo = new FileInfo(filename);
        var size = fileInfo.Length;
        var createdDate = fileInfo.CreationTime;

        Console.WriteLine($"File size : {size} bytes");
        Console.WriteLine($"Date Created : {createdDate} ");

    }

    public void LearnDirectories()
    {
        string dirName = "A";
        Directory.CreateDirectory(dirName);

    }
    //Q2: Create a folder "Parent", create 10 subfolders in "Parent". Each folder should contain a C# file with "Hello World" program
    
}