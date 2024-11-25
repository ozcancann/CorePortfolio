using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
	public class AboutController : Controller
	{
		HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();

		public IActionResult AboutList()
		{
			var values = holaPortfolioContext.Abouts.ToList();
			return View(values);
		}

        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            holaPortfolioContext.Abouts.Add(about);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public IActionResult DeleteAbout(int id)
        {
            var value = holaPortfolioContext.Abouts.Find(id);
            holaPortfolioContext.Abouts.Remove(value);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("AboutList");
        }


        [HttpGet]
		public IActionResult UpdateAbout(int id)
		{
			var values = holaPortfolioContext.Abouts.Find(id);
			return View(values);
		}

		[HttpPost]
		public IActionResult UpdateAbout(About about)
		{
			holaPortfolioContext.Abouts.Update(about);
			holaPortfolioContext.SaveChanges();
			return RedirectToAction("AboutList");
		}

	}
}
