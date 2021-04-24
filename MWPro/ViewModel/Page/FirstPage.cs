using MWPro.ViewModel.Base;
using System.Windows.Input;

namespace MWPro.ViewModel.Page
{
    public class FirstPage : PageViewModel
    {
        private ICommand showDialogAction;

        public ICommand ShowDialogAction
        {
            get
            {
                if (showDialogAction == null)
                {
                    showDialogAction = new RelayCommand(() => 
                    { }, () => { return true; });
                }
                return showDialogAction;
            }
        }

        public FirstPage()
        {
            
        }
    }
}
