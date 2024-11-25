using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponent : ViewComponent
	{
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = holaPortfolioContext.ToDoLists.Where(x => x.Status == false).Count();
            var values = holaPortfolioContext.ToDoLists.Where(x => x.Status == false).ToList();
            return View(values);
        }
    }
}
