using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPortfolio.Services;
using MyPortfolio.Models;
using System.Collections.Generic;

namespace MyPortfolio.Pages
{
    public class AboutModel : PageModel
    {
        private readonly PortfolioService _portfolioService;

        public List<Skill> Skills { get; private set; }

        public AboutModel(PortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public void OnGet()
        {
            Skills = _portfolioService.GetSkills();
        }
    }
}
