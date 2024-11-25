using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = holaPortfolioContext.Testimonials.ToList();
            return View(values);
        }

    }
}
