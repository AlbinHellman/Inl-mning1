using System;
using System.Collections.Generic;

#nullable disable

namespace daaataabasefirst.Entities
{
    public partial class UserHash
    {
        public int UserId { get; set; }
        public string UserHash1 { get; set; }
        public string UserSalt { get; set; }

        public virtual User User { get; set; }
    }
}
