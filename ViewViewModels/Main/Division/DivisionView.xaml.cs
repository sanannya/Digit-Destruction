namespace DigitDestruction.ViewViewModels.Main.Division;

public partial class DivisionView : ContentPage
{
	public DivisionView()
	{
		InitializeComponent();
        BindingContext = new DivisionViewModel();
    }
}