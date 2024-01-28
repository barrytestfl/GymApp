using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Models.Classes
{
    public class GymClass
    {
        public long UserId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public int SpotLeft { get; set; }
        public DateTime StartTime { get; set; }
        public int TotalTime { get; set; }
    }
}
