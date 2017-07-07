using DataModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Contracts;
using GalaSoft.MvvmLight.Views;
using GkMic.Properties;

namespace GkMic.ViewModel
{
    public class PassportViewModel : ViewModelBase
    {
        private IDataService _dataSevice;
        private IDialogService _dialogService;
        private ICommand _saveCommand;
        private Passport _passport = new Passport();
        
        public Passport Passport
        {
            get
            {
                return _passport;
            }
            set
            {
                Set(ref _passport, value);
            }
        }        
        public ICommand SaveCommand
        {
            get
            {
                if(_saveCommand == null)
                    _saveCommand = new RelayCommand(Save);

                return _saveCommand;
            }
        }
        
        public PassportViewModel(IDataService dataSevice, IDialogService dialogService)
        {
            _dataSevice = dataSevice;
            _dialogService = dialogService;
        }

        private void Save()
        {
            _dataSevice.Save(Passport, (error) =>
            {
                if (error != null)
                {
                    _dialogService.ShowError(error, Resources.Error, null, null);
                    return;
                }

                Passport = new Passport();
                _dialogService.ShowMessage(Resources.SaveComplete, Resources.Info);
                return;
            });
        }
    }
}
