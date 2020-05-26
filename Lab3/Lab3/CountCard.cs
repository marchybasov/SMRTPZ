using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{

    
    public class CountCard:CardBase
    {
        private int tripsCount;
        public CountCard(int count)
        {
            tripsCount = count;
        }
        public int GetTripsCount()
        {
            return tripsCount;
        }
        public override bool TryPass()
        {
            bool result = tripsCount > 0;

            if (result)
            {
                tripsCount--;
            }
            return result;
        }
    }
}
