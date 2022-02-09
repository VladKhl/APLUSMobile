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
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void enter_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.db.SaveItem(new ProjectModel(name.Text, descr.Text, phone.Text, email.Text,adres.Text));
                DisplayAlert("", "Проект успешно добавлен", "Ok");
            }
            catch
            {
                DisplayAlert("", "Не удалось добавить проект", "Ok");
            }

            Navigation.PopAsync();
        }
    }
}