using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Pages;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            MasterBehavior = MasterBehavior.Popover;//new
            MasterPage.listView.ItemSelected += OnItemSelected;
            Master = MasterPage;
            NavigationPage page = new NavigationPage(new Pages.LoginPage(MasterPage.masterpageItem));
            Detail = page;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ClassFiles.MasterPageItem;
            if (item != null)
            {
                Page displayPage = (Page)Activator.CreateInstance(item.TargetType);
                NavigationPage page = new NavigationPage(displayPage);
                Detail = page;


                //Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                MasterPage.listView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
