using System;

using Xamarin.Forms;

using DNNConnect.Security;

namespace DNNConnect.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            this.btnLogin.Clicked += this.btnLoginClick;
        }

        async void btnLoginClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(this.txtPassword.Text))
            {
                var token = await Authorization.GetTokenAsync(this.txtUsername.Text, this.txtPassword.Text);

                if (token != null)
                {
                    App.BEARER_TOKEN = token.AccessToken;
                }

                App.SetMainPage(new Items(), true);
            }
        }
    }
}
