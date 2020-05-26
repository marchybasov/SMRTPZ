using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Transactions;

namespace Lab5
{
    public class FileReader
    {
        private string _filePath;
        public FileReader()
        {
           
        }

        public string[] ReadFile(string filePath)
        {
            _filePath = filePath;
            return File.ReadAllLines(_filePath);
        }
    }
}


