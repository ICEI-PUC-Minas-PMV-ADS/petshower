using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authen.Data.Domain
{
    public class Agenda
    {
         public Agenda()
        {
          HorarioAgenda = new List<HorarioAgenda>();
        }
        public  int Id {get; set;}
        public List<HorarioAgenda> HorarioAgenda { get; set; }
    }
}