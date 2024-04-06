using Movie_Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Core.Entities.Concrete
{
    public class Comment : BaseEntity
    {
        public int MovieId { get; set; }
        public string UserComment { get; set; }
        public string UserName { get; set; }
    }
}
