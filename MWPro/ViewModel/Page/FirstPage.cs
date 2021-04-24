using MWPro.Dialogs;
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
                    {
                        CustomDialogs.RunCustomFromVm(this);
                    }, () => { return true; });
                }
                return showDialogAction;
            }
        }

        internal CustomDialogs CustomDialogs = new CustomDialogs();

        public FirstPage()
        {
            
        }
    }
}
