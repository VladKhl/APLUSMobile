using APLUS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APLUS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (pass1.Text == pass2.Text)
                {
                    App.Db.SaveClient(new Client(mail.Text, login.Text, pass1.Text));
                    DisplayAlert("", "Вы успешно зарегистрировались", "Ok");
                    Navigation.PushAsync(new MainPage());
                }
                else if (pass1.Text != pass2.Text)
                {
                    DisplayAlert("", "Пароли не совпадают", "Ok");
                }
            }
            catch
            {
                DisplayAlert("", "Введите корректные данные", "Ok");
            }
        }
    }
}