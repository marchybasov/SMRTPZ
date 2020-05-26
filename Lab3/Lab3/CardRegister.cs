using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    

    public class CardRegister : ICardFinder
    {
        private readonly List<CardBase> cardsList = new List<CardBase>();
        public CardBase GetCardById(int id)
        {
            CardBase result = null;
            foreach (CardBase card in cardsList)
            {
                if (card.GetId() == id)
                {
                    result = card;
                    break;
                }
            }
            return result;
        }
        public CountCard CreateCountCard(int count)
        {
         
            CountCard card = new CountCard(count);
            cardsList.Add(card);
            return card;
        }
    }
}
