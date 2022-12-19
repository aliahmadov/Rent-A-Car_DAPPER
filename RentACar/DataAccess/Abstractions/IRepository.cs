using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Abstractions
{
    public interface IRepository<T>
    {
        T GetData(int id);
        void AddData(T data);
        void DeleteData(T data);
        void UpdateData(T data);

        IEnumerable<T> GetAll();
    }
}
