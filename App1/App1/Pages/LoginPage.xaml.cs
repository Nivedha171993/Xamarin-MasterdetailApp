using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace App1.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true); //title bar
        }
        public LoginPage(ObservableCollection<ClassFiles.MasterPageItem> masteritem)
        {
            // DisplayAlert("Login", "masteritem.received", "OK");
            masteritem.Add(new ClassFiles.MasterPageItem
            {
                Title = "Page1",
                TargetType = typeof(Pages.Item1)
            });
            masteritem.Add(new ClassFiles.MasterPageItem
            {
                Title = "Page2",
                TargetType = typeof(Pages.Item2)
            });         
        }

        async void Login_Procedure(object sender, EventArgs e)
        {
            //if (EntryUsername.Text!="" && EntryPassword.Text!="" )
            //{
            //    if (EntryUsername.Text.Equals("Admin") && EntryPassword.Text.Equals("123"))
            //    {
                    Navigation.InsertPageBefore(new Pages.Item1(), this);//Navigate to Home page in master details relation
                    await Navigation.PopToRootAsync();
                    //var masterpageItem = new ObservableCollection<ClassFiles.MasterPageItem>();
                    //masterpageItem.Add(new ClassFiles.MasterPageItem
                    //{
                    //    Title = "Page1",
                    //    TargetType = typeof(Pages.Item1)
                    //});
                    //masterpageItem.Add(new ClassFiles.MasterPageItem
                    //{
                    //    Title = "Page2",
                    //    TargetType = typeof(Pages.Item2)
                    //});

                    //NavigationPage page = new NavigationPage(new MasterPage(masterpageItem));

                    //listView.ItemsSource = masterpageItem;
            //    }
            //    else
            //    {
            //        gLogin.RowDefinitions[1].Height = 40;
            //        Error_label.IsVisible = true;
            //        Error_label.Text = "Please Enter valid Credentials";
            //    }
            //}
            //else
            //{
            //    gLogin.RowDefinitions[1].Height = 40;
            //    Error_label.IsVisible = true;
            //    Error_label.Text = "Missing Credentials";
            //}
        }
    }
}
