using System.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authen.Data.Domain.Enums;

namespace Authen.Data.Domain
{
    public class Pet
    {
        public int Id {get; set;}
        public required string Nome {get; set;}
        public required string Raca {get; set;}
        public required Porte Porte {get; set;}
        public int ApplicationUserId{get; set;}
        public ApplicationUser ApplicationUser {get; set;}
    }
}