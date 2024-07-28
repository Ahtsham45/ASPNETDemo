using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data;

namespace WebApplication1.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ToDoRepository _db; ?//local instance of the database service 

? ? ? ? public CreateModel(ToDoRepository db) ?//dependency injection of the database service 
? ? ? ? {
            _db = db;
        }

        [BindProperty]
        public ToDoItem? ToDoItem { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.AddToDoItem(ToDoItem);
            return RedirectToPage("Index");
        }
    }
}