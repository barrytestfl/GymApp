using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.ViewModels.Notifications
{
    public class NotificationCenterViewModel : ObservableObject
    {
        public NotificationCenterViewModel() { 
        
        }
        public Task LoadData()
        {
            return Task.Run(() =>
            {

            });
        }
    }
}
