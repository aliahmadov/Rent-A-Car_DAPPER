using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.ViewModels
{
    public class UpdateWindowViewModel : BaseViewModel
    {

        private Car car;

        public Car Car
        {
            get { return car; }
            set
            {
                car = value;
                OnPropertyChanged();
            }
        }


        public UpdateWindowViewModel()
        {
            Car = new Car();
        }

    }
}
