using RentACar.Domain.Commands;
using RentACar.Domain.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.ViewModels
{
    public class AdminHomeViewModel:BaseViewModel
    {
        public RelayCommand BackCommand { get; set; }

        public RelayCommand ShowCarsCommand { get; set; }

        public RelayCommand ShowRentsCommand { get; set; }

        public RelayCommand ModifyCarsCommand { get; set; }


        public AdminHomeViewModel()
        {

            BackPage = App.MyGrid.Children[0];
            BackCommand = new RelayCommand(c =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(BackPage);
            });


            ShowCarsCommand = new RelayCommand(c =>
            {
                var view = new AdminShowCarsUC();
                var viewModel = new AdminShowCarsViewModel();
                view.DataContext = viewModel;

                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(view);
            });


            ShowRentsCommand = new RelayCommand(c =>
            {
                var view = new AdminShowRentsUC();
                var viewModel = new AdminShowRentsViewModel();
                view.DataContext = viewModel;

                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(view);
            });


            ModifyCarsCommand = new RelayCommand(c =>
            {
                var view = new AdminUpdateCarsUC();
                var viewModel = new AdminModifyCarsViewModel();
                view.DataContext = viewModel;

                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(view);
            });
        }
    }
}
