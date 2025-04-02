namespace Track_O_Meter;

public partial class CodePage : ContentPage
{
	public CodePage()
	{
		 InitializeComponent();

	}
    private async void OnNextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPage());

    }
}