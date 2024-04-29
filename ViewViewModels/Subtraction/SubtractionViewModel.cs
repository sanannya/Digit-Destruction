using DigitDestruction.Models;
using DigitDestruction.ViewViewModels.Subtraction.SubEntryResults;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DigitDestruction.ViewViewModels.Main.Subtraction
{
    public class SubtractionViewModel : BaseViewModel
    {
        public ICommand OnEntryClicked { get; }

        private string _entryText;
        public SubtractionViewModel()
        {
            Title = TitlesDivision.DivisionPageTitle;
            OnEntryClicked = new Command(OnEntryClickedAsync);
        }

        public string EntryText
        {
            get
            {
                return _entryText;
            }

            set
            {
                if (_entryText != value)
                    SetProperty(ref _entryText, value);
            }
        }

        public string SubProb
        {
            get
            {
                return "81 - 4 = ?";
            }
        }

        private async void OnEntryClickedAsync(object obj)
        {
            if (string.IsNullOrEmpty(_entryText.Trim()))
            {
                await Application.Current.MainPage.DisplayAlert(TitlesDivision.DivEntryResultsTitle, "Entry can’t be empty!", "Ok");
                return;
            }

            await Application.Current.MainPage.Navigation.PushAsync(new SubEntryResultsView(_entryText));
        }
        public ImageSource GetEmbImageSource
        {
            get
            {
                return ImageSource.FromFile("Images/logo.PNG");

            }
        }
    }
}
