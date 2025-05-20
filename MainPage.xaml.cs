

namespace NylanderMobile
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void NorthClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///NorthGallery");

        }
        private async void SouthClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///SouthGallery");

        }
        private async void ArchiveClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///Archives");

        }
    }
    }


