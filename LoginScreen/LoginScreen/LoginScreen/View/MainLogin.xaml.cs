using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginScreen.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginScreen.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainLogin: ContentPage
    {
        public MainLogin()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColour;
            Label_Username.TextColor = Constants.LoginTextColour;
            Label_Password.TextColor = Constants.LoginTextColour;
            LoginIcon.HeightRequest = Constants.LogoHeight;
            ActiveSpinner.IsVisible = false;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcess(s, e);
        }

        void SignInProcess(object sender, EventArgs e)
        {
            //This calls a new object from the 'User' class
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            // Calls bool function 'CheckInfo' from 'User' class to see if the login was successful and if not then try again
            if (user.CheckInfo())
            {
                DisplayAlert("Login", "Login Successful", "OK");
            }
            else
            {
                DisplayAlert("Login", "Login Unsuccessful. Either username or password is invalid", "OK");
            }
        }
    }
}