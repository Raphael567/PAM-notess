namespace notes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private async void LearnMore_Clicked(object sender, EventArgs e)
	{
		// � um m�todo ASS�NCRONO que abre um recurso (URI)
		await Launcher.OpenAsync("https://www.google.com.br");
	}
}