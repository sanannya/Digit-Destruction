namespace DigitDestruction.ViewViewModels.Main.Subtraction;

public partial class SubtractionView : ContentPage
{
	public SubtractionView()
	{
		InitializeComponent();
        BindingContext = new SubtractionViewModel();
    }
}