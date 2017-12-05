using System;

namespace Core.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }        
        public DateTime CreationDate { get; set; }
        public DateTime LastModification { get; set; }
        public virtual Role Role { get; set; }

        public User()
        {
            this.CreationDate = DateTime.Now;
        }
    }
}
