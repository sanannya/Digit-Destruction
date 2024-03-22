using DigitDestruction.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitDestruction.ViewViewModels.Subtraction.SubEntryResults
{
    public class SubEntryResultsViewModel : BaseViewModel
    {
        private string _entryText;

        public SubEntryResultsViewModel(string entryText)
        {
            Title = TitlesSubtraction.SubEntryResultsTitle;
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
    }
}
