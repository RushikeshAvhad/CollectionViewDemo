namespace CollectionViewDemo.MVVM.Views;

public partial class EmptyView : ContentPage
{
	public EmptyView()
	{
		InitializeComponent();
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
		var isToggle = e.Value;
		collectionView.EmptyView = isToggle ? Resources["NoResultsView"] :
			Resources["ConnectivityIssue"];
    }
}