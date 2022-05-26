using Juan.Models;
using System.Collections.Generic;

namespace Juan.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public Dictionary<string, string> Settings { get; set; }
    }
}
