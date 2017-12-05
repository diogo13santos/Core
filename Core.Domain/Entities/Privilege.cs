using System;

namespace Core.Domain.Entities
{
    public class Privilege
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModification { get; set; }
        public virtual Resource Resource { get; set; }
        public virtual Role Role { get; set; }
    }
}