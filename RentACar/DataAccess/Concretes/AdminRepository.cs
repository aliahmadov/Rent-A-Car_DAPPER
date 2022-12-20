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
    public class AdminRepository : IAdminRepository
    {

        private string ConnectionString { get; set; }

        public AdminRepository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }

        public void AddData(Admin data)
        {
            using (var connection=new SqlConnection(ConnectionString))
            {
                var query = connection.Execute(@"INSERT INTO Admins(Username,Password)
                            VALUES(@username,@password)", new { username = data.Username, password = data.Password });
            }
        }

        public void DeleteData(Admin data)
        {
            using (var connection=new SqlConnection(ConnectionString))
            {
                var query = connection.Execute(@"DELETE FROM Admins
                                               WHERE Admins.Id=@id", new { id = data.Id });
            }
        }

        public IEnumerable<Admin> GetAll()
        {
            IEnumerable<Admin> result = new List<Admin>();
            using (var connection=new SqlConnection(ConnectionString))
            {
                result = connection.Query<Admin>("SELECT* FROM Admins");
                return result;
            }

        }

        public Admin GetData(int id)
        {
            using (var connection=new SqlConnection(ConnectionString))
            {
                var admin = connection.QueryFirstOrDefault<Admin>(@"SELECT* FROM Admins WHERE Admins.Id=@id",
                                                                    new { id = id });
                return admin;
            }
        }

        public void UpdateData(Admin data)
        {
            using (var connection=new SqlConnection(ConnectionString))
            {
                connection.Execute(@"UPDATE Admins
                                    SET Username=@username, Password=@password
                                    WHERE Id=@id",
                                        new {username=data.Username, password=data.Password,id=data.Id});
            }
        }
    }
}
