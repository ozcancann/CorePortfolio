using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponetPartial : ViewComponent
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();
        public IViewComponentResult Invoke()
        { 
            ViewBag.aboutTitle = holaPortfolioContext.Abouts.Select(a => a.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = holaPortfolioContext.Abouts.Select(a => a.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = holaPortfolioContext.Abouts.Select(a => a.Details).FirstOrDefault();

            return View();
        }
    }
}
