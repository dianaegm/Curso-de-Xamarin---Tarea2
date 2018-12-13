using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace Proyecto
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {

        }

        async void Login_Clicked(object sender, EventArgs args)         {              await Navigation.PushAsync(new MainPage());         } 
    }
}
