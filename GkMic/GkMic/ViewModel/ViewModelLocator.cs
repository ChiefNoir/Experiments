using Contracts;
using DataService.Service;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using GkMic.View;
using Microsoft.Practices.ServiceLocation;

namespace GkMic.ViewModel
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<BirthCertificateViewModel>();
            SimpleIoc.Default.Register<PassportViewModel>();

            SimpleIoc.Default.Register<IDataService, SqlDataService>();
            SimpleIoc.Default.Register<IDialogService, DialogService>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
    "CA1822:MarkMembersAsStatic",
    Justification = "This non-static member is needed for data binding purposes.")]
        public BirthCertificateViewModel BirthCertificateViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<BirthCertificateViewModel>();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
"CA1822:MarkMembersAsStatic",
Justification = "This non-static member is needed for data binding purposes.")]
        public PassportViewModel PassportViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<PassportViewModel>();
            }
        }

        /// <summary> Cleans up all the resources. </summary>
        public static void Cleanup()
        {
        }
    }
}