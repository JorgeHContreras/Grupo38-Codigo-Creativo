using System;

namespace CCM.App.Dominio
{

    public class ResidenteCorrespondencia : Residente
    {
        public string Tipo {get;set;}
        public string asunto { get; set; }
        public string Remitente {get;set;}
        public string Receptor {get;set;}
        public DateTime fecha { get; set; }

    }

}