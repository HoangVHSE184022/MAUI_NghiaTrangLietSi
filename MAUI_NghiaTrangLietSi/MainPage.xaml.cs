namespace MAUI_NghiaTrangLietSi
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAboutUsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///AboutUsPage");

        }
    }

}
