using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string ImagePath { get; set;}
        public string Brand { get; set; }

        public bool IsNew { get; set; }

        public int Mileage { get; set; }

        public string Type { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }

        public int Price { get; set; }

        public string FuelType { get; set; }
        public decimal RentPriceOneDay { get; set; }
        public decimal RentPriceThreeDays { get; set; }
        public decimal RentPriceOneWeek { get; set; }
    }
}
