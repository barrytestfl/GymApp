using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GymApp.ViewModels.Accounts;
using GymApp.Views.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.ViewModels
{
    public partial class AppShellViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task Profile()
        {
            AccountViewModel nextViewModel = Application.Current.Handler.MauiContext.Services.GetService<AccountViewModel>();
            AccountPage nextPage = new(nextViewModel);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(nextPage);
            });
        }
        public AppShellViewModel()
        {
            
        }
        [RelayCommand]
        void LogIn()
        {

        }
        [RelayCommand]
        void LogOut()
        {

        }
        public Task LoadData()
        {
            return Task.Run(() =>
            {

            });
        }
    }
}
