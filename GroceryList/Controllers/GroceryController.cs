using Microsoft.AspNetCore.Mvc;
using GroceryList.Models;

namespace GroceryList.Controllers
{
    public class GroceryController : Controller
    {
        private static List<GroceryItem> groceryItems = new List<GroceryItem>();
        public IActionResult Index()
        {
            return View(groceryItems);
        }

        public IActionResult Add()
        {
            var item = new GroceryItem();
            return View(item);
        }

        public IActionResult SaveItem(GroceryItem groceryItem)
        {
            groceryItems.Add(groceryItem);
            return RedirectToAction(nameof(Index));
        }
    }
}
