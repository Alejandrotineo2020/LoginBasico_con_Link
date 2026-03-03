namespace loginbasico1
{
    public partial class MainPage : ContentPage 
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private async void logginBTN_Clicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            if (username == "alejandro" && password == "12345")
            {
                await DisplayAlert("Éxito", "¡Bienvenido! Abriendo tu canal de YouTube...", "OK");

             
                try
                {
                    await Launcher.Default.OpenAsync("https://www.youtube.com/@AlejandroMTineoMoreta");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Error", $"No pudimos abrir YouTube: {ex.Message}", "OK");
                }

           
            }
            else
            {
                await DisplayAlert("Error", "Usuario o contraseña incorrectos.", "OK");
            }
        }
    }

}

