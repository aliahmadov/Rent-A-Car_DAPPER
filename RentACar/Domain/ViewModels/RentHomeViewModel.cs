using RentACar.Domain.Commands;
using RentACar.Domain.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.ViewModels
{
    public class RentHomeViewModel:BaseViewModel
    {

        public RelayCommand AdminCommand { get; set; }


        public RelayCommand ClientCommand { get; set; }


        public RentHomeViewModel()
        {
            AdminCommand = new RelayCommand(c =>
            {
                var view = new AdminHomeUC();
                var viewModel=new AdminHomeViewModel();
                view.DataContext = viewModel;

                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(view);
            });

            ClientCommand = new RelayCommand(c =>
            {

            });

          
        }
    
    }
}
