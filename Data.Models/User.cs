using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User
    {
        public User()
        {
            this.Absences = new HashSet<Absence>();
        }

        [Key]
        public int Id { get; set; }

        public string Username { get; set; }

        public string PassHash { get; set; }

        public Role Role { get; set; }

        public virtual HashSet<Absence> Absences { get; set; }
    }
}
