using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EBarangaySystem.Models
{
    public class system_login_access
    {
        [Key]
        public int USER_ID { get; set; }
        public int SYSTEM_USER_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public int ROLE_ID { get; set; }
    }
}
