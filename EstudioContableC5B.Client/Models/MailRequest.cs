namespace EstudioContableC5B.Client.Models
{
    public class MailRequest
    {
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    
        public string Nombre { get; set; }

        public string Apellido { get; set; } 
        public string NombreUsuario { get; set; }
        public string Direccion { get; set; }
        public string Direccion2 { get; set; }

        public string Pais { get; set; }
        public string Provincia { get; set; }

        public string Localidad { get; set; }

        public string Cuit { get; set; }
        public string Password { get; set;}

        public string Tramite { get; set; }


    }
}
