using System;
namespace Lab3
{

    //class CardCreator <T> where T: CardBase, new()
    //{
    //    public T CreateCard() => new T(); 
    //}

    abstract class CardCreator
    {
        public abstract CardBase CreateCard();
    }
    class MorningCardCreator : CardCreator
    {
        public override CardBase CreateCard() => new MorningCard();
    }
    class NoonCardCreator : CardCreator
    {
        public override CardBase CreateCard() => new NoonCard();
    }
    class NightCardCreator : CardCreator
    {
        public override CardBase CreateCard() => new NightCard();
    }

    class N_daysCardCreator : CardCreator
    {

        public override CardBase CreateCard() => new N_daysCard(DateTime.Today, 5);
    }

}
