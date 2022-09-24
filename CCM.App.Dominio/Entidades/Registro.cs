using System;

namespace CCM.App.Dominio
{

    public class Registro : Persona
    {
        public string apartamento { get; set; }
        public string asunto { get; set; }
        public DateTime fechaDeEntrada { get; set; }
        public DateTime fechaDeSalida { get; set; }
    }

}