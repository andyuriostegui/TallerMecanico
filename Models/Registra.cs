using System;

namespace TallerMecanico.Models
{
    public class Registra
    {
        public int IdRegistro { get; set; }
        public DateTime FechaHoraReg { get; set; }
        public string Lugar { get; set; }
        public int IdEmpleado { get; set; }
        public int IdCliente { get; set; }
    }
}
