
using Fiorello.Data;
using Fiorello.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            About about = await _context.Abouts.FirstOrDefaultAsync();

            IEnumerable<Expert> experts = await _context.Experts.ToListAsync();

            IEnumerable<Blog> blogs = await _context.Blogs.ToListAsync();

            IEnumerable<Slider> sliders = await _context.Sliders.ToListAsync();

            SliderDetail sliderDetail = await _context.SliderDetails.FirstOrDefaultAsync();

            ExpertTitle expertTitle = await _context.ExpertTitles.FirstOrDefaultAsync();

            BlogTitle blogTitle = await _context.BlogTitles.FirstOrDefaultAsync();

            IEnumerable<Say> says = await _context.Says.ToListAsync();

            IEnumerable<Instagram> instagrams = await _context.Instagrams.ToListAsync();

            FiorelloLabel fiorelloLabel = await _context.FiorelloLabels.FirstOrDefaultAsync();

            Subscribe subscribe = await _context.Subscribes.FirstOrDefaultAsync();

            SubscribeDetail subscribeDetail = await _context.SubscribeDetails.FirstOrDefaultAsync();


            HomeVM model = new HomeVM 
            {
                About = about,
                Experts = experts,
                Blogs = blogs,
                Sliders = sliders,
                SliderDetail = sliderDetail,
                ExpertTitle = expertTitle,
                BlogTitle = blogTitle,
                Says = says,
                Instagrams = instagrams,
                FiorelloLabel = fiorelloLabel,
                Subscribe = subscribe,
                SubscribeDetail = subscribeDetail
            };
            return View(model);
        }

       
    }
}
