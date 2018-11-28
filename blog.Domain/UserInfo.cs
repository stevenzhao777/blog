using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blog.Domain
{
    [Table("user_info")]
    public class UserInfo
    {
        [Column("user_info_id")]
        public Guid UserInfoId {get; set;}
        [Column("address")]
        public string Address {get; set;}
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Column("email_address")]
        public string EmailAddress { get; set; }
    }
}
