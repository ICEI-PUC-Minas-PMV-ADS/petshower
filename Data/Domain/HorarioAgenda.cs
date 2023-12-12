using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authen.Data.Domain
{
       public class HorarioAgenda
    {

        public int Id { get; set; }
         public DateTime HorarioInicio { get; set; } = DateTime.Now;
        public DateTime HorarioFim { get; set; } = DateTime.Now.AddHours(1);

        
        public int AgendaId { get; set; }

        public virtual Agenda Agenda { get; set; }
    }
}