namespace TareasAPI.Models;
public class Licencia
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string NumeroLicencia { get; set; } = string.Empty;
    public string FechaNacimiento { get; set; } = string.Empty;
    public string FechaVencimiento { get; set; } = string.Empty;
    public string TipoLicencia { get; set; } = string.Empty;
    public string Direccion { get; set; } = string.Empty;
    public bool Estado { get; set; } = true;
    public string Foto { get; set; } = string.Empty;
}


