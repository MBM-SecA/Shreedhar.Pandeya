using System;
using System.IO;

public class FileIO
{
    public void LearnFileHandling()
    {
        string FIleCOntent = File.ReadAllText(@"C:\Users\User\Desktop\C# github repo\Readme.txt");
        Console.WriteLine(FIleCOntent);


    }
}