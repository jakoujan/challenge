using Challenge.Data.Entity;
using Challenge.Data.Provider;
using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Challenge.Data.Provider
{
    public class ContentProvider : IContentProvider
    {
        private List<Content> Contents = new List<Content>
            {
                new Content()
                {
                    Id = "00012",
                    Title = "Title",
                    PrettyURL = "",
                    SubTitle = "SubTitulo",
                    HeadLine = "HeadLine",
                    Author = "Author",
                }
            };
        public IEnumerable<Content> GetContents()
        {
            return Contents;
        }

        public Content SaveContent(Content content)
        {
            Contents.Add(content);
            return content;
        }
    }
}
