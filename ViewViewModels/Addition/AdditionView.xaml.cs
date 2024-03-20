namespace DigitDestruction.ViewViewModels.Main.Addition;

public partial class AdditionView : ContentPage
{
	public AdditionView()
	{
		InitializeComponent();
		BindingContext = new AdditionViewModel();
	}
}