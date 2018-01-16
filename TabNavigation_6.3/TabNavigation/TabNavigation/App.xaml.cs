using TabNavigation.Views;
using Prism.Autofac;
using Prism.Autofac.Forms;
using Xamarin.Forms;

namespace TabNavigation
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MyMasterDetailPage/NavigationPage/MyTabbedPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MyMasterDetailPage>();
            Container.RegisterTypeForNavigation<MyTabbedPage>();
            Container.RegisterTypeForNavigation<TabPageA>();
            Container.RegisterTypeForNavigation<TabPageB>();
            Container.RegisterTypeForNavigation<TabPageC>();
            Container.RegisterTypeForNavigation<OtherPage>();
        }
    }
}
