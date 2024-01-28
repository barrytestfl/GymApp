using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GymApp.ViewModels.Accounts;
using GymApp.ViewModels.Notifications;
using GymApp.Views.Accounts;
using GymApp.Views.Goals;
using GymApp.Views.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace GymApp.ViewModels.Goals
{
    public partial class YourGoalsViewModel: ObservableObject
    {
        public YourGoalsViewModel() { 
        
        }
        [RelayCommand]
        private async Task SetNewGoal(string model)
        {

            SetGoalViewModel nextViewModel = Application.Current.Handler.MauiContext.Services.GetService<SetGoalViewModel>();
            nextViewModel.TypeGoal = model;
            if (model=="day") { nextViewModel.IsWeekly = true; }
            if (model== "colorie") { nextViewModel.IsColories = true; }
            if (model== "hours") { nextViewModel.IsWorkout = true; }
            if (model== "distance") { nextViewModel.IsDistance = true; }
            SetGoalPage nextPage = new(nextViewModel);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(nextPage);
            });
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
         
    }
}
