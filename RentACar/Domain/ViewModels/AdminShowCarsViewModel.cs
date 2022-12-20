using RentACar.Domain.Commands;
using RentACar.Domain.Entities;
using RentACar.Domain.Views.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.ViewModels
{
    public class AdminShowCarsViewModel : BaseViewModel
    {

        private ObservableCollection<Car> allCars;

        public ObservableCollection<Car> AllCars
        {
            get { return allCars; }
            set { allCars = value; OnPropertyChanged(); }
        }

        private Car selectedCar;    

        public Car SelectedCar
        {
            get { return selectedCar; }
            set { selectedCar = value;OnPropertyChanged(); }
        }


        public RelayCommand BackCommand { get; set; }

        public RelayCommand SelectedCarCommand { get; set; }
        public AdminShowCarsViewModel()
        {
            AllCars = new ObservableCollection<Car>(App.DB.CarRepository.GetAll());

            BackPage = App.MyGrid.Children[0];
            BackCommand = new RelayCommand(c =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(BackPage);
            });


            SelectedCarCommand = new RelayCommand(c =>
            {
                var view = new ShowCarDetailsWindow();
                var viewModel = new ShowCarDetailsViewModel();
                view.DataContext = viewModel;

                viewModel.Car = SelectedCar;

                view.ShowDialog();
            });
        
        }


    }
}
