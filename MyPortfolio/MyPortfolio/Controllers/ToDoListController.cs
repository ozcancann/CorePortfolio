using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ToDoListController : Controller
    {
        HolaPortfolioContext holaPortfolioContext = new HolaPortfolioContext();

        public IActionResult Index()
        {
            var values = holaPortfolioContext.ToDoLists.ToList(); 
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            holaPortfolioContext.ToDoLists.Add(toDoList);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var value = holaPortfolioContext.ToDoLists.Find(id);
            holaPortfolioContext.ToDoLists.Remove(value);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = holaPortfolioContext.ToDoLists.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            holaPortfolioContext.ToDoLists.Update(toDoList);
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusToTrue(int id)
        {
            var value = holaPortfolioContext.ToDoLists.Find(id);
            value.Status = true;
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusToFalse(int id)
        {
            var value = holaPortfolioContext.ToDoLists.Find(id);
            value.Status = false;
            holaPortfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
