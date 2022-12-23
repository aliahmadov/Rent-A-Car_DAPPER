using RentACar.Domain.Commands;
using RentACar.Domain.Views.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

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

        TimeSpan time;

        private DispatcherTimer dispatcherTimer;

        public StatusWindowViewModel viewModel { get; set; }
        public UserRentStatusViewModel()
        {
            viewModel = new StatusWindowViewModel();
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
                    var rent = App.DB.RentRepository.GetAll().FirstOrDefault(d => d.RentKey == RentKey);

                    var duration = (rent.RentEndDate - DateTime.Now).TotalDays;
                    var view = new StatusWindow();
                    view.DataContext = viewModel;

                    
                    time = TimeSpan.FromDays(duration);
                    dispatcherTimer = new DispatcherTimer();
                    dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
                    dispatcherTimer.Tick += DispatcherTimer_Tick;
                    dispatcherTimer.Start();

                    view.ShowDialog();
                    dispatcherTimer.Stop();

                }
                else
                {
                    MessageBox.Show("This rent key does not exist!");
                }
            });
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (time == TimeSpan.Zero) dispatcherTimer.Stop();
            else
            {
                time = time.Add(TimeSpan.FromSeconds(-1));
                viewModel.Text = time.ToString(@"dd\:hh\:mm\:ss");
            }

        }
    }
}
