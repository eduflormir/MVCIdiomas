using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MvcIdiomas.Idiomas;

namespace MvcIdiomas.Models
{
    public class Persona
    {
        [Display(ResourceType=typeof(Personas),Name = "nombre")]
        [Required]
        public String Nombre { get; set; }

        
        [DataType(DataType.Currency,ErrorMessageResourceType =typeof(Personas),ErrorMessageResourceName = "saldo_c")]
        [Display(ResourceType = typeof(Personas), Name = "saldo")]
        [Required(ErrorMessageResourceType=typeof(Personas),ErrorMessageResourceName = "saldo_c")]
        public double Saldo { get; set; } 


    }
}