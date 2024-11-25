using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();
        public IViewComponentResult Invoke()
        { 
            var values = holaPortfolioContext.SocialMedias.ToList(); ;
            return View(values);
        }

    }
}
