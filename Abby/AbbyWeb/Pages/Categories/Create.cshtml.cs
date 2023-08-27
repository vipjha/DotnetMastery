using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbCotext _db;

        //[BindProperties]
        public Category Category { get; set; }

        public CreateModel(ApplicationDbCotext db)
        {
                _db =db;
        }
       
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(Category category)
        {
            if(Category.Name ==Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty, "The DisplayOrder cannot exactly match the Name");
            }
            
            if (ModelState.IsValid)
            {
                await _db.Category.AddAsync(category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Category created successfully";
                return RedirectToPage("Index");
            }

            return Page();
        }

    }
}
