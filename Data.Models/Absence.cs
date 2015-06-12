using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Absence
    {
        public int Id { get; set; }

        public DateTime AbsenceDate { get; set; }

        public int UserId { get; set; }

        public virtual User Student { get; set; }

        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
    }
}
