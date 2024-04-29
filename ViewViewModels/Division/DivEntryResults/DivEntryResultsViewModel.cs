using DigitDestruction.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitDestruction.ViewViewModels.Division.DivEntryResults
{
    public class DivEntryResultsViewModel : BaseViewModel
    {
        private string _entryText;
        private string _ansVal;

        public DivEntryResultsViewModel(string entryText)
        {
            Title = TitlesDivision.DivEntryResultsTitle;
            _entryText = entryText;
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
                return "Correct!";
            }
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
