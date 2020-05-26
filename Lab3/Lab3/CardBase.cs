using System;

namespace Lab3
{
    public enum CardType
    {
        basic,
        discount,
        VIP

    }
    public abstract class CardBase
    {
        private int id;
        private CardType _cardType;
        private OwnerType _ownerType;
        public virtual int GetId() => id;

        public int GetCardType() {
            
            return (int)_cardType;
        }

        //public int 
        public abstract bool TryPass();
    }

}
