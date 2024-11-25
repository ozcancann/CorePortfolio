using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();

        public IViewComponentResult Invoke() 
        { 

            var values = holaPortfolioContext.Portfolios.ToList();
            return View(values);
        } 

    }
}
