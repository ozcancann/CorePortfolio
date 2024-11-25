using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Entities;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class FeatureController : Controller
    {

        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();

        public IActionResult FeatureList()
        {
            var values = holaPortfolioContext.Features.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFeature(Feature feature)
        {
            holaPortfolioContext.Features.Add(feature);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("FeatureList");
        }


        public IActionResult DeleteFeature(int id)
        {
            var value = holaPortfolioContext.Features.Find(id);
            holaPortfolioContext.Features.Remove(value);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("FeatureList");
        }


        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var values = holaPortfolioContext.Features.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            holaPortfolioContext.Features.Update(feature);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}
