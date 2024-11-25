using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial  : ViewComponent
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();

        public IViewComponentResult Invoke()
        { 
            var values = holaPortfolioContext.Features.ToList();
            return View(values);
        }

    }
}
