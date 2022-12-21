using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.ViewModels
{
    public class EnterIdViewModel:BaseViewModel
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value;OnPropertyChanged(); }
        }


    }
}
