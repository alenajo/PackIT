using RMA_Tim6.ViewModels;

namespace RMA_Tim6.Views;

public partial class IntroScreenView : ContentPage
{
	public IntroScreenView()
	{
		InitializeComponent();
		this.BindingContext = new IntroScreenViewModel();
	}
}