using MWindowInterfacesLib.Interfaces;
using MWPro.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MWPro.Dialogs.VM
{
    public class InputDialogViewModel : MsgViewModel
    {
        #region fields
        private string input;
        private string affirmativeButtonText;
        private string negativeButtonText;

        private ICommand okCommand;
        private ICommand closeCommand;
        #endregion fields

        #region properties
        public string Input
        {
            get { return input; }
            set
            {
                if (input != value)
                {
                    input = value;
                    RaisePropertyChanged(() => Input);
                }
            }
        }

        public string NegativeButtonText
        {
            get { return negativeButtonText; }
            set
            {
                if (negativeButtonText != value)
                {
                    negativeButtonText = value;
                    RaisePropertyChanged(() => NegativeButtonText);
                }
            }
        }
        public string AffirmativeButtonText
        {
            get { return affirmativeButtonText; }
            set
            {
                if (affirmativeButtonText != value)
                {
                    affirmativeButtonText = value;
                    RaisePropertyChanged(() => AffirmativeButtonText);
                }
            }
        }

        /// <summary>
        /// Gets the OK command that is invoked to close this dialog.
        /// The OK command is invoked when the user clicks the OK button.
        /// </summary>
        public virtual ICommand OKCommand
        {
            get
            {
                if (okCommand == null)
                {
                    okCommand = new RelayCommand<object>((p) =>
                    {
                        base.Result = DialogIntResults.OK; // OK Button

                        base.SendDialogStateChangedEvent();

                        base.DialogCloseResult = true;
                    });
                }

                return okCommand;
            }
        }

        /// <summary>
        /// Gets the OK command that is invoked to close this dialog.
        /// The OK command is invoked when the user clicks the OK button.
        /// </summary>
        public override ICommand CloseCommand
        {
            get
            {
                if (closeCommand == null)
                {
                    closeCommand = new RelayCommand<object>((p) =>
                    {
                        base.Result = DialogIntResults.CANCEL; // CANCEL Button

                        base.SendDialogStateChangedEvent();

                        base.DialogCloseResult = true;
                    });
                }

                return closeCommand;
            }
        }
        #endregion properties
    }
}
