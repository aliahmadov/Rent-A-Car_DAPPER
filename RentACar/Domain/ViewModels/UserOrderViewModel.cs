using RentACar.Domain.Commands;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.ViewModels
{
    public class UserOrderViewModel : BaseViewModel
    {

        public Car Car { get; set; }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(); }
        }


        private decimal totalPrice;

        public decimal TotalPrice
        {
            get { return totalPrice; }
            set
            {
                totalPrice = value;
                OnPropertyChanged();
            }
        }


        private int dayCount;

        public int DayCount
        {
            get { return dayCount; }
            set
            {
                dayCount = value; OnPropertyChanged();
            }
        }


        public RelayCommand ConfirmCommand { get; set; }


        public UserOrderViewModel()
        {
            ConfirmCommand = new RelayCommand(c =>
            {
                TotalPrice = DayCount * Car.RentPriceOneDay;


            });


        }


    }
}
