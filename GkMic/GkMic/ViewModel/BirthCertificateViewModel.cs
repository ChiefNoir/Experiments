using DataModel;
using Contracts;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System;
using GalaSoft.MvvmLight.Views;

namespace GkMic.ViewModel
{
    public class BirthCertificateViewModel : ViewModelBase
    {
        public BirthCertificate BirthCertificate { get; set; }
        public ICommand SaveCommand { get; set; }

        private IDataService _dataSevice;
        private IDialogService _dialogService;

        public BirthCertificateViewModel(IDataService dataSevice, IDialogService dialogService)
        {
            BirthCertificate = new BirthCertificate();
            _dataSevice = dataSevice;
            _dialogService = dialogService;
            SaveCommand = new RelayCommand(Save);
        }

        private void Save()
        {
            _dataSevice.Save(BirthCertificate, (error) =>
            {
                if(error == null)
                {
                    BirthCertificate = new BirthCertificate();
                    _dialogService.ShowMessage("done", "ok");
                    return;
                }
                else
                {
                    _dialogService.ShowError(error, "", "ok", null);
                }
            });
        }
    }
}
