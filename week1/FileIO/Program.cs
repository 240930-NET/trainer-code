using System;
using System.IO; // include to be able to access StreamReader and StreamWriter 

namespace FileIO;

class Program
{
    static void Main(string[] args)
    {
        FileReader reader = new FileReader();
        string filepath = "example.txt";

        //Writing to our file
        FileWriter writer = new FileWriter();
        string content = "This is a new text \n Check it out!";
        writer.WriteToFile(filepath, content);

        string dataFromFile = reader.ReadFile(filepath);
        Console.WriteLine(dataFromFile);
    }
}



//Create a separate class that will handle reading files
public class FileReader{

    public string ReadFile(string pathname){

        //To automatically release our resources we use the keyword "using" 
        using(StreamReader sr = new StreamReader(pathname)){
            return sr.ReadToEnd();
        }

    }
}

//Create a separate class that will handle Writing to files

public class FileWriter{

    public void WriteToFile(string pathname, string content){

        using(StreamWriter writer = new StreamWriter(pathname)){
            writer.WriteLine(content);
        }
    }
}