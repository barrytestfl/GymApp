using CommunityToolkit.Maui.Storage;
using GymApp.ViewModels.Accounts;
using GymApp.ViewModels.Activity;
using GymApp.ViewModels.Challenges;
using GymApp.ViewModels.Classes;
using GymApp.ViewModels.Deals;
using GymApp.ViewModels.Fitquest;
using GymApp.ViewModels.Goals;
using GymApp.ViewModels.Home;
using GymApp.ViewModels.Notifications;
using GymApp.ViewModels.Settings;
using GymApp.ViewModels.WorkOuts;
using GymApp.Views.Accounts;
using GymApp.Views.Activity;
using GymApp.Views.Challenges;
using GymApp.Views.Classes;
using GymApp.Views.Deals;
using GymApp.Views.Fitquest;
using GymApp.Views.Goals;
using GymApp.Views.Home;
using GymApp.Views.Notifications;
using GymApp.Views.Settings;
using GymApp.Views.WorkOuts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static MauiAppBuilder AddServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IFileSaver>(FileSaver.Default);
            return builder;
        }
        public static MauiAppBuilder AddViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<HomeViewModel>();
            builder.Services.AddTransient<GymClassesViewModel>();
            builder.Services.AddTransient<BookedClassesViewModel>();
            builder.Services.AddTransient<MonthlyViewModel>();
            builder.Services.AddTransient<YearlyViewModel>();
            builder.Services.AddTransient<FitVideosViewModel>();
            builder.Services.AddTransient<RecordWorkOutsViewModel>();


            builder.Services.AddTransient<NewsViewModel>();
            builder.Services.AddTransient<AddFriendViewModel>();
            builder.Services.AddTransient<BringFriendViewModel>();
            builder.Services.AddTransient<PersonalTrainerInfoViewModel>();
            builder.Services.AddTransient<PersonalTrainersViewModel>();


            builder.Services.AddTransient<CurrentViewModel>();
            builder.Services.AddTransient<PastViewModel>();
            builder.Services.AddTransient<AllDealsViewModel>();
            builder.Services.AddTransient<SavedDealsViewModel>();
            builder.Services.AddTransient<FitquestViewModel>();
            builder.Services.AddTransient<CompletedGoalsViewModel>();
            builder.Services.AddTransient<SetGoalViewModel>();
            builder.Services.AddTransient<YourGoalsViewModel>();
            builder.Services.AddTransient<NotificationCenterViewModel>();
            builder.Services.AddTransient<AboutViewModel>();
            builder.Services.AddTransient<NotificationGymViewModel>();
            builder.Services.AddTransient<PrivacyViewModel>();


            builder.Services.AddTransient<AccountViewModel>();
            builder.Services.AddTransient<FAQsViewModel>();
            builder.Services.AddTransient<ProfileViewModel>();
            builder.Services.AddTransient<MyGymViewModel>();
            builder.Services.AddTransient<SettingsViewModel>();
            return builder;
        }
        public static MauiAppBuilder AddViews(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<GymClassesPage>();
            builder.Services.AddTransient<BookedClassesPage>();
            builder.Services.AddTransient<MonthlyPage>();
            builder.Services.AddTransient<YearlyPage>();
            builder.Services.AddTransient<FitVideosPage>();
            builder.Services.AddTransient<RecordWorkOutsPage>();

            builder.Services.AddTransient<NewsPage>();
            builder.Services.AddTransient<AddFriendPage>();
            builder.Services.AddTransient<BringFriendPage>();
            builder.Services.AddTransient<PersonalTrainerInfoPage>();
            builder.Services.AddTransient<PersonalTrainersPage>();

            builder.Services.AddTransient<CurrentPage>();
            builder.Services.AddTransient<PastPage>();
            builder.Services.AddTransient<AllDealsPage>();
            builder.Services.AddTransient<SavedDealsPage>();
            builder.Services.AddTransient<FitquestPage>();
            builder.Services.AddTransient<CompletedGoalsPage>();
            builder.Services.AddTransient<SetGoalPage>();
            builder.Services.AddTransient<YourGoalsPage>();
            builder.Services.AddTransient<NotificationCenterPage>();
            builder.Services.AddTransient<AboutPage>();
            builder.Services.AddTransient<NotificationPage>();
            builder.Services.AddTransient<PrivacyPage>();

            builder.Services.AddTransient<AccountPage>();
            builder.Services.AddTransient<FAQsPage>();
            builder.Services.AddTransient<ProfilePage>();
            builder.Services.AddTransient<MyGymPage>();
            builder.Services.AddTransient<SettingsPage>();


            return builder;
        }
    }
}
