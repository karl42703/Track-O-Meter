using Microsoft.Maui.Controls;

namespace Track_O_Meter
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnCreateAccountClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // Add login validation here if needed
            await DisplayAlert("Login", "Logging in...", "OK");
        }
    }
}
