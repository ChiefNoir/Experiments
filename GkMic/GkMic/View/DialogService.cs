using GalaSoft.MvvmLight.Views;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace GkMic.View
{
    //NOTE: в данный момент полная и awaitable имплементация IDialogService не нужна
    public class DialogService : IDialogService
    {
        public Task ShowError(Exception error, string title, string buttonText, Action afterHideCallback)
        {
            MessageBox.Show(error.InnerException.InnerException.Message, title);
            return Task.FromResult(0);
        }

        public Task ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title);
            return Task.FromResult(0);
        }



        public Task ShowError(string message, string title, string buttonText, Action afterHideCallback)
        {
            throw new NotImplementedException();
        }

        public Task ShowMessage(string message, string title, string buttonText, Action afterHideCallback)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ShowMessage(string message, string title, string buttonConfirmText, string buttonCancelText, Action<bool> afterHideCallback)
        {
            throw new NotImplementedException();
        }

        public Task ShowMessageBox(string message, string title)
        {
            throw new NotImplementedException();
        }
    }
}
