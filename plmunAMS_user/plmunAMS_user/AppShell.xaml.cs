using plmunAMS_user.ViewModels;
using plmunAMS_user.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace plmunAMS_user
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
