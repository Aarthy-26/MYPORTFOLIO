using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPortfolio.Services;
using MyPortfolio.Models;
using System.Collections.Generic;

namespace MyPortfolio.Pages
{
    public class ProjectsModel : PageModel
    {
        private readonly PortfolioService _portfolioService;

        public List<Project> Projects { get; private set; }

        public ProjectsModel(PortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public void OnGet()
        {
            Projects = _portfolioService.GetProjects();
        }
    }
}
