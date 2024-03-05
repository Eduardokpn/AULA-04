namespace AULA04;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();

    }

    private void LearnMore_Clicked(object sender, EventArgs e)
    {

        Launcher.Default.OpenAsync("https://www.google.com/search?q=Eduardo&rlz=1C1FCXM_pt-PTBR998BR998&oq=Eduardo&aqs=chrome..69i57j0i512j46i512l3j69i60l3.1904j0j9&sourceid=chrome&ie=UTF-8");
    }

  
}