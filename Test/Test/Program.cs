using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Analyze analyze = new Analyze();
            List <string> filesX = analyze.Run("c:\\users\\Jacek\\source");
        }
    }


    class Analyze
    {
        public List<string> Run(string aPath)
        {
            return MakeAnalyze(aPath);
        }
        public List<string> MakeAnalyze(string aPath)
        {
            string[] directories = System.IO.Directory.GetDirectories(aPath);
            List<string> filenames = new List<string>();
            filenames.AddRange(System.IO.Directory.GetFiles(aPath));
            foreach (var x in directories)
            {             
                filenames.AddRange (MakeAnalyze(x));
            }

            return filenames;

        }
    }



}
