using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _StatisticsComponentPartial : ViewComponent
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.skillCounter = holaPortfolioContext.Skills.Count();
            ViewBag.experienceCounter = holaPortfolioContext.Experiences.Count();
            ViewBag.workCounter = holaPortfolioContext.Portfolios.Count();
            ViewBag.skillAvg = Convert.ToInt32(holaPortfolioContext.Skills.Average(x => x.Value));
            return View();
        }

    }
}
