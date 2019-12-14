using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    class Analyze
    {
        public void Run(string aPath)
        {
            List<string> filenames= new List<string>();
            MakeAnalyze(aPath, filenames);






        }
        public void MakeAnalyze<string>(string aPath, List<string> aFileNames)
        {
            string[] directories = System.IO.Directory.GetDirectories(aPath);
            foreach (var x in directories)
            {
                MakeAnalyze(x);

            }


        }
    }



}
