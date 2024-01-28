using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Models.Video
{
   public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string VideoType { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public string PartName { get; set; }
        public TimeOnly Duration { get; set; }
    }
}
