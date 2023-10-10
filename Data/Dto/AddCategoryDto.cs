using Challenge.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dto
{
    public class AddCategoryDto
    {
        public string? ParentCategoryId { get; set; }
        public Category Category { get; set; }
    }
}
