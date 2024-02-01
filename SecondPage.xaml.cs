namespace TelerikListViewCleanup;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    private void Back_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}