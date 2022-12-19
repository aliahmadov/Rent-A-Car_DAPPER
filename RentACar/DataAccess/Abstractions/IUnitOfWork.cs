using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Abstractions
{
    public interface IUnitOfWork
    {

        IAdminRepository AdminRepository { get; }

        IClientRepository ClientRepository { get; }

        IRentRepository RentRepository { get; }

        ICarRepository CarRepository { get; }

    }
}
