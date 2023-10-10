using Challenge.Data.Entity;
using Challenge.Data.Provider;
using Data.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Challenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : Controller
    {
        private ICategoriesProvider _provider;
        public CategoriesController(ICategoriesProvider provider)
        {
            _provider = provider;
        }
        

        [HttpGet]
        public IEnumerable<Category> GetCategories([FromQuery(Name = "visibility")] CategoryVisibility? visibility, [FromQuery(Name = "name")] string? name)
        {
            return _provider.GetCategories(visibility, name);
        }

        [HttpPost]
        public Category saveCategory(AddCategoryDto addCategoryDto)
        {
            return _provider.SaveCategory(addCategoryDto);
        }


    }
}
