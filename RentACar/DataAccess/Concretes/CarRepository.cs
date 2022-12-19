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
    public class CarRepository : ICarRepository
    {

        private string ConnectionString { get; set; }

        public CarRepository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }
        public void AddData(Car data)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(@"INSERT INTO Cars(ImagePath,Brand,IsNew,Mileage,Type,Year,Color,Price,FuelType,RentPriceOneDay,RentPriceThreeDays,RentPriceOneWeek)
          VALUES(@path,@brand,@isNew,@mileage,@type,@year,@color,@price,@fuelType,@price1,@price3,@price7)",
          new
          {
              path = data.ImagePath,
              brand = data.Brand,
              isNew = data.IsNew,
              mileage = data.Mileage,
              type = data.Type,
              year = data.Year,
              color = data.Color,
              price = data.Price,
              fuelType = data.FuelType,
              price1 = data.RentPriceOneDay,
              price3 = data.RentPriceThreeDays,
              price7 = data.RentPriceOneWeek
          });

            }
        }

        public void DeleteData(Car data)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(@"DELETE FROM Cars WHERE Id=@id", new { id = data.Id });
            }
        }

        public IEnumerable<Car> GetAll()
        {
            IEnumerable<Car> cars = new List<Car>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                cars = connection.Query<Car>(@"SELECT* FROM Cars");
                return cars;
            }
        }

        public Car GetData(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var car = connection.QueryFirstOrDefault<Car>(@"SELECT* FROM Cars WHERE Id=@id", new { id = id });
                return car;
            }
        }

        public void UpdateData(Car data)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(@"UPDATE Cars
                                    SET ImagePath=@path,Brand=@brand,IsNew=@isNew,
Mileage=@mileage,Type=@type,Year=@year,Color=@color,Price=@price,FuelType=@fuelType,
RentPriceOneDay=@price1,RentPriceThreeDays=@price3,RentPriceOneWeek=@price7
WHERE Id=@id",
new
{
    path = data.ImagePath,
    brand = data.Brand,
    isNew = data.IsNew,
    mileage = data.Mileage,
    type = data.Type,
    year = data.Year,
    color = data.Color,
    price = data.Price,
    fuelType = data.FuelType,
    price1 = data.RentPriceOneDay,
    price3 = data.RentPriceThreeDays,
    price7 = data.RentPriceOneWeek,
    id = data.Id
});
            }
        }
    }
}
