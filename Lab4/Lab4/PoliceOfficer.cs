namespace Lab4
{
    public class PoliceOfficer: IHuman
    {

        private int _id;

        public int Id
        {
            get { return this._id; }
        }

        public PoliceOfficer(int id)
        {
            _id = id;
        }
    }
}