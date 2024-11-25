using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = holaPortfolioContext.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            holaPortfolioContext.Experiences.Add(experience);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = holaPortfolioContext.Experiences.Find(id);
            holaPortfolioContext.Experiences.Remove(value);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]

        public IActionResult UpdateExperience(int id)
        {
            var values = holaPortfolioContext.Experiences.Find(id);
            return View(values);
        }

        [HttpPost]

        public IActionResult UpdateExperience(Experience experience)
        {
            holaPortfolioContext.Experiences.Update(experience);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
