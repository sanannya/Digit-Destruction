namespace DigitDestruction.ViewViewModels.Main.Multiplication;

public partial class MultiplicationView : ContentPage
{
	public MultiplicationView()
	{
		InitializeComponent();
        BindingContext = new MultiplicationViewModel();
    }
}