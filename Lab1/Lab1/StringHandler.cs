using System;
using System.Collections.Generic;

namespace Lab1
{
    public interface IStringHandler
    {
        string[] DefineLessThanAvrg(string[] input);
        string[] FindSmallestWords(string input);
            
    }
    public class StringHandler: IStringHandler
    {
        public string[] DefineLessThanAvrg(string[] input)
        {
            
            decimal avgStringLength = DefineAvgLength(input);
            int outputArrLength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length < avgStringLength)
                {
                    outputArrLength++;
                }

            }

            string[] outputArray = new string[outputArrLength];
            int j = 0; 
            foreach (string item in input)
            {
                if(item.Length < avgStringLength)
                {
                    outputArray[j] = item;
                    j++;
                }
            }
            return outputArray;

        }
        private decimal DefineAvgLength (string[] input)
        {
            int rowsAmount = input.Length;
            int allStringsLength = 0;
            
            for (int i = 0; i < rowsAmount; i++)
            {

                allStringsLength += input[i].Length;
            }
            return allStringsLength / rowsAmount;
        }

        public string[] FindSmallestWords ( string input)
        {

            string[] splittedInput = input.TrimEnd().TrimStart().Split(' ');
            List<string> outputString = new List<string>();
            if (splittedInput.Length != 0) {
                int minLength = DefineMinWordLength(splittedInput);
                foreach (string item in splittedInput)
                {
                    if (item.Length == minLength)
                    {
                        outputString.Add(item);
                    }
                }
            }
            return outputString.ToArray();
        }
        private int DefineMinWordLength( string[] input)
        {
            int minLength=input[0].Length;
            if (input.Length>0)
            {
                for (int i = 1; i < input.Length; i++)
                {
                    if (minLength > input[i].Length)
                    {
                        minLength = input[i].Length;
                    }
                }
            }
           
            return minLength;
        }

    }
}
