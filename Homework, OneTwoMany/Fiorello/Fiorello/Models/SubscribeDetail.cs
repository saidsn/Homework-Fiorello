using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class SubscribeDetail : BaseEntity
    {
        public string Title { get; set; }
        public string Input { get; set; }
        public string Button { get; set; }
    }
}
