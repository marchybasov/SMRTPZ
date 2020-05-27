using System.Collections.Generic;

namespace Lab5
{
    internal class CustomSorter : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x.Length > y.Length)
            {
                return 1;
            }
            else if (x.Length < y.Length)
            {
                return -1;
            }
            else { }
            {
                return 0;
            }

        }
    }
}