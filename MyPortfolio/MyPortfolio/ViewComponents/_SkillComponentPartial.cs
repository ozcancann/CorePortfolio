using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = holaPortfolioContext.Skills.ToList();
            return View(values);
        }

    }
}
