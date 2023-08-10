using Prism.Mvvm;

namespace FireflyUI.ViewModels
{
    public class DashboardViewModel : BindableBase
    {
        private string _hello;
        public string Hello
        {
            get { return _hello; }
            set { SetProperty(ref _hello, value); }
        }
        public DashboardViewModel()
        {
            Hello = "Hello World!";
        }
    }
}
