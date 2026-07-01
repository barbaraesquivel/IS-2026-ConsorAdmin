using BE;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SERV
{
    public static class ExportadorCsv
    {
        public static void ExportarBitacora(List<LogBitacoraBE> datos, string rutaArchivo)
        {
            using var writer = new StreamWriter(rutaArchivo, false, new UTF8Encoding(true));
            writer.WriteLine("FechaHora,Usuario,Modulo,Accion,Detalle");
            foreach (var l in datos)
            {
                string fecha = l.FechaHora.ToString("dd/MM/yyyy HH:mm:ss");
                string usuario = l.usuarioBE?.Usuario ?? l.Id_Usuario.ToString();
                writer.WriteLine(
                    $"{Escapar(fecha)},{Escapar(usuario)},{Escapar(l.Modulo)},{Escapar(l.Accion)},{Escapar(l.Detalle ?? "")}");
            }
        }

        private static string Escapar(string valor)
        {
            if (valor.Contains(',') || valor.Contains('"') || valor.Contains('\n'))
                return "\"" + valor.Replace("\"", "\"\"") + "\"";
            return valor;
        }
    }
}
