namespace DataAccess.Models
{
    public class SalesPerson
    {
        public SalesPerson(string fName, string lName, int age, int storeNumber)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            StoreNumberID = storeNumber;
        }

        public SalesPerson(int id, string fName, string lName, int age, int storeNumber)
            : this(fName, lName, age, storeNumber)
        {
            SalesPersonID = id;
        }


        public int SalesPersonID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public int StoreNumberID { get; private set; }
    }
}