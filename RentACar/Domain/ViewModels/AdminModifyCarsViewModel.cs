
using RentACar.Domain.Commands;
using RentACar.Domain.Views.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RentACar.Domain.ViewModels
{
    public class AdminModifyCarsViewModel : BaseViewModel
    {

        public RelayCommand UpdateCommand { get; set; }

        public RelayCommand AddCommand { get; set; }

        public RelayCommand DeleteCommand { get; set; }

        public RelayCommand BackCommand { get; set; }

        public AdminModifyCarsViewModel()
        {

            BackPage = App.MyGrid.Children[0];

            BackCommand = new RelayCommand(c =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(BackPage);
            });

            UpdateCommand = new RelayCommand(c =>
            {

                var enterView = new EnterIDWindow();
                var enterVM = new EnterIdViewModel();
                enterView.DataContext = enterVM;

                enterView.ShowDialog();


                if (App.DB.CarRepository.GetAll().Any(d => d.Id == enterVM.Id))
                {
                    var car = App.DB.CarRepository.GetAll().FirstOrDefault(d => d.Id == enterVM.Id);

                    var view = new UpdateWindow();
                    var viewModel = new UpdateWindowViewModel();
                    view.DataContext = viewModel;

                    viewModel.Car = car;
                    view.ShowDialog();

                    App.DB.CarRepository.UpdateData(viewModel.Car);

                    MessageBox.Show($"Car has been successfully updated with ID {enterVM.Id}");

                }
            });

            AddCommand = new RelayCommand(c =>
            {
                var view = new InsertWindow();
                var viewModel = new InsertWindowViewModel();
                view.DataContext = viewModel;

                view.ShowDialog();

                var car = viewModel.Car;

                App.DB.CarRepository.AddData(car);

                MessageBox.Show("Car has been added successfully");

            });

            DeleteCommand = new RelayCommand(c =>
            {
                var view = new DeleteWindow();
                var viewModel = new DeleteWindowViewModel();
                view.DataContext = viewModel;

                view.ShowDialog();
                if (App.DB.CarRepository.GetAll().Any(d => d.Id == viewModel.Id))
                {
                    var car = App.DB.CarRepository.GetAll().FirstOrDefault(e => e.Id == viewModel.Id);
                    App.DB.CarRepository.DeleteData(car);
                    MessageBox.Show($"Car has been deleted successfuly with ID {car.Id}");
                }
                else
                {
                    MessageBox.Show($"Car with ID {viewModel.Id} does not exist!\nEnter valid ID");
                }
            });
        }
    }
}
