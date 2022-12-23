using RentACar.Domain.Commands;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace RentACar.Domain.ViewModels
{
    public class AdminShowRentsViewModel : BaseViewModel
    {

        private ObservableCollection<Rent> rents;

        public ObservableCollection<Rent> Rents
        {
            get { return rents; }
            set { rents = value; OnPropertyChanged(); }
        }

        private string duration;

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }


        public RelayCommand BackCommand { get; set; }

        public AdminShowRentsViewModel()
        {
            Rents = new ObservableCollection<Rent>(App.DB.RentRepository.GetAll());
            BackPage = App.MyGrid.Children[0];
            BackCommand = new RelayCommand(c =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(BackPage);
            });
        }

    }
}
