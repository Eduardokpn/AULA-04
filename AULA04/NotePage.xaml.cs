namespace AULA04;

public partial class NotePage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    public NotePage()
    {
        InitializeComponent();
        if (File.Exists(_fileName))
            texteditor.Text = File.ReadAllText(_fileName);
    }
    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        // Save the file.
        File.WriteAllText(_fileName, texteditor.Text);
        await DisplayAlert("Arquivo Gravado", "O seu Arquivo foi Gravado com Sucesso!!", "CONTINUAR");
    }
    private async void DeleteButton_Clicked(object sender, EventArgs e)
    {
        // Delete the file.
        if (File.Exists(_fileName))
            File.Delete(_fileName);
       texteditor.Text = string.Empty;
        await DisplayAlert("Arquivo Gravado", "O seu Arquivo foi Gravado com Sucesso!!", "CONTINUAR");

    }
}