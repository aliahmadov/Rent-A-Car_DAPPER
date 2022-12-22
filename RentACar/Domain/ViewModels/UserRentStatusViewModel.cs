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
    public class UserRentStatusViewModel : BaseViewModel
    {

        public RelayCommand BackCommand { get; set; }
        public RelayCommand ShowStatusCommand { get; set; }



        private string rentKey;

        public string RentKey
        {
            get { return rentKey; }
            set { rentKey = value; OnPropertyChanged(); }
        }

        public UserRentStatusViewModel()
        {
            BackPage = App.MyGrid.Children[0];

            BackCommand = new RelayCommand(c =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(BackPage);
            });


            ShowStatusCommand = new RelayCommand(c =>
            {
           
   
                if (App.DB.RentRepository.GetAll().Any(d => d.RentKey == RentKey))
                {
                    var view = new StatusWindow();
                    var viewModel = new StatusWindowViewModel();
                    view.DataContext = view;

                    view.ShowDialog();
                }
                else
                {
                    MessageBox.Show("This rent key does not exist!");
                }
            });
        }
    }
}
