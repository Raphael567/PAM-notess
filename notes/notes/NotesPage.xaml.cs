namespace notes;

public partial class NotesPage : ContentPage
{
    //DCIM/MEDIA/com.whatsapp.media
    string path = Path.Combine(FileSystem.AppDataDirectory,"notes.txt");
    string content = "";

	public NotesPage()
	{
		InitializeComponent();
        if (File.Exists(path))
        {
            //Carrega o conte�do do arquivo no editor de texto
            FileEditor.Text = File.ReadAllText(path);
        }
	}

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        //Pegar o que o usu�rio escreveu
        content = FileEditor.Text;

        //Criar o arquivo com esse conte�do
        File.WriteAllText(path, content);
        DisplayAlert("Sucesso", "Arquivo salvo com sucesso", "OK");
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            FileEditor.Text = "";
            //Alert
            DisplayAlert("Sucesso", "Arquivo deletado com sucesso", "OK");
        }
    }
}