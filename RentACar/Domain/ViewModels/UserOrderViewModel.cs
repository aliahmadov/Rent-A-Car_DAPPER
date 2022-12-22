using RentACar.Domain.Commands;
using RentACar.Domain.Entities;
using RentACar.Domain.Views.Windows;
using RentACar.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RentACar.Domain.ViewModels
{
    public class UserOrderViewModel : BaseViewModel
    {

        public Car Car { get; set; }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(); }
        }


        private decimal totalPrice;

        public decimal TotalPrice
        {
            get { return totalPrice; }
            set
            {
                totalPrice = value;
                OnPropertyChanged();
            }
        }


        private int dayCount;

        public int DayCount
        {
            get { return dayCount; }
            set
            {
                dayCount = value; OnPropertyChanged();
            }
        }


        public RelayCommand ConfirmCommand { get; set; }


        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }


        private string GetKey()
        {
            Random random = new Random();
            while (true)
            {
                int number = random.Next();

                if (!App.DB.RentRepository.GetAll().Any(c => c.RentKey == number.ToString()))
                {
                    return number.ToString();
                }
            }
        }

        public UserOrderViewModel()
        {
            ConfirmCommand = new RelayCommand(c =>
            {

                if (DayCount == 3)
                {
                    TotalPrice = Car.RentPriceThreeDays;
                }
                else if (DayCount == 7) TotalPrice = Car.RentPriceOneWeek;
                else TotalPrice = DayCount * Car.RentPriceOneDay;


                if (DayCount > 0)
                {
                    if (IsValidEmail(Email))
                    {
                        Random random = new Random();
                        int code = random.Next(123456, 987654);
                        EmailHelper.SendMailToValidate(code.ToString(), Email);
                        MessageBox.Show("Code has been sent to your email, please check!");

                        var view = new ValidationWindow();
                        var viewModel = new ValidateWindowViewModel();
                        view.DataContext = viewModel;

                        view.ShowDialog();
                        var inputCode = viewModel.First + viewModel.Second + viewModel.Third + viewModel.Fourth +
                        viewModel.Fifth + viewModel.Sixth;

                        if (code.ToString() == inputCode)
                        {
                            view.Close();
                            MessageBox.Show("Validation is done!");



                            Rent rent = new Rent
                            {
                                RentStartDate = DateTime.Now,
                                RentEndDate = DateTime.Now.AddDays(DayCount),
                                CarId = Car.Id,
                                RentKey = GetKey(),
                                 Car=Car
                            };

                            App.DB.RentRepository.AddData(rent);

                            EmailHelper.SendMailToInform(rent, Email, TotalPrice);

                            MessageBox.Show("Your rent process has been done successfully\nPlease check email for detailed info!");

                        }

                        else
                        {
                            MessageBox.Show("Your input was incorrect");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter valid email address");
                    }
                }

            });


        }


    }
}
