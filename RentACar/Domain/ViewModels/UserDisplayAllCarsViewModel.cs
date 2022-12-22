using RentACar.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.ViewModels
{
    public class UserDisplayAllCarsViewModel:BaseViewModel
    {

        public RelayCommand BackCommand { get; set; }



        public UserDisplayAllCarsViewModel()
        {
            BackPage = App.MyGrid.Children[0];

            BackCommand = new RelayCommand(c =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(BackPage);
            });
        }
    }
}
