using MWPro.ViewModel.Base;
using MWPro.ViewModel.Page;

namespace MWPro.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private PageViewModel currentPage;
        public PageViewModel CurrentPage { get => currentPage; set => SetProperty(ref currentPage, value); }

        public MainViewModel()
        {
            CurrentPage = new FirstPage();
        }
    }
}
