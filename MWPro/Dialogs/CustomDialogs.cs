using MWindowInterfacesLib.Interfaces;
using MWPro.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MWPro.Dialogs
{
    public class CustomDialogs
    {
        internal async void RunCustomFromVm(object context)
        {
            var coord = MWindowDialogLib.ContentDialogService.Instance.Coordinator;

            var customDialog = new MWindowDialogLib.Dialogs.CustomDialog(new View.CustomDialogView());

            var customDialogViewModel = new VM.CustomDialogViewModel(instance =>
            {
                coord.HideMetroDialogAsync(context, customDialog);

                System.Diagnostics.Debug.WriteLine("Custom Dialog -" + instance.Title + "- VM Result: ");
                System.Diagnostics.Debug.WriteLine("FirstName: " + instance.FirstName);
                System.Diagnostics.Debug.WriteLine(" LastName: " + instance.LastName);
            })
            { Title = "Custom Dialog" };

            customDialog.DataContext = customDialogViewModel;

            await coord.ShowMetroDialogAsync(context, customDialog);
        }
    }
}
