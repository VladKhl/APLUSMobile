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

        static List<Project> projects;
        public Projects()
        {
            InitializeComponent();
            GetProjects();
            projectList.ItemsSource = projects;
        }

        private void projectList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new TabPageProj(projects[e.ItemIndex].Name));
        }

        public static void GetProjects()
        {
            projects = new List<Project>();
            for (int i = 1; i <= 18; i++)
                projects.Add(new Project($"Проект {i}"));
        }
    }
}