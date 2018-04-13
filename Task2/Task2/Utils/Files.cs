using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task2
{
    public class Files
    {
        private static string searchString;
        
        public static string ReadFromFile()
        {
            StreamReader objReader = new StreamReader(Directory.GetCurrentDirectory() + @"\Task2\searchInfo.txt");
            searchString = objReader.ReadToEnd();
            return searchString;          
        }

        public static void WriteResultToFile(string s)
        {
            File.WriteAllText(Directory.GetCurrentDirectory() + @"\Task2\searchResult.txt", s, Encoding.UTF8);
        }
    }
}
