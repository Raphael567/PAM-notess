namespace notes;

public partial class NotesPage : ContentPage
{
    //DCIM/MEDIA/com.whatsapp.media
    string path = Path.Combine(FileSystem.AppDataDirectory,"nota.txt");
    string content = string.Empty;

	public NotesPage()
	{
		InitializeComponent();
	}

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        //Pegar o que o usu�rio escreveu
        content = FileEditor.Text;

        //Criar o arquivo com esse conte�do
        File.WriteAllText(path, content);
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {

    }
}