namespace Lab4
{
    public class FireFighter: IHuman
    {
        private int _id;

        public int Id
        {
            get { return this._id; }
        }

        public FireFighter(int id)
        {
            _id = id;
        }

    }
}