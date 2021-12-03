using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreConfigurationSeperation.Models.Entity
{
    [Table("Adresses")]
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
