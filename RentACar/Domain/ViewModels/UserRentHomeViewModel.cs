using RentACar.Domain.Commands;
using RentACar.Domain.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RentACar.Domain.ViewModels
{
    public class UserRentHomeViewModel:BaseViewModel
    {

        public RelayCommand ShowCarsCommand { get; set; }

        public RelayCommand CheckStatusCommand { get; set; }

        public RelayCommand BackCommand { get; set; }

        public UserRentHomeViewModel()
        {

            BackPage = App.MyGrid.Children[0];            
            BackCommand = new RelayCommand(c =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(BackPage);
            });


            ShowCarsCommand = new RelayCommand(c =>
            {
                var view = new UserDisplayAllCarsUC();
                var viewModel = new UserDisplayAllCarsViewModel();
                view.DataContext = viewModel;


                for (int i = 0; i < App.DB.CarRepository.GetAll().Count(); i++)
                {
                    var carView = new UserShowCarUC();
                    var carVm = new UserShowCarUCViewModel();
                    carView.DataContext = carVm;

                    var car = App.DB.CarRepository.GetAll().Skip(i).First();
                    carVm.Car = car;

                    carView.Height = 150;
                    carView.Width = 900;

                    carView.Margin = new Thickness(10, 40, 10, 10);

                    view.productPanel.Children.Add(carView);
                }
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(view);
            });


            CheckStatusCommand = new RelayCommand(c =>
            {
                var view = new UserRentStatusUC();
                var viewModel = new UserRentStatusViewModel();
                view.DataContext = viewModel;

                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(view);
            });

        }
    }
}
