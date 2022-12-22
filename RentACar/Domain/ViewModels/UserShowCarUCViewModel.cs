using RentACar.Domain.Commands;
using RentACar.Domain.Entities;
using RentACar.Domain.Views.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.ViewModels
{
    public class UserShowCarUCViewModel :BaseViewModel
    {

        private Car car;

        public Car Car
        {
            get { return car; }
            set { car = value; OnPropertyChanged(); }
        }

        public RelayCommand OrderCommand { get; set; }

        public RelayCommand DetailCommand { get; set; }



        public UserShowCarUCViewModel()
        {

            DetailCommand = new RelayCommand(c =>
            {
                var view = new ShowCarDetailsWindow();
                var viewModel = new ShowCarDetailsViewModel();
                view.DataContext = viewModel;

                viewModel.Car = Car;

                view.ShowDialog();
            });


            OrderCommand = new RelayCommand(c =>
            {
                var view = new UserOrderWindow();
                var viewModel = new UserOrderViewModel();
                view.DataContext=viewModel;

                viewModel.Car = Car;
                view.ShowDialog();
            });
        }
    }
}
