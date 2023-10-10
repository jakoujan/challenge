using Challenge.Data.Entity;
using Data.Dto;
using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Data.Provider
{
    public interface IContentProvider
    {
        public IEnumerable<Content> GetContents();
        public Content SaveContent(Content content);
    }
}
