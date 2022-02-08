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
    public partial class EditPage : ContentPage
    {
        public static string NameTit;
        public EditPage(string tit)
        {
            NameTit = tit;
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("", $"Вы точно хотите удалить {NameTit}?", "Удалить", "Отмена");
        }

        private void enter_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", $"Вы точно хотите изменить {NameTit}?", "Изменить", "Отмена");
        }
    }
}