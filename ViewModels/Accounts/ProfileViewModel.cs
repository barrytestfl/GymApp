using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.ViewModels.Accounts
{
   public partial class ProfileViewModel : ObservableObject
    {
        [ObservableProperty]
        private string firstName;
        [ObservableProperty]
        private string lastName;
        [ObservableProperty]
        private string email;
        [ObservableProperty]
        private string phone;
        [ObservableProperty]
        private string address;
        [ObservableProperty]
        private string gymLoc;
        public ProfileViewModel() { 
        
        }
        [RelayCommand]
        public async Task Save()
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
