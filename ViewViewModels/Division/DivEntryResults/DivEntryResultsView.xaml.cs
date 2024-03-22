namespace DigitDestruction.ViewViewModels.Division.DivEntryResults;

public partial class DivEntryResultsView : ContentPage
{
    public DivEntryResultsView(string entryText)
    {
        InitializeComponent();
        BindingContext = new DivEntryResultsViewModel(entryText);
    }
}