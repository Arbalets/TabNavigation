using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace TabNavigation.ViewModels
{
	public class MyMasterDetailPageViewModel : BindableBase
    {
        public MyMasterDetailPageViewModel(INavigationService navigationService)
        {
            NavigateCommand = new DelegateCommand<string>(async x => await navigationService.NavigateAsync(x));
        }

	    public DelegateCommand<string> NavigateCommand { get; }
    }
}
