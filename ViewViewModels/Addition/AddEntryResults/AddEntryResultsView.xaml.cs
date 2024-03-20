namespace DigitDestruction.ViewViewModels.Addition.AddEntryResults;

public partial class AddEntryResultsView : ContentPage
{
	public AddEntryResultsView(string entryText)
	{
		InitializeComponent();
		BindingContext = new AddEntryResultsViewModel(entryText);
	}
}