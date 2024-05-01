using DigitDestruction.Models;
using DigitDestruction.ViewViewModels.Main;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DigitDestruction.ViewViewModels.Subtraction.SubEntryResults
{
    public class SubEntryResultsViewModel : BaseViewModel
    {
        private string _entryText;
        public ICommand OnBTMClicked { get; }

        public SubEntryResultsViewModel(string entryText)
        {
            Title = TitlesSubtraction.SubEntryResultsTitle;
            _entryText = entryText;
            OnBTMClicked = new Command(OnBTMClickedAsync);
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

        public string ansVal
        {
            get
            {
                return "Incorrect!";
            }
        }
        public ImageSource GetEmbImageSource
        {
            get
            {
                return ImageSource.FromFile("Images/logo.PNG");

            }
        }

        private async void OnBTMClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new MainView());
        }
    }
}
