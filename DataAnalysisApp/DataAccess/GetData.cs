using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess.Models;

namespace DataAccess
{
    public class Data
    {
        private readonly SqlConnection _sqlConnection;
        private SqlCommand _sqlCommand;
        private SqlDataReader _sqlReader;

        public Data(string connString)
        {
            _sqlConnection = new SqlConnection(connString);
        }

        public bool AddCd(Cd cd)
        {
            var success = false;


            _sqlConnection.Open();
            var sqlQuery =
                "INSERT INTO [CD-table] " +
                "(CdName,Artist,RecordCompany,YearReleased, ListPrice) " +
                "VALUES(@cdName,@cdArtist,@cdRecordCompany, @cdYear, @cdListPrice)";

            _sqlCommand = new SqlCommand(sqlQuery, _sqlConnection);
            _sqlCommand.Parameters.AddWithValue("@cdName", cd.Name);
            _sqlCommand.Parameters.AddWithValue("@cdArtist", cd.Artist);
            _sqlCommand.Parameters.AddWithValue("@cdRecordCompany", cd.RecordCompany);
            _sqlCommand.Parameters.AddWithValue("@cdYear", cd.YearReleased);
            _sqlCommand.Parameters.AddWithValue("@cdListPrice", cd.ListPrice);

            try
            {
                _sqlCommand.ExecuteNonQuery();
                success = true;
            }
            catch (Exception ex)
            {
                //TODO something useful
                Console.WriteLine(ex);
            }
            _sqlConnection.Close();

            return success;
        }

        public bool AddStore(Store store)
        {
            var successs = false;

            _sqlConnection.Open();
            var sqlQuery =
                "INSERT INTO [Store-Table] " +
                "(City,State,NumberEmployees) " +
                "VALUES(@city,@state,@noEmp)";

            _sqlCommand = new SqlCommand(sqlQuery, _sqlConnection);
            _sqlCommand.Parameters.AddWithValue("@city", store.City);
            _sqlCommand.Parameters.AddWithValue("@state", store.State);
            _sqlCommand.Parameters.AddWithValue("@noEmp", store.NumberOfEmplpoyes);

            try
            {
                _sqlCommand.ExecuteNonQuery();

                successs = true;
            }
            catch (Exception ex)
            {
                //TODO something useful
                Console.WriteLine(ex);
            }
            _sqlConnection.Close();

            return successs;
        }

        public List<Store> GetStores()
        {
            var stores = new List<Store>();

            try
            {
                _sqlConnection.Open();
                var sqlQuery = "Select * FROM  [Store-Table]";
                _sqlReader = new SqlCommand(sqlQuery, _sqlConnection).ExecuteReader();

                while (_sqlReader.Read())
                    stores.Add(new Store(
                        (int) _sqlReader["StoreNumberID"], (string) _sqlReader["City"], (string) _sqlReader["State"],
                        (int) _sqlReader["NumberEmployees"]
                    ));
            }
            catch (Exception ex)
            {
                //TODO something useful
                Console.WriteLine(ex);
            }
            _sqlConnection.Close();

            return stores;
        }

        public List<Cd> GetCds()
        {
            var cds = new List<Cd>();

            try
            {
                _sqlConnection.Open();
                var sqlQuery = "Select * FROM  [CD-table]";
                _sqlReader = new SqlCommand(sqlQuery, _sqlConnection).ExecuteReader();

                while (_sqlReader.Read())
                    cds.Add(new Cd(
                        (int) _sqlReader["CdId"], (string) _sqlReader["CdName"], (string) _sqlReader["Artist"],
                        (string) _sqlReader["RecordCompany"]
                    ));
            }
            catch (Exception ex)
            {
                //TODO something useful
                Console.WriteLine(ex);
            }
            _sqlConnection.Close();

            return cds;
        }

        public List<SalesPerson> GetSalesPersons()
        {
            var people = new List<SalesPerson>();

            try
            {
                _sqlConnection.Open();
                var sqlQuery = "Select * FROM  [SalesPerson-Table]";
                _sqlReader = new SqlCommand(sqlQuery, _sqlConnection).ExecuteReader();

                while (_sqlReader.Read())
                    people.Add(new SalesPerson(
                        (int) _sqlReader["SalesPersonId"], (string) _sqlReader["FirstName"],
                        (string) _sqlReader["LastName"], (int) _sqlReader["Age"], (int) _sqlReader["StoreNumberID"]
                    ));
            }
            catch (Exception ex)
            {
                //TODO something useful
                Console.WriteLine(ex);
            }

            _sqlConnection.Close();
            return people;
        }

        public bool AddSalesPerson(SalesPerson salesPerson)
        {
            var success = false;


            _sqlConnection.Open();
            var sqlQuery =
                "INSERT INTO [SalesPerson-table] " +
                "(FirstName,LastName,Age,StoreNumberID) " +
                "VALUES(@pFName,@pLName,@pAge, @pStore)";

            _sqlCommand = new SqlCommand(sqlQuery, _sqlConnection);
            _sqlCommand.Parameters.AddWithValue("@pFName", salesPerson.FirstName);
            _sqlCommand.Parameters.AddWithValue("@pLName", salesPerson.LastName);
            _sqlCommand.Parameters.AddWithValue("@pAge", salesPerson.Age);
            _sqlCommand.Parameters.AddWithValue("@pStore", salesPerson.StoreNumberID);


            try
            {
                _sqlCommand.ExecuteNonQuery();
                success = true;
            }
            catch (Exception ex)
            {
                //TODO something useful
                Console.WriteLine(ex);
            }
            _sqlConnection.Close();

            return success;
        }

        public bool AddOrder(Order order)
        {
            var success = false;


            _sqlConnection.Open();
            var sqlQuery =
                "INSERT INTO [Orders] " +
                "(price,datetime,CdId,SalesPersonID,StoreNumberID) " +
                "VALUES(@orderPrice,@orderDate,@orderCd, @orderSalesPerson, @orderStore)";

            _sqlCommand = new SqlCommand(sqlQuery, _sqlConnection);
            _sqlCommand.Parameters.AddWithValue("@orderPrice", order.price);
            _sqlCommand.Parameters.AddWithValue("@orderDate", order.datetime);
            _sqlCommand.Parameters.AddWithValue("@orderCd", order.CdId);
            _sqlCommand.Parameters.AddWithValue("@orderSalesPerson", order.SalesPersonID);
            _sqlCommand.Parameters.AddWithValue("@orderStore", order.StoreNumberID);


            try
            {
                _sqlCommand.ExecuteNonQuery();
                success = true;
            }
            catch (Exception ex)
            {
                //TODO something useful
                Console.WriteLine(ex);
            }
            _sqlConnection.Close();

            return success;
        }
    }
}