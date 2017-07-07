using DataModel;
using Contracts;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using GkMic.Properties;
using GalaSoft.MvvmLight.Views;

namespace GkMic.ViewModel
{
    public class BirthCertificateViewModel : ViewModelBase
    {
        private IDataService _dataSevice;
        private IDialogService _dialogService;
        private ICommand _saveCommand;
        private BirthCertificate _birthCertificate = new BirthCertificate();

        public BirthCertificate BirthCertificate
        {
            get
            {
                return _birthCertificate;
            }
            set
            {
                Set(ref _birthCertificate, value);
            }
        }
        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                    _saveCommand = new RelayCommand(Save);

                return _saveCommand;
            }
        }
        
        public BirthCertificateViewModel(IDataService dataSevice, IDialogService dialogService)
        {
            _dataSevice = dataSevice;
            _dialogService = dialogService;
        }

        private void Save()
        {
            _dataSevice.Save(BirthCertificate, (error) =>
            {
                if (error != null)
                {
                    _dialogService.ShowError(error, Resources.Error, null, null);
                    return;
                }

                BirthCertificate = new BirthCertificate();
                _dialogService.ShowMessage(Resources.SaveComplete, Resources.Info);
                return;
            });
        }
    }
}
