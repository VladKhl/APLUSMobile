using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static APLUS.MainPage;

[assembly: Dependency(typeof(SQLite_Android))]
namespace APLUS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public interface ISQLite
        {
            string GetDatabasePath(string filename);
        }
        public class SQLite_Android : ISQLite
        {
            public SQLite_Android() { }
            public string GetDatabasePath(string sqliteFilename)
            {
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                var path = Path.Combine(documentsPath, sqliteFilename);
                return path;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registration());
        }

        private void enter_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Projects());
        }
    }
}
