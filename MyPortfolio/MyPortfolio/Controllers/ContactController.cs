using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Entities;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();
        public IActionResult ContactList()
        {
            var values = holaPortfolioContext.Contacts.ToList();
            return View(values);
        }

        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            holaPortfolioContext.Contacts.Add(contact);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("ContactList");
        }

        public IActionResult DeleteContact(int id)
        {
            var value = holaPortfolioContext.Contacts.Find(id);
            holaPortfolioContext.Contacts.Remove(value);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("ContactList");
        }


        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var values = holaPortfolioContext.Contacts.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {

            holaPortfolioContext.Contacts.Update(contact);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}
