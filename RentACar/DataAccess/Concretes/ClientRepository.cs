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
    public class ClientRepository : IClientRepository
    {

        private string ConnectionString { get; set; }

        public ClientRepository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }
        public void AddData(Client data)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(@"INSERT INTO Clients(Username,Password,Email)
                                    VALUES(@username,@password,@email)",
                                    new { username = data.Username, password = data.Password, email = data.Email });
            }
        }

        public void DeleteData(Client data)
        {
            using (var connection=new SqlConnection(ConnectionString))
            {
                connection.Execute(@"DELETE FROM Clients
                                    WHERE Clients.Id=@id", new { id = data.Id });
            }
        }

        public IEnumerable<Client> GetAll()
        {
            IEnumerable<Client> clients = new List<Client>();

            using (var connection=new SqlConnection(ConnectionString))
            {
                clients = connection.Query<Client>(@"SELECT* FROM Clients");
                return clients;
            }

        }

        public Client GetData(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var client = connection.QueryFirstOrDefault<Client>(@"SELECT* FROM Clients WHERE Clients.Id=@id",
                    new { id = id });
                return client;
            }
        }

        public void UpdateData(Client data)
        {
            using (var connection=new SqlConnection(ConnectionString))
            {
                connection.Execute(@"UPDATE Clients
                                    SET Username=@username,Password=@password,Email=@email
                                    WHERE Id=@id",
                                    new { username = data.Username,id=data.Id,
                                        password = data.Password, email = data.Email });
            }
        }
    }
}
