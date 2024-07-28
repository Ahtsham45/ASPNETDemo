using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db; ?//local instance of the database service 

? ? ? ? public List<ToDoItem> myToDoList; ?//our UI front end will support looping through and displaying Tasks retrieved from the database and stored in a List 

? ? ? ? public IndexModel(ApplicationDbContext db) ?//dependency injection of the database service 
? ? ? ? {
            _db = db;
            myToDoList = new List<ToDoItem>();
        }

        public IActionResult OnGet()
        {
            myToDoList = _db.ToDoItems.ToList();
            return Page();
        }
    }

}
