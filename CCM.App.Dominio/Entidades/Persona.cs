using System.ComponentModel.DataAnnotations;
using System;

namespace CCM.App.Dominio
{

    public class Persona
    {
        public int id { get; set; }
        [Required, StringLength(50)]
        public string nombre { get; set; }
        [Required, StringLength(50)]
        public string apellido { get; set; }
        [Required]
        public int cedula { get; set; }
    }

}