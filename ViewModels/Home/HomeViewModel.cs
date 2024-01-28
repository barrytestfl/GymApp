using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GymApp.ViewModels.Accounts;
using GymApp.ViewModels.Challenges;
using GymApp.ViewModels.Deals;
using GymApp.ViewModels.Fitquest;
using GymApp.ViewModels.Goals;
using GymApp.ViewModels.Notifications;
using GymApp.Views.Accounts;
using GymApp.Views.Challenges;
using GymApp.Views.Deals;
using GymApp.Views.Fitquest;
using GymApp.Views.Goals;
using GymApp.Views.Home;
using GymApp.Views.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input; 

namespace GymApp.ViewModels.Home
{
   public partial class HomeViewModel:ObservableObject
    {
        public ICommand BringFriendCommand { get; private set; }
        
        public HomeViewModel() {
            BringFriendCommand = new Command(async () => await BringFriend());
          
        }
        [RelayCommand]
        public async Task Account()
        {
            AccountViewModel nextViewModel = Application.Current.Handler.MauiContext.Services.GetService<AccountViewModel>();
            AccountPage nextPage = new(nextViewModel);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(nextPage);
            });
        }

        [RelayCommand]
        public async Task NotificationCenter()
        {
            NotificationCenterViewModel nextViewModel = Application.Current.Handler.MauiContext.Services.GetService<NotificationCenterViewModel>();
            NotificationCenterPage nextPage = new(nextViewModel);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(nextPage);
            });
        }
        public async Task BringFriend()
        {
            BringFriendViewModel nextViewModel = Application.Current.Handler.MauiContext.Services.GetService<BringFriendViewModel>();
            BringFriendPage nextPage = new(nextViewModel);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(nextPage);
            });
        }
        [RelayCommand]
        public async Task PersonalTrainers()
        {
            PersonalTrainersViewModel nextViewModel = Application.Current.Handler.MauiContext.Services.GetService<PersonalTrainersViewModel>();
            PersonalTrainersPage nextPage = new(nextViewModel);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(nextPage);
            });
        }
        [RelayCommand]
        public async Task GoalCenter()
        {
            YourGoalsViewModel nextViewModel = Application.Current.Handler.MauiContext.Services.GetService<YourGoalsViewModel>();
            YourGoalsPage nextPage = new(nextViewModel);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(nextPage);
            });
        }
        [RelayCommand]
        public async Task FitQuest()
        {
            FitquestViewModel nextViewModel = Application.Current.Handler.MauiContext.Services.GetService<FitquestViewModel>();
            FitquestPage nextPage = new(nextViewModel);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(nextPage);
            });
        }
        [RelayCommand]
        public async Task Challenges()
        {
            CurrentViewModel nextViewModel = Application.Current.Handler.MauiContext.Services.GetService<CurrentViewModel>();
            CurrentPage nextPage = new(nextViewModel);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(nextPage);
            });
        }
        [RelayCommand]
        public async Task Deals()
        {
            AllDealsViewModel nextViewModel = Application.Current.Handler.MauiContext.Services.GetService<AllDealsViewModel>();
            AllDealsPage nextPage = new(nextViewModel);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(nextPage);
            });
        }
        public Task LoadData()
        {
            return Task.Run(() =>
            {

            });
        }
    }
}
