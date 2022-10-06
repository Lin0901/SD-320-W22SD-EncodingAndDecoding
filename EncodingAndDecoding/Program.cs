using System.Text;

string Encodepath = @"C:\Users\1\Desktop\Intro_to_LINQ_and_MVC\EncodingAndDecoding\EncodingAndDecoding";
string Dncodepath = @"C:\Users\1\Desktop\Intro_to_LINQ_and_MVC\EncodingAndDecoding\EncodingAndDecoding";

Encode(Encodepath, Dncodepath);
Decode(Dncodepath, Dncodepath);

void Encode(string inputPath, string outputPath)
{
    Encoding ascii = Encoding.ASCII;
    string content = "Encode";
    byte[] bytes = ascii.GetBytes(content);

    for (int x = 0; x < bytes.Length; x++)
    {
        Console.WriteLine(bytes[x]);
    }
}

void Decode(string inputPath, string outputPath)
{
    Encoding utf8 = Encoding.UTF8;
    string content = "Decode";
    byte[] bytes = utf8.GetBytes(inputPath);
    string decodedText = UTF8Encoding.UTF8.GetString(bytes);

    for (int x = 0; x < bytes.Length; x++)
    {
        Console.WriteLine(bytes[x]);
    }
    Console.WriteLine(content);
}