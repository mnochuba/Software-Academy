using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemOne
{
    public abstract class Programme
    {
        public List<Student> Students { get; set; }
        public List<Facilitator> Facilitators { get; set; }
        public List<WeekDay> ClassDays { get; protected set; } = new List<WeekDay> { WeekDay.Tuesday, WeekDay.Thursday };
    }
}
