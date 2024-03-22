namespace DigitDestruction.ViewViewModels.Multiplication.MultEntryResults;

public partial class MultEntryResultsView : ContentPage
{
    public MultEntryResultsView(string entryText)
    {
        InitializeComponent();
        BindingContext = new MultEntryResultsViewModel(entryText);
    }
}