using Dapper;
using RentACar.DataAccess.Abstractions;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Concretes
{
    public class RentRepository : IRentRepository
    {

        private string ConnectionString { get; set; }

        public RentRepository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }
        public void AddData(Rent data)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(@"INSERT INTO Rents(CarId,RentKey,RentStartDate,RentEndDate)
                                    VALUES(@carId,@rentKey,@start,@end)",
                                    new { carId = data.CarId, rentKey = data.RentKey, start = data.RentStartDate, end = data.RentEndDate });



            }
        }

        public void DeleteData(Rent data)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(@"DELETE FROM Rents WHERE Id=@rentId", new { rentId = data.Id });
            }
        }

        public IEnumerable<Rent> GetAll()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var sql = @"SELECT * FROM Rents
                            INNER JOIN Cars ON Rents.CarId=Cars.Id";
                IEnumerable<Rent> rents = null;
                //rents=connection.Query<Rent,Car,Rent>(sql);
                rents = connection.Query<Rent, Car, Rent>(sql,
                    (rent, car) =>
                    {
                        rent.Car = car;
                        return rent;
                    }, splitOn: "Id").ToList();

                return rents;
            }
        }

        public Rent GetData(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var rent = connection.QueryFirstOrDefault<Rent>(@"SELECT* FROM Rents WHERE Id=@id", new { id = id });
                return rent;
            }
        }

        public void UpdateData(Rent data)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(@"UPDATE Rents
                                     SET CarId=@carId,RentKey=@rentKey,RentStartDate=@start,RentEndDate=@end
                                     WHERE Id=@id"
                        , new
                        {
                            carId = data.CarId,
                            rentKey = data.RentKey,
                            id = data.Id,
                            start = data.RentStartDate,
                            end = data.RentEndDate
                        });
            }
        }
    }
}
