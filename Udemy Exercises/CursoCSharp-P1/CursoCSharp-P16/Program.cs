using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CursoCSharp_P16
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                List<string> lines = File.ReadAllLines(sourcePath).ToList();

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                lines.Add("Good Night!");

                File.WriteAllLines(targetPath, lines.ToArray());
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has ocurred: " + e.Message);
            }

            Console.WriteLine();

            sourcePath = @"c:\temp\file3.txt";

            FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                fileStream = new FileStream(sourcePath, FileMode.Open);
                streamReader = new StreamReader(fileStream);

                string line = streamReader.ReadLine();

                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has ocurred: " + e.Message);
            }
            finally
            {
                streamReader?.Close();
                fileStream?.Close();
            }

            Console.WriteLine();

            try
            {
                using (streamReader = File.OpenText(targetPath))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has ocurred: " + e.Message);
            }

            Console.WriteLine();

            StreamWriter streamWriter = null;

            try
            {
                using (fileStream = new FileStream(targetPath, FileMode.Open))
                {
                    using (streamReader = new StreamReader(fileStream))
                    {
                        List<string> lines = new List<string>();
                        while (!streamReader.EndOfStream)
                        {
                            lines.Add(streamReader.ReadLine());
                        }
                        using (streamWriter = File.CreateText(sourcePath))
                        {
                            foreach (string line in lines)
                            {
                                streamWriter.WriteLine(line.ToUpper());
                            }
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has ocurred: " + e.Message);
            }
        }
    }
}
