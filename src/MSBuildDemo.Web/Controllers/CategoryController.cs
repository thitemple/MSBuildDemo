using System.Web.Mvc;
using MSBuildDemo.Data;

namespace MSBuildDemo.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _repository;

        public CategoryController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public CategoryController() : this(new CategoryRepository()) { }

        public ViewResult Index()
        {
            return View(_repository.List());
        }
    }
}