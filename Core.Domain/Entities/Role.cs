using System;
using System.Collections.Generic;

namespace Core.Domain.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModification { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Privilege> Privileges { get; set; }

        public Role()
        {
            this.Users = new List<User>();
            this.Privileges = new List<Privilege>();
            this.CreationDate = DateTime.Now;
        }
    }
}
