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
        public static string NameTit;
        public TabPageProj(string titl)
        {
            NameTit = titl;
            InitializeComponent();
        }
    }
}