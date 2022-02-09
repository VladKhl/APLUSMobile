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
    public partial class EditPage : ContentPage
    {
        readonly ProjectModel project;
        public EditPage(ProjectModel project)
        {
            this.project = project;
            InitializeComponent();
            FillFields();
        }

        public void FillFields()
        {
            name.Text = project.Name;
            decr.Text = project.Description;
            phone.Text = project.TelephoneNumber;
            email.Text = project.Email;
            adres.Text = project.Address;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("", $"Вы точно хотите удалить {project.Name}?", "Удалить", "Отмена");
            if (result)
            {
                try
                {
                    App.db.DelProj(project.Id);
                    await DisplayAlert("", "Проект успешно удален", "Ok");
                    await Navigation.PushAsync(new Projects());
                }
                catch
                {
                    await DisplayAlert("", "Не удалось удалить", "Ok");
                    await Navigation.PopAsync();
                }
            }
        }

        private async void enter_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("", $"Вы точно хотите изменить {project.Name}?", "Изменить", "Отмена");

            if (result)
            {
                project.Name = name.Text;
                project.Description = decr.Text;
                project.TelephoneNumber = phone.Text;
                project.Address = adres.Text;
                project.Email = email.Text;

                try
                {
                    App.db.SaveItem(project);
                    await DisplayAlert("", "Проект успешно изменен", "Ok");
                    await Navigation.PushAsync(new TabPageProj(project));
                }
                catch
                {
                    await DisplayAlert("", "Не удалось изменить", "Ok");
                    await Navigation.PopAsync();
                }
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}