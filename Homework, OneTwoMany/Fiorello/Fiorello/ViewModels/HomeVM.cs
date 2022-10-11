using Fiorello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewModels
{
    public class HomeVM
    {
        public About About { get; set; }
        public IEnumerable<Expert> Experts { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Slider> Sliders { get; set; }
        public SliderDetail SliderDetail { get; set; }
        public ExpertTitle ExpertTitle { get; set; }
        public BlogTitle BlogTitle { get; set; }
        public IEnumerable<Say> Says { get; set; }
        public FiorelloLabel FiorelloLabel { get; set; }
        public IEnumerable<Instagram> Instagrams { get; set; }
        public Subscribe Subscribe { get; set; }
        public SubscribeDetail SubscribeDetail { get; set; }

    }
}
