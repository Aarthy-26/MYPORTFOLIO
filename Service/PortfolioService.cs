using System.Collections.Generic;
using MyPortfolio.Models;

namespace MyPortfolio.Services
{
    public class PortfolioService
    {
        public List<Skill> GetSkills()
        {
            return new List<Skill>
            {
                new Skill { Name = "C#", Level = "Expert" },
                new Skill { Name = "Python", Level = "Intermediate" },
                new Skill { Name = "SQL", Level = "Intermediate" }
            };
        }

        public List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project { Title = "Spam Detection", Description = "A project to detect spam emails using ML.", Url = "https://github.com/yourproject" },
                new Project { Title = "Portfolio Website", Description = "A website showcasing my portfolio.", Url = "https://github.com/yourportfolio" }
            };
        }
    }
}
