using MSBuildDemo.Data;
using NUnit.Framework;

namespace UnitTests.Data
{
    [TestFixture]
    public class CategoryRepositoryTests
    {
        private ICategoryRepository _repository;

        [SetUp]
        public void Setup()
        {
            _repository = new CategoryRepository();
        }

        [Test]
        public void DeveListarTodasAsCategorias()
        {
            var categorias = _repository.List();
            Assert.Greater(categorias.Count, 0);
        }
    }
}
