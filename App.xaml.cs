using DigitDestruction.ViewViewModels.Main;

namespace DigitDestruction
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainView();
        }
    }
}