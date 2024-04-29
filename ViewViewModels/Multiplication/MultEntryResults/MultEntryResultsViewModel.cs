using DigitDestruction.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitDestruction.ViewViewModels.Multiplication.MultEntryResults
{
    public class MultEntryResultsViewModel : BaseViewModel
    {
        private string _entryText;

        public MultEntryResultsViewModel(string entryText)
        {
            Title = TitlesMultiplication.MultEntryResultsTitle;
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
                return "incorrect!";
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
