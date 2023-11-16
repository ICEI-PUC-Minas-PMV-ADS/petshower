﻿namespace PetShower.Domain.Models
{
    public class Gender : EntityBase
    {
        public virtual required string Name { get; set; }
        public virtual string? Description { get; set; }
    }
}