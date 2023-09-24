using DotnetCoreJQuery.Models;

namespace DotnetCoreJQuery.ViewModel
{
    public class CategoryInfoVm
    {
        public int TotalRow { get; set; }

        public string? ErrorMessage { get; set; }

        public Category Category { get; set; } = new Category();
        
        private List<Category> categories = new List<Category>();
        public List<Category> CategoryList 
        { 
            get { return categories; } 
            set { categories = value; } 
        }

    }
}
