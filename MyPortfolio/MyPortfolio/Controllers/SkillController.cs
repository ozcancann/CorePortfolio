using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Entities;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class SkillController : Controller
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();

        public IActionResult SkillList()
        {
            var values = holaPortfolioContext.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            holaPortfolioContext.Skills.Add(skill);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = holaPortfolioContext.Skills.Find(id);
            holaPortfolioContext.Skills.Remove(values);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("SkillList");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values = holaPortfolioContext.Skills.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            holaPortfolioContext.Skills.Update(skill);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("SkillList");

        }
    }
}
