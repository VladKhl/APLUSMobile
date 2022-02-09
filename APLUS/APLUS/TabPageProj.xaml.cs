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
    public partial class TabPageProj : TabbedPage
    {
        readonly ProjectModel project;
        public static string NameTit;

        protected override void OnAppearing()
        {
            FillInfo();
            base.OnAppearing();
        }
        public TabPageProj(ProjectModel project)
        {
            this.project = project;
            NameTit = project.Name;
            InitializeComponent();
            FillInfo();
        }

        public void FillInfo()
        {
            descrip.Text = project.Description;
            adres.Text = project.Address;
            email.Text = project.Email;
            phone.Text = project.TelephoneNumber;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditPage(project));
        }
    }
}