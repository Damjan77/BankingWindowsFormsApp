using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public partial class UserRole
    {
        [Key]
        public int roleId { get; set; }

        [Required]
        [StringLength(255)]
        public string roleName { get; set; }
    }
}
