namespace Model
{
    public class Phone
    {
        private string _name;
        private int _releaseYearDate;
        private Phonebrand _brand;
        private Company _creatorCompany;
        private int _numOfCopiesSold;
        private decimal _cost;

        public Phone(string name, int releaseYearDate, Phonebrand genre,
            Company creatorCompany, int numOfCopiesSold, decimal cost)
        {
            _name = name;
            if (!(2023 >= releaseYearDate && releaseYearDate >= 1876))
            {
                throw new Exception("The year is not in the range from 1800 to 9999.\n" +
                    $"Year = {releaseYearDate}");
            }
            _releaseYearDate = releaseYearDate;
            _brand = genre;
            _creatorCompany = creatorCompany;
            if (!(numOfCopiesSold >= 0))
            {
                throw new Exception("The number of copies sold cannot be less than zero.");
            }
            _numOfCopiesSold = numOfCopiesSold;
            if (!(cost >= 0))
            {
                throw new Exception("The cost of a copy cannot be less than zero.");
            }
            _cost = cost;
        }

        public override string ToString()
        {
            return $"Name: {_name}\n" +
                $"Date release: {_releaseYearDate}\n" +
                $"Genre {_brand}\n" +
                $"Creator: {_creatorCompany}\n" +
                $"Number of copies sold: {_numOfCopiesSold}\n" +
                $"Cost: {_cost}";
        }
    }
}