using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data;

namespace WebApplication1.Pages
{
    public class EditModel : PageModel
    {
        private readonly ToDoRepository _db;  //local instance of the database service 

        public EditModel(ToDoRepository db)  //dependency injection of the database service 
        {
            _db = db;
        }

        [BindProperty]
        public ToDoItem? MyToDoItem { get; set; }

        public IActionResult OnGet(int Id)
        {
            MyToDoItem = _db.FindMyToDo(Id);
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.UpdateToDoItem(MyToDoItem);
            return RedirectToPage("Index");
        }
    }
}