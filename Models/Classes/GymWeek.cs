using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Models.Classes
{
   public class GymWeek
    {
        public DateTime WeekDay { get; set; }
        public bool IsSelected { get; set; }
    }
}
