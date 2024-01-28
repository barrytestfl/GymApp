using CommunityToolkit.Mvvm.ComponentModel;
using GymApp.Views.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GymApp.ViewModels.Home
{
   public class BringFriendViewModel: ObservableObject
    {
        public string FirstMonth { get; set; }
        public string SecandMonth { get; set; }
        public ICommand AddBringFriendCommand { get; private set; }

        public BringFriendViewModel() {
            FirstMonth = DateTime.Now.ToString("MMMM");
            SecandMonth = DateTime.Now.AddMonths(1).ToString("MMMM");
            AddBringFriendCommand= new Command(async () => await AddBringFriend());
        }
        public async Task AddBringFriend()
        {
            AddFriendViewModel nextViewModel = Application.Current.Handler.MauiContext.Services.GetService<AddFriendViewModel>();
            AddFriendPage nextPage = new(nextViewModel);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(nextPage);
            });
        }
    }
}
