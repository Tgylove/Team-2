namespace DataAccess.Models
{
    public class Cd
    {
        public Cd(string name, string artist, string recComp, string year, double listprice)
        {
            Name = name;
            Artist = artist;
            RecordCompany = recComp;
            YearReleased = year;
            ListPrice = listprice;
        }

        public Cd(int id, string name, string artist, string recComp, string year, double listprice)
            : this(name, artist, recComp, year, listprice)
        {
            Id = id;
        }

        public Cd(int id, string name, string artist, string recComp)
        {
            Id = id;
            Name = name;
            Artist = artist;
            RecordCompany = recComp;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string RecordCompany { get; set; }
        public string YearReleased { get; set; }
        public double ListPrice { get; set; }
    }
}