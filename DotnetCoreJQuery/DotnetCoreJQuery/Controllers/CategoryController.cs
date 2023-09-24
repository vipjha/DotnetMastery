using DotnetCoreJQuery.DataContext;
using DotnetCoreJQuery.Models;
using DotnetCoreJQuery.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotnetCoreJQuery.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetAllCategory()
        {

            CategoryInfoVm model = new CategoryInfoVm();
            model.CategoryList = _context.Categories.ToList();
            return Json(model);
        }

        [HttpPost]
        public IActionResult AddUpdateCategory(Category infoModel)
        {
            CategoryInfoVm model = new CategoryInfoVm();
            try
            {
                if (infoModel == null)
                {
                    model.ErrorMessage = "All data are required";
                    return Json(model);
                }
                else
                {
                    if (infoModel.Id == 0)
                    {
                        _context.Add(infoModel);
                        model.TotalRow = _context.SaveChanges();
                        model.ErrorMessage = "Category add successfuly!";
                    }
                    else
                    {
                        _context.Update(infoModel);
                        model.TotalRow = _context.SaveChanges();
                        model.ErrorMessage = "Category update successfuly!";
                    }
                }

                return Json(model);
            }
            catch (Exception ex)
            {
                model.ErrorMessage = ex.Message;
                return Json(model);
            }
        }

        [HttpPost]
        public IActionResult GetCategoryDetail(int id)
        {
            CategoryInfoVm model = new CategoryInfoVm();
            try
            {
                var categoryData = _context.Categories.FirstOrDefault(m => m.Id == id);
                if (categoryData == null)
                {
                    model.TotalRow = 0;
                    model.ErrorMessage = "Data not found";
                }
                else
                {
                    model.Category = categoryData;
                }
            }
            catch (Exception ex)
            {
                model.ErrorMessage = ex.Message;
            }
            return Json(model);
        }

        [HttpPost]
        public IActionResult DeleteCategory(Category model)
        {
            CategoryInfoVm infomodel = new CategoryInfoVm();
            try
            {
                _context.Remove(model);
                _context.SaveChanges();
                infomodel.TotalRow = 0;
                infomodel.ErrorMessage = "Record deleted!";
                
            }
            catch (Exception ex)
            {
                infomodel.ErrorMessage = ex.Message;
            }
            return Json(model);
        }
    }
}
