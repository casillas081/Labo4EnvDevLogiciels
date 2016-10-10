using AppLabo4.Model;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace AppLabo4.ViewModel
{
    public class SecondPageViewModel
    {
        public Student SelectedStudent { get; set; }

        private INavigationService _navigationService;

        public SecondPageViewModel(INavigationService navigationService = null)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedTo(NavigationEventArgs e)
        {
            SelectedStudent = (Student)e.Parameter;
        }
    }
}
