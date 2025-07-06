namespace TallerMecanico.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
    }
}
