namespace BE
{
    public enum TipoDiferenciaDV
    {
        Modificada,  // la fila existe en ambos, pero algún campo difiere
        Faltante,    // existe en el backup pero no en la BD (fue borrada por fuera)
        Sobrante     // existe en la BD pero no en el backup (fue agregada por fuera)
    }

    public class DiferenciaDV
    {
        public string IdConsorcio    { get; set; } = string.Empty;
        public string Campo          { get; set; } = string.Empty;
        public string ValorBackup    { get; set; } = string.Empty;
        public string ValorActual    { get; set; } = string.Empty;
        public TipoDiferenciaDV TipoDiferencia { get; set; }
    }
}
