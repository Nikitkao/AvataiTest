using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class Page4 : ContentPage
{
	public Page4(Page4ViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
    }
}