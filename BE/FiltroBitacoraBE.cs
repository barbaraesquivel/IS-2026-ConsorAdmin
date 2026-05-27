using System;

namespace BE
{
    public class FiltroBitacoraBE
    {
        public string IdUsuario   { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string Modulo      { get; set; }
        public string Accion      { get; set; }
    }
}
