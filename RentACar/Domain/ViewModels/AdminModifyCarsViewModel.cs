using RentACar.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.ViewModels
{
    public class AdminModifyCarsViewModel:BaseViewModel
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

            });

            AddCommand = new RelayCommand(c =>
            {

            });

            DeleteCommand = new RelayCommand(c =>
            {

            });
        }
    }
}
