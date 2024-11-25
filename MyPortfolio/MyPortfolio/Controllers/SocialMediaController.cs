using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Entities;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();
        public IActionResult SocialMediaList()
        {
            var values = holaPortfolioContext.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia socialmedia)
        {
            holaPortfolioContext.SocialMedias.Add(socialmedia);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var values = holaPortfolioContext.SocialMedias.Find(id);
            holaPortfolioContext.SocialMedias.Remove(values);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var values = holaPortfolioContext.SocialMedias.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialmedia)
        {
            holaPortfolioContext.SocialMedias.Update(socialmedia);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }
}
