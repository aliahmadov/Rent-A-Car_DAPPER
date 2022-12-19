using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Entities
{
    public class Rent
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public virtual Client Client { get; set; }

        public int CarId { get; set; }

        public virtual  Car Car { get; set; }
    }
}
