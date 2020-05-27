using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class Gate
    {
        private ICardFinder _finder; 

        public Gate(ICardFinder finder)
        {
            this._finder = finder;
        }

        public bool CheckCard (int id)
        {
            CardBase card = _finder.GetCardById(id);
            if(card != null)
            {
                return CheckCard(card);
            }
            else
            {
                return false;
            }
        }
        private bool CheckCard(CardBase card)
        {
            
            return card.TryPass();
        }
    }
}
