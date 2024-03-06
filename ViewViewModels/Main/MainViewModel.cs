using DigitDestruction.Models;
using DigitDestruction.ViewViewModels.Main.Addition;
using DigitDestruction.ViewViewModels.Main.Division;
using DigitDestruction.ViewViewModels.Main.Multiplication;
using DigitDestruction.ViewViewModels.Main.Subtraction;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DigitDestruction.ViewViewModels.Main
{
    public class MainViewModel: BaseViewModel
    {
        public string TitleAddition { get; set; } = TitlesMain.AdditionTitle;
        public string TitleSubtraction { get; set; } = TitlesMain.SubtractionTitle;
        public string TitleMultiplication { get; set; } = TitlesMain.MultiplicationTitle;
        public string TitleDivision { get; set; } = TitlesMain.DivisionTitle;

        public ICommand OnClickedAddition { get; set; }
        public ICommand OnClickedSubtraction { get; set; }
        public ICommand OnClickedMultiplication { get; set; }
        public ICommand OnClickedDivision { get; set; }


        public MainViewModel()
        {
            Title = TitlesMain.MainTitle;

            OnClickedAddition = new Command(OnClickedAsyncAddition);
            OnClickedSubtraction = new Command(OnClickedAsyncSubtraction);
            OnClickedMultiplication = new Command(OnClickedAsyncMultiplication);
            OnClickedDivision = new Command(OnClickedAsyncDivision);
        }

        private async void OnClickedAsyncAddition()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AdditionView());
        }
        private async void OnClickedAsyncSubtraction()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SubtractionView());
        }
        private async void OnClickedAsyncMultiplication()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new MultiplicationView());
        }
        private async void OnClickedAsyncDivision()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DivisionView());
        }
    }
}
