using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GymApp.Views.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.ViewModels.Accounts
{
   public partial class AccountViewModel:ObservableObject
    {
        [RelayCommand]
        public async Task Profile()
        {
            ProfileViewModel nextViewModel = Application.Current.Handler.MauiContext.Services.GetService<ProfileViewModel>();
            ProfilePage nextPage = new(nextViewModel);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(nextPage);
            });
        }
        [RelayCommand]
        public async Task MyGym()
        {

        }
        [RelayCommand]
        public async Task FAQs()
        {

        }
        [RelayCommand]
        public async Task Settings()
        {

        }

        [RelayCommand]
        public async Task LogOut()
        {

        }
        public AccountViewModel() { 
        
        }
        public Task LoadData()
        {
            return Task.Run(() =>
            {

            });
        }
    }
}
