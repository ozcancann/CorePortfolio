using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.Title = holaPortfolioContext.Contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.Description = holaPortfolioContext.Contacts.Select(x => x.Description).FirstOrDefault();

            var values = holaPortfolioContext.Contacts.ToList();
            return View(values);
        }

    }
}
