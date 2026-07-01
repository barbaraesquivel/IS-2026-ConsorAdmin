using BE;
using System.Collections.Generic;

namespace SERV
{
    public static class CalculadoraDV
    {
        // DVH: cada char se multiplica por su posición i (base 1) y por la posición del
        // atributo j (base 1). Así, intercambiar dos chars dentro de un campo, o dos campos
        // entre sí, produce un acumulador distinto y por lo tanto un DVH distinto.
        public static int CalcularDVH(IVerificable obj)
        {
            long acum = 0;
            var valores = obj.ObtenerValoresParaDV();
            for (int j = 0; j < valores.Count; j++)
            {
                string val = valores[j] ?? string.Empty;
                for (int i = 0; i < val.Length; i++)
                    acum += (long)val[i] * (i + 1) * (j + 1);
            }
            return (int)(acum % 9973);
        }

        // DVV: suma de los DVH almacenados de todas las filas. Detecta filas agregadas
        // o eliminadas por fuera del sistema (cambia la suma total).
        public static int CalcularDVV(IEnumerable<IVerificable> filas)
        {
            long suma = 0;
            foreach (var fila in filas)
                suma += fila.DVH;
            return (int)(suma % 9973);
        }
    }
}
