using System.Collections.Generic;
using MSBuildDemo.Data;
using MSBuildDemo.Web.Controllers;
using NUnit.Framework;
using Rhino.Mocks;

namespace UnitTests.Web
{
    [TestFixture]
    public class CategoryControllerTests
    {
        private CategoryController _controller;
        private MockRepository _mocks;
        private ICategoryRepository _repository;

        [SetUp]
        public void Setup()
        {
            _mocks = new MockRepository();
            _repository = _mocks.DynamicMock<ICategoryRepository>();
            _controller = new CategoryController(_repository);
        }

        [Test]
        public void DeveListarTodasAsCategoriasNaPaginaIndex()
        {
            var categoria = new Category {CategoryName = "Teste"};
            _repository.Expect(r => r.List()).Return(new List<Category> {categoria});
            _mocks.ReplayAll();
            var categorias = _controller.Index().ViewData.Model as IList<Category>;
            Assert.AreEqual(categoria, categorias[0]);
        }
    }
}
