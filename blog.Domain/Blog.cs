using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Domain
{
    public class Blog
    {
        public Blog()
        {
            Comments = new List<Comment>();
        }

        public Guid BlogId { get; set; }
        public string BlogText { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
