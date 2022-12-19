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
                var query=@"INSERT INTO Admins(Username,Password)
                            VALUES(@username,@password)"
            }
        }

        public void DeleteData(Admin data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Admin> GetAll()
        {
            throw new NotImplementedException();
        }

        public Admin GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Admin data)
        {
            throw new NotImplementedException();
        }
    }
}
