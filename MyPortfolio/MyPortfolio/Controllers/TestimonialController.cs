using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Entities;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();

        public IActionResult TestimonialList()
        {
            var values = holaPortfolioContext.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            holaPortfolioContext.Testimonials.Add(testimonial);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var values = holaPortfolioContext.Testimonials.Find(id);
            holaPortfolioContext.Testimonials.Remove(values);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var values = holaPortfolioContext.Testimonials.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            holaPortfolioContext.Testimonials.Update(testimonial);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}
