using DigitDestruction.Models;
using DigitDestruction.ViewViewModels.Multiplication.MultEntryResults;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DigitDestruction.ViewViewModels.Main.Multiplication
{
    public class MultiplicationViewModel : BaseViewModel
    {
        public ICommand OnEntryClicked { get; }

        private string _entryText;
        public MultiplicationViewModel()
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

        private async void OnEntryClickedAsync(object obj)
        {
            if (string.IsNullOrEmpty(_entryText.Trim()))
            {
                await Application.Current.MainPage.DisplayAlert(TitlesDivision.DivEntryResultsTitle, "Entry can’t be empty!", "Ok");
                return;
            }

            await Application.Current.MainPage.Navigation.PushAsync(new MultEntryResultsView(_entryText));
        }
    }
}
