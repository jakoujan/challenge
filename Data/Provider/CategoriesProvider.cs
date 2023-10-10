using Challenge.Data.Entity;
using Data.Dto;


namespace Challenge.Data.Provider
{
    public class CategoriesProvider : ICategoriesProvider
    {
        private List<Category> Categories = new List<Category>
            {
                new Category()
                {
                    Id = "00012",
                    Name = "Category One",
                    CategoryType = CategoryType.CATEGORY,
                    Visibility = CategoryVisibility.ON_DISPLAY,
                    Childrens = new List<Category> {}
                }
            };

        public IEnumerable<Category> GetCategories(CategoryVisibility? visibility, string? name)
        {
            List<Category> categories = this.Categories;
            if (visibility != null)
            categories = categories.Where(x => x.Visibility == visibility).ToList();
            if(name != null)
                categories = categories.Where(x => x.Name == name).ToList();
            return categories ;
        }

        public Category SaveCategory(AddCategoryDto dto)
        {
            Category parent = Categories.Find(category => category.Id == dto.ParentCategoryId);

            if(parent != null) 
            {
                parent.Childrens.Add(dto.Category);
                return parent;
            } 
            else
            {
                Categories.Add(dto.Category);
                return dto.Category;
            }
        }
    }
}
