using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.ViewModels
{
    public class ValidateWindowViewModel:BaseViewModel
    {

        private string first;

        public string First
        {
            get { return first; }
            set { first = value; OnPropertyChanged(); }
        }


        private string second;

        public string Second
        {
            get { return second; }
            set { second = value;OnPropertyChanged(); }
        }


        private string third;

        public string Third
        {
            get { return third; }
            set { third = value;OnPropertyChanged(); }
        }



        private string fourth;

        public string Fourth
        {
            get { return fourth; }
            set { fourth = value;OnPropertyChanged(); }
        }


        private string fifth;

        public string Fifth
        {
            get { return fifth; }
            set { fifth = value;OnPropertyChanged(); }
        }




        private string sixth;

        public string Sixth
        {
            get { return sixth; }
            set { sixth = value;OnPropertyChanged(); }
        }







    }
}
