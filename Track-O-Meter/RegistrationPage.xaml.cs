using System;
using Microsoft.Maui.Controls;

namespace Track_O_Meter
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void OnNextClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CodePage());

        }
    }
}
