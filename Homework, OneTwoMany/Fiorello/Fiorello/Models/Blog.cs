using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class Blog : BaseEntity
    {
        public string Image { get; set; }
        public DateTime PublishDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
