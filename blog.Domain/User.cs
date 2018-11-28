using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace blog.Domain
{
    [Table("users")]
    public class User
    {
        public User()
        {
            Blogs = new List<Blog>();
        }

        [Column("user_id")]
        public Guid UserId { get; set; }
        [Column("user_name")]
        public string UserName { get; set; }
        [Column("passcode")]
        public string Passcode { get; set; }

        public List<Blog> Blogs { get; set; }
        public UserInfo UserInfo { get; set; }
        public List<FollowerFollowee> Followers { get; set; }
        public List<FollowerFollowee> Followees { get; set; }
    }
}
