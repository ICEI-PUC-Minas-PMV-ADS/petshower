using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authen.Data.Domain
{
    public class TosadorBanhista
    {
        public int Id {get; set;}
        public required string Nome {get; set;}
        public int? AgendaId {get;set;}
        public Agenda Agenda {get; set;}
    }
}