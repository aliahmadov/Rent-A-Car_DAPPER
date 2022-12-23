using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace RentACar.Domain.ViewModels
{
    public class StatusWindowViewModel:BaseViewModel
    {

        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; OnPropertyChanged(); }
        }



        public double Duration { get; set; }

  

        public StatusWindowViewModel()
        {
         
        }

    }
}
