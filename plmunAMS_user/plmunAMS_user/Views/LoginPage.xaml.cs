using plmunAMS_user.Models;
using plmunAMS_user.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace plmunAMS_user.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        SqlConnection sqlConnection;
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();

            sqlConnection = new SqlConnection(Connection.sqlconn);
        }

        public void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        async void Login_Clicked(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                string queryString = $"SELECT * FROM dbo.students WHERE [user]='{UserLogIn.Text}'";
                SqlCommand command = new SqlCommand(queryString, sqlConnection);
                
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Connection.user = reader["user"].ToString();
                    Connection.pass = reader["pass"].ToString();



                    if (UserLogIn.Text == Connection.user && PassLogIn.Text == Connection.pass)
                    {
                        await DisplayAlert("Alert", "Success!", "OK");
                        
                        Connection.id = Convert.ToInt32(reader["Id"]);
                        Connection.firstName = reader["firstname"].ToString();

                        Application.Current.Properties["IsLoggedIn"] = Boolean.TrueString;
                        
                        Navigation.InsertPageBefore(new DashboardPage(), this);
                        await Navigation.PopAsync();
                    }
                    else
                    {
                        Connection.user = "";
                        Connection.pass = "";
                        await DisplayAlert("Alert", "ERROR!", "OK");
                    }
                }
                reader.Close();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}