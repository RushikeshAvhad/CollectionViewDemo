using CollectionViewDemo.MVVM.ViewModels;

namespace CollectionViewDemo.MVVM.Views;

public partial class LayoutsPage : ContentPage
{
	public LayoutsPage()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();
	}
}