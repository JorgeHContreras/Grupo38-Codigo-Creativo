using System;

namespace CCM.App.Dominio
{

    public class RegistroParqueadero : Registro
    {
        public string placa { get; set; }
        public string parqueadero { get; set; }
        public string observaciones { get; set; }
    }

}