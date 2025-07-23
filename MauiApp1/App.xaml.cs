using MauiApp1.Views;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Page4), typeof(Page4));
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}