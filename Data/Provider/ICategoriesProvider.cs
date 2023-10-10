using Challenge.Data.Entity;
using Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Data.Provider
{
    public interface ICategoriesProvider
    {
        public IEnumerable<Category> GetCategories(CategoryVisibility? visibility, string? name);
        public Category SaveCategory(AddCategoryDto addCategoryDto);
    }
}
