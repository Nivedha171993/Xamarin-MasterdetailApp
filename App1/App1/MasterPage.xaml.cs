using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class MasterPage : ContentPage
    {
        public ListView listView { get { return lstScreens; } }

        public ObservableCollection<ClassFiles.MasterPageItem> masterpageItem { get; set; }
        public MasterPage()
        {
            InitializeComponent();

            masterpageItem = new ObservableCollection<ClassFiles.MasterPageItem>();
            masterpageItem.Add(new ClassFiles.MasterPageItem
            {
                Title = "Login",
                TargetType = typeof(Pages.LoginPage)
            });

            masterpageItem.Add(new ClassFiles.MasterPageItem
            {
                Title = "Sign Up",
                TargetType = typeof(Pages.SignUp)
            });
            listView.ItemsSource = masterpageItem;
            //var MainPage = new NavigationPage(new Pages.LoginPage(masterpageItem));
        }
    }
}
