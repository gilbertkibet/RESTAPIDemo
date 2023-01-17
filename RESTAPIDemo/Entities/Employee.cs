using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPIDemo.Entities
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage ="Name can only be 50 characters long")]
        public string FullName { get; set; }

        public string Email { get; set; }

        public long Phone { get; set; }

        public long Salary { get; set; }

        public string Department { get; set; }

        public DateTime DateofJoin { get; set; }

        public bool IsActive { get; set; }
    }
}
