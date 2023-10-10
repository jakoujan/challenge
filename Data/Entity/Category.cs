namespace Challenge.Data.Entity
{
    public enum CategoryType
    {
        CATEGORY,
        SUBCATEGORY,
        INTERIOR
    }

    public enum CategoryVisibility
    {
        HIDDEN,
        ON_DISPLAY
    }

    public class Category
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public CategoryType CategoryType { get; set; }
        public CategoryVisibility Visibility { get; set; }
        public bool FeaturedInHeaderAndFooter { get; set; }
        public bool FeaturedInBannerIconsSection { get; set; }
        public bool FeaturedInTilesSection { get; set; }
        public string? CategoryIcon { get; set; }
        public string? CategoryName { get; set; }
        public bool UseExternalURL { get; set; }
        public string? Thumbnail { get; set; }
        public string? MainCategoryLandingPageDescripition { get; set; }
        public string? MainCategoryLandingPageHeadline { get; set; }
        public string? SubCategoryLandingPageDescription { get; set; }
        public CategoryLandingPageSEO? LandingPageSEO { get; set; }
        public bool Active { get; set; }
        public bool Static{ get; set; }
        public List<Category> Childrens { get; set; }
    }

    public class CategoryLandingPageSEO
    {
        public string? Title { get; set; }
        public string? PrettyURL { get; set; }
        public string DescriptionMetadata { get; set; }
    }
}
