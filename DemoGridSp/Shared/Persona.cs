namespace DemoGridSp.Shared;

public class Persona
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public int Puntuacion { get; set; }
    public bool Activo { get; set; }
    public DateTime FechaNacimiento { get; set; }
}