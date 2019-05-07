using System;

namespace Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public UserType UserType { get; set; }
    }
}
