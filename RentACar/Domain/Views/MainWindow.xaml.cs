using RentACar.DataAccess.Concretes;
using RentACar.Domain.Entities;
using RentACar.Domain.ViewModels;
using RentACar.Domain.Views.UserControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace RentACar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    /// 


    public partial class MainWindow : Window
    {
   


        public MainWindow()
        {
            InitializeComponent();

            var view = new RentHomeUC();
            var viewModel = new RentHomeViewModel();
            view.DataContext = viewModel;

            App.MyGrid = MyGrid;

            App.MyGrid.Children.Add(view);

            
        }
    }
}
