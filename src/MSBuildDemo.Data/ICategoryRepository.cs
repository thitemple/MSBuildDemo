using System.Collections.Generic;

namespace MSBuildDemo.Data
{
    public interface ICategoryRepository
    {
        IList<Category> List();
    }
}