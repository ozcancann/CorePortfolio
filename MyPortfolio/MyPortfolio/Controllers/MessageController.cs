using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class MessageController : Controller
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();
        public IActionResult Inbox()
        {
            var values = holaPortfolioContext.Messages.ToList();    
            return View(values);
        }

        public IActionResult ChangeIsReadToTrue(int id)
        {
            var values = holaPortfolioContext.Messages.Find(id);
            values.IsRead = true;
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("Inbox");

        }

        public IActionResult ChangeIsReadToFalse(int id)
        {
            var values = holaPortfolioContext.Messages.Find(id);
            values.IsRead = false;
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("Inbox");

        }

        public IActionResult DeleteMessage(int id)
        {
            var values = holaPortfolioContext.Messages.Find(id);
            holaPortfolioContext.Messages.Remove(values);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult MessageDetail(int id)
        {
            var values = holaPortfolioContext.Messages.Find(id);
            return View(values);
        }
    }
}
