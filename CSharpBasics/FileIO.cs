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
}