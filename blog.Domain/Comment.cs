using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Domain
{
    public class Comment
    {
        public Guid CommentId { get; set; }
        public string CommentText { get; set; }
    }
}
