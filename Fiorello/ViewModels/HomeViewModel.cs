using System.Collections.Generic;
using Fiorello.DAL.Models;

namespace Fiorello.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<About> Abouts { get; set; }
        public List<Expert> Experts { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Say> Says { get; set; }

    }
}