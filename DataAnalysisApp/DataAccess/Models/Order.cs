using System;

namespace DataAccess.Models
{
    public class Order
    {
        public Order(double _price, DateTime date, int cd, int salesPerson, int store)
        {
            price = _price;
            datetime = date;
            CdId = cd;
            SalesPersonID = salesPerson;
            StoreNumberID = store;
        }

        public int OrderID { get; private set; }
        public double price { get; private set; }
        public DateTime datetime { get; private set; }
        public int CdId { get; private set; }
        public int SalesPersonID { get; private set; }
        public int StoreNumberID { get; private set; }
    }
}