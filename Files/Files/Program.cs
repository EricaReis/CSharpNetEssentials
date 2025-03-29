namespace Files;
using System.IO;

public class Program
{
    public static void Main()
    {
        //1. Create a File
        string content = "Hello, World!";
        File.WriteAllText("file2.txt", content);

        Console.WriteLine("File created.");

        //2. Create a file in another path
        string path = @"C:\Users\erica\Documents\Teste\fileName.txt";
        string content2 = "Hello, World2!";

        File.WriteAllText(path, content2);

        //3. Create a Word file
        string path2 = @"C:\Users\erica\Documents\Teste\";
        string fileName = "myDocument.Doc";

        string filePath = path2 + fileName;

        File.WriteAllText(filePath, content2);

        //4. Insert a paragraph into a file
        string path3 = @"C:\Users\erica\Documents\Teste\";
        string fileName2 = "myDocument.Doc";

        string filePath2 = path2 + fileName;

        string additionalContent = "| C# and .NET course";

        File.AppendAllText(filePath, additionalContent);



    }
}