using Microsoft.Toolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAP2._1.views;

namespace WAP2._1.ViewModel
{
    public partial class LoginPageViewModel:BaseViewModel
    {
        [ObservableProperty]
        private string _userName;
        [ObservableProperty]
        private string _password;


        [ICommand]
        public async void Login()
        {
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
    }
}
