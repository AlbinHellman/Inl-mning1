using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace daaataabasefirst.Models
{
    public class UserModel
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Business { get; set; }
        public string Private { get; set; }

    }
}
