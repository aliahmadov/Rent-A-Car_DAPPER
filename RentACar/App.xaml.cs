using RentACar.DataAccess.Abstractions;
using RentACar.DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RentACar
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static Grid MyGrid { get; set; }

        public static IUnitOfWork DB { get; set; }
        public App()
        {
            DB = new UnitOfWork();
        }

    }
}
