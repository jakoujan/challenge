using Challenge.Data.Entity;
using Challenge.Data.Provider;
using Data.Dto;
using Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContentController : Controller
    {
        
        private IContentProvider _provider;
        public ContentController(IContentProvider provider)
        {
            _provider = provider;
        }


        [HttpGet]
        public IEnumerable<Content> GetContents()
        {
            return _provider.GetContents();
        }

        [HttpPost]
        public Content savetContent(Content content)
        {
            return _provider.SaveContent(content);
        }
    }
}
