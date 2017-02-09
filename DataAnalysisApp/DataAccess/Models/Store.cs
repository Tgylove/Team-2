namespace DataAccess.Models
{
    public class Store
    {
        public Store(string city, string state, int noEmp)
        {
            City = city;
            State = state;
            NumberOfEmplpoyes = noEmp;
        }

        public Store(int id, string city, string state, int noEmp)
            : this(city, state, noEmp)
        {
            Id = id;
        }


        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int NumberOfEmplpoyes { get; set; }
    }
}