namespace DigitDestruction.ViewViewModels.Subtraction.SubEntryResults;

public partial class SubEntryResultsView : ContentPage
{
    public SubEntryResultsView(string entryText)
    {
        InitializeComponent();
        BindingContext = new SubEntryResultsViewModel(entryText);
    }
}