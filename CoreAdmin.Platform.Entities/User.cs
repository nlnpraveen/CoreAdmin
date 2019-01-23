using CoreAdmin.Commons;
using System;

namespace CoreAdmin.Platform.Entities
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string Expires { get; set; }
        public User()
        {
            IsActive = true;
        }

    }
}
