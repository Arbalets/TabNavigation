using Prism;
using Prism.Ioc;
using TabNavigation.ViewModels;
using TabNavigation.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Autofac;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TabNavigation
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MyMasterDetailPage/NavigationPage/MyTabbedPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MyMasterDetailPage>();
            containerRegistry.RegisterForNavigation<MyTabbedPage>();
            containerRegistry.RegisterForNavigation<TabPageA>();
            containerRegistry.RegisterForNavigation<TabPageB>();
            containerRegistry.RegisterForNavigation<TabPageC>();
            containerRegistry.RegisterForNavigation<OtherPage>();
        }
    }
}
