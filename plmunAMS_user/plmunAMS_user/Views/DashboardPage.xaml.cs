using plmunAMS_user.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace plmunAMS_user.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DashboardPage : TabbedPage
    {
        public DashboardPage ()
		{
			InitializeComponent ();
            this.BindingContext = new DashboardViewModel();
        }

        async void SignOut_Clicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();
        }
    }
}