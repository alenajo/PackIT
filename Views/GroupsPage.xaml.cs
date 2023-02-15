using RMA_Tim6.ViewModels;

namespace RMA_Tim6.Views;

public partial class GroupsPage : ContentPage
{
	public GroupsPage()
	{
		InitializeComponent();
        BindingContext = new GroupsViewModel();
    }

	private void AddItem_Clicked(object sender, EventArgs e)
	{

	}
}