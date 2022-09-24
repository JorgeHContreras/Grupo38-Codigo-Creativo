using System;
using System.ComponentModel.DataAnnotations;

namespace CCM.App.Dominio
{

    public class Residente : Persona
    {
        [Required, StringLength(50)]
        public string apartamento{get;set;}

    }

}