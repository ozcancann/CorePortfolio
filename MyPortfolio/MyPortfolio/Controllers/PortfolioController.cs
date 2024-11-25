using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Entities;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();
        public IActionResult PortfolioList()
        {
            var values = holaPortfolioContext.Portfolios.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            holaPortfolioContext.Portfolios.Add(portfolio);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = holaPortfolioContext.Portfolios.Find(id);
            holaPortfolioContext.Portfolios.Remove(values);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var values = holaPortfolioContext.Portfolios.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            holaPortfolioContext.Portfolios.Update(portfolio);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}