using System.IO;
using System.Text;

StringBuilder builder = new StringBuilder();
Encoding utfText = Encoding.UTF8;

string inputPath = @"C:\Users\1\Desktop\Intro_to_LINQ_and_MVC\EncodingAndDecoding\EncodingAndDecoding\theMachineStops.txt";

byte[] utfBytes = utfText.GetBytes(inputPath);

for(int i = 0; i < utfBytes.Length; i++)
{
    Console.WriteLine(utfBytes[i]);
}

try
{
    //Using the Directory class
    Directory.SetCurrentDirectory(inputPath);

    //set your working directory to the same directory as the file you are working with
    string[] workingDirectory = Directory.GetFiles(inputPath, "theMachineStops.txt");

    using (StreamReader reader = File.OpenText(workingDirectory[0]))
    {
        builder.Append(reader.ReadToEnd());
    }

    //outputs the result to a new text file called “TelegramCopy”
    string outputPath = "theMachineStops-UTF8.txt";

    //in the same directory as the original "path"
    using (StreamWriter writer = File.CreateText(Path.Combine(inputPath, outputPath)))
    {
        writer.Write(builder.ToString());
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine(Directory.GetCurrentDirectory());