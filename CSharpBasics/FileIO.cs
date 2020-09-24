using System;
using System.IO;

public class FileIO
{
    public void LearnFileHandling()
    {
        string filePath = @"E:\git\Pema.tamang\README.md";
        string fileWithInProject = "Generics.cs";


        bool isFile.Exists(filePath);

        if(isFileThere)
        {

        var fileContent = File.ReadALLText(fileWithInProject);
        console.WriteLine(fileContent);
        }
    }
    public void LearnFileInfo()
    {
        string filePath ="Abc.txt";
        FileInfo fileInfo = new FileInfo(filePath);

        var size = fileInfo.Length;
        var createDate = fileInfo.CreationTime;

        Console.WriteLine(filePath);
        Console.WriteLine($"Size: {size} bytes");
        Console.WriteLine($"Created: {createDate}");
    }

    public void LearnDirectory()
    {
        string folderPath ="MBM";
        Directory.CreateDirectory(folderPath);

        Console.WriteLine("Do you want to delete MBM folder?");
        string confirm = Console.ReadLine();
        if(confirm =="Y")

        Directory.Delete(folderPath);
    }
}
/// creating a  folder"NEPAL",create 10 subfolder within that, and every subfolder should contain file Test.txt
//with subfolder name as a content.
 public void FileIoAssignment()
    {
        string rootFolderPath = "Nepal";
        string[] subFolderNames = { "Jhapa", "bhairawa", "Sunsari", "Biratnagar", "Pokhara", "Kathmandu", "morang", "mustang", "Bhaktapur", "Jumla" };
        Directory.CreateDirectory(rootFolderPath);

        foreach (string subfolderName in subFolderNames)
        {
            Directory.CreateDirectory($"{rootFolderPath}/{subfolderName}");
            string filePath = $"{rootFolderPath}/{subfolderName}/Text.txt";
            string fileContent = subfolderName;
            File.WriteAllText(filePath, fileContent);

        }
    }
} 