using System.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authen.Data.Domain.Enums;

namespace Authen.Data.Domain
{
    public class Agendamento
    {
        public int Id {get; set;}
        public DateTime Data {get; set;}
        public string Horario {get; set;}
        public required Servico Servico {get; set;}
        public int PetId { get; set; }
        public Pet Pet { get; set; }
        public int TosadorBanhistaId { get; set; }
        public TosadorBanhista TosadorBanhista { get; set; }
        public string ApplicationUserId {get; set;}
        public ApplicationUser ApplicationUser {get; set;}
    }
}