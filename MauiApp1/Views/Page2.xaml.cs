using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class Page2 : ContentPage
{
	public Page2(Page2ViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
    }
}