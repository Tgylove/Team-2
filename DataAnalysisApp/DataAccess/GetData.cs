using System;
using System.Collections.Generic;
using System.Data;
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


        //Group methods
        //var sqlQuery: to make methods results easy to understand

        /// <summary>
        ///     Gets the per CD analysis
        /// </summary>
        /// <param name="cdId">CdId from the CD-Table</param>
        /// <returns>A data-table of pertinent information to figure out per CD Sales</returns>
        public DataTable GetCdData(int cdId)
        {
            var sqlQuery =
                "SELECT CD.CDname AS 'CD Name', CD.Artist AS Artist, CD.ListPrice - Orders.Price  AS Discount, Store.City As City " +
                "FROM Orders " +
                "INNER JOIN[CD-Table] AS CD " +
                "ON Orders.CdID = CD.CdID " +
                "INNER Join[Store-Table] AS Store " +
                "ON Orders.StoreNumberID = Store.StoreNumberID " +
                //this query needs to use a dynamic id
                $"WHERE CD.CdID = {cdId} " +
                "ORDER BY 'CD name', City, Discount";

            var results = new DataTable();
            _sqlConnection.Open();
            var adapter = new SqlDataAdapter(sqlQuery, _sqlConnection);
            adapter.Fill(results);
            _sqlConnection.Close();
            return results;
        }

        /// <summary>
        ///     Gets sales per employee
        /// </summary>
        /// <returns>Data-table of pertinent data</returns>
        public DataTable GetEmployeeData()
        {
            const string sqlQuery =
                "SELECT FirstName AS 'First Name', LastName AS 'Last Name', Totals.NoOrders AS 'Number or Orders', Totals.DOL AS  'Sales Total' FROM[SalesPerson-Table] INNER JOIN (SELECT SalesPersonID, COUNT(Orders.SalesPersonID)AS 'NoOrders', SUM(Orders.Price) AS DOL FROM Orders GROUP BY SalesPersonID) AS Totals  ON[SalesPerson-Table].SalesPersonID = Totals.SalesPersonID ORDER BY Totals.DOL DESC";
            var results = new DataTable();
            _sqlConnection.Open();
            var adapter = new SqlDataAdapter(sqlQuery, _sqlConnection);
            adapter.Fill(results);
            _sqlConnection.Close();
            return results;
        }

        /// <summary>
        ///     Get Sales Analysis by store
        /// </summary>
        /// <returns> Data-table</returns>
        public DataTable GetStoreData()
        {
            const string sqlQuery =
                "SELECT Store.City AS City, Totals.NoOrders AS 'Number of Orders', Totals.DOL AS 'Sales Totals' FROM [Store-Table] AS Store INNER JOIN (SELECT StoreNumberID AS Id, COUNT(*) AS 'NoOrders', SUM(Orders.Price) AS DOL FROM Orders GROUP BY StoreNumberID) AS Totals ON Store.StoreNumberID = Totals.Id ORDER BY [Sales Totals] DESC";
            var results = new DataTable();
            _sqlConnection.Open();
            var adapter = new SqlDataAdapter(sqlQuery, _sqlConnection);
            adapter.Fill(results);
            _sqlConnection.Close();
            return results;
        }
    }
}