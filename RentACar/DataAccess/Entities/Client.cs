using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
