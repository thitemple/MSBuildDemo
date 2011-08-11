using System.Linq;
using System.Collections.Generic;

namespace MSBuildDemo.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly NorthwindDataContext _context;

        public CategoryRepository()
        {
            _context = new NorthwindDataContext();
        }

        public IList<Category> List()
        {
            return _context.Categories.ToList();
        }
    }
}