using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();

        public IActionResult Index()
        {
            ViewBag.skillCount = holaPortfolioContext.Skills.Count();
            ViewBag.messageCount = holaPortfolioContext.Messages.Count();
            ViewBag.isreadFalse = holaPortfolioContext.Messages.Where(x => x.IsRead ==false).Count();
            ViewBag.isreadTrue = holaPortfolioContext.Messages.Where(x => x.IsRead ==true).Count();
            ViewBag.avgSkill = holaPortfolioContext.Skills.Average(x => x.Value).ToString("F2");
			ViewBag.experienceCount = holaPortfolioContext.Experiences.Count();
			ViewBag.projeCount = holaPortfolioContext.Portfolios.Count();
			ViewBag.maxskillValue = (from s in holaPortfolioContext.Skills
									   orderby s.Value descending
									   select s.Title).FirstOrDefault();
			ViewBag.minskillValue = (from s in holaPortfolioContext.Skills
									  orderby s.Value ascending
									  select s.Title).FirstOrDefault();

            ViewBag.totalTestimonialCount = holaPortfolioContext.Testimonials.Count();

            var minSkill = (from s in holaPortfolioContext.Skills
                            orderby s.Value ascending
                            select s).FirstOrDefault();

            if (minSkill != null)
            {
                ViewBag.minSkillValueRate = minSkill.Value; // Değer
                ViewBag.minSkillTitleRate = minSkill.Title; // İsim
            }
            else
            {
                ViewBag.minSkillValueRate = null; // Veya uygun bir default değeri atayabilirsiniz
                ViewBag.minSkillTitleRate = null; // Veya uygun bir default değeri atayabilirsiniz
            }

            var maxSkill = (from s in holaPortfolioContext.Skills
                            orderby s.Value descending
                            select s).FirstOrDefault();

            if (maxSkill != null)
            {
                ViewBag.maxSkillValueRate = maxSkill.Value; // Değer
                ViewBag.maxSkillTitleRate = maxSkill.Title; // İsim
            }
            else
            {
                ViewBag.maxSkillValueRate = null; // Veya uygun bir default değeri atayabilirsiniz
                ViewBag.maxSkillTitleRate = null; // Veya uygun bir default değeri atayabilirsiniz
            }


            return View();
        }
    }
}
