using TareasAPI.Models;

namespace TareasAPI.Services;

public class LicenciaService : ILicenciaService
{
    private readonly Licencia _licencia = new Licencia
    {
        Id               = 1,
        Nombre           = "Bob Esponja Pantalones Cuadrados",
        NumeroLicencia   = "FQ-000112",
        FechaNacimiento  = "14/07/1986",
        FechaVencimiento = "14/07/2030",
        TipoLicencia     = "Clase B",
        Direccion        = "Piña 124, Fondo de Bikini",
        Estado           = true,
        Foto             = "https://placecats.com/150/152"
    };

    public Licencia ObtenerLicencia() => _licencia;
}
