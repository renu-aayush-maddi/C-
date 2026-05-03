using System;
using System.IO;

class Task5
{
    public static void Run()
    {
        string inputFile ="input.txt";
        string outputFile ="output.txt";
        try
        {
            string text = File.ReadAllText(inputFile);

            int wordCount = text.Split(new char[] {' ','\n','\t'}).Length;
            int lineCount = File.ReadAllLines(inputFile).Length;

            string result =
                "Word Count:" + wordCount +Environment.NewLine+
                "Line Count:" + lineCount;

            File.WriteAllText(outputFile,result);
            Console.WriteLine("Result saved to output.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Input file not found");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error:"+ex.Message);
        }
    }
}