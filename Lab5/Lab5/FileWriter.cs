using System;
using System.IO;

namespace Lab5
{
    public class FileWriter
    {
        private string[]_collection;
        private string _destinationFilePath;

        public void WriteArrayInAscOrder(string[] collection, string destinationFilePath)
        {
            _collection = collection;
            _destinationFilePath = destinationFilePath;
            File.WriteAllLines(_destinationFilePath, SortAscending(_collection));

        }
        private static string[] SortAscending(string[] inputCollection)
        {

            CustomSorter customSorter = new CustomSorter();
            Array.Sort(inputCollection, customSorter);
            return inputCollection;
        }
    }
}


