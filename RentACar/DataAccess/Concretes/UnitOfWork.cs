using RentACar.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {
        public IAdminRepository AdminRepository => new AdminRepository();

        public IClientRepository ClientRepository => new ClientRepository();

        public IRentRepository RentRepository => new RentRepository();

        public ICarRepository CarRepository => new CarRepository();
    }
}
