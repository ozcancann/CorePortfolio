using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {

        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = holaPortfolioContext.Experiences.ToList();
            return View(values);
        }

    }
}
