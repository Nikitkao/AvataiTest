using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class Page3 : ContentPage
{
    public Page3(Page3ViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
    }

    private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
    {
        if (BindingContext is Page3ViewModel vm)
            vm.OnPageLoaded();
    }
}