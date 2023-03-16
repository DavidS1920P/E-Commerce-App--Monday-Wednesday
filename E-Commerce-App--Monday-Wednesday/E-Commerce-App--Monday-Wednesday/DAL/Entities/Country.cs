﻿using System.ComponentModel.DataAnnotations;

namespace E_Commerce_App__Monday_Wednesday.DAL.Entities
{
    public class Country : Entity
    {

        [Display (Name = "Paìs")]
        [MaxLength(50, ErrorMessage ="El Campo {0} Debe ser de {1} Caracteres.")]
        [Required(ErrorMessage ="El campo {0} es obligatorio.")]
        public string Name { get; set; }

        public ICollection<State> State { get; set; }    
    }
}
