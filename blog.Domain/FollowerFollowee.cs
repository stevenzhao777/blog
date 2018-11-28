using System;
using System.Collections.Generic;
using System.Text;

namespace blog.Domain
{
    public class FollowerFollowee
    {
        public Guid FollowerId { get; set; }
        public User Follower { get; set; }

        public Guid FolloweeId { get; set; }
        public User Followee { get; set; }
    }
}
