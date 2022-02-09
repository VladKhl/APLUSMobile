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
    public partial class Projects : ContentPage
    {
        public Projects()
        {
            InitializeComponent();
            UpdateList();
            NavigationPage.SetHasBackButton(this, false);
        }

        private void projectList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new TabPageProj((ProjectModel)e.Item));
        }

        protected override void OnAppearing()
        {
            UpdateList();
            base.OnAppearing();
        }

        public void UpdateList()
        {
            projectList.ItemsSource = null;
            projectList.ItemsSource = App.Db.GetProjects();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPage());
        }
    }
}