namespace BE
{
    public interface IEntidad
    {
        Guid Id { get; set; }
        bool Baja { get; set; }
    }
}
