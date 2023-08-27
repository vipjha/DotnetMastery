using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbCotext _db;

        public Category Category { get; set; }

        

        public EditModel(ApplicationDbCotext db)
        {
                _db =db;
        }
       
        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);
            //Category = _db.Category.First(u=>u.Id==id); // First is return exeception
            //Category = _db.Category.FirstOrDefault(u => u.Id == id); // Not return any execpton
            //Category = _db.Category.Single(u => u.Id == id); // Expected only single recored with execption
            //Category = _db.Category.SingleOrDefault(u => u.Id == id); // Expected single recored and not return any exeception
            //Category = _db.Category.Where(u => u.Id == id).FirstOrDefault(); // Where condition
        }

        public async Task<IActionResult> OnPost()
        {
            if(Category.Name ==Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty, "The DisplayOrder cannot exactly match the Name");
            }
            
            if (ModelState.IsValid)
            {
                 _db.Category.Update(Category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Category updated successfully";
                return RedirectToPage("Index");
            }

            return Page();
        }

    }
}
