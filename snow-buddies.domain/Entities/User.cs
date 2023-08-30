using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace snow_buddies.domain.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; } 
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}