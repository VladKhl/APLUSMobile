using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace APLUS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registration());
        }

        private void enter_Clicked(object sender, EventArgs e)
        {
            var lst = App.Db.GetClients();
            bool state = false;

            foreach (var item in lst)
            {
                if (item.Login == login.Text)
                {
                    if (item.Password == pass.Text)
                    {
                        state = true;
                        Navigation.PushAsync(new Projects());
                    }
                }
            }

            if (!state)
                DisplayAlert("", "Неправильный логин или пароль", "Ok");
        }
    }
}
