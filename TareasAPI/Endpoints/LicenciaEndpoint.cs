using TareasAPI.Services;

namespace TareasAPI.Endpoints;

public static class LicenciasEndpoints
{
    public static void MapLicenciaEndpoints(this WebApplication app)
    {
        // Obtener la licencia
        app.MapGet("/licencia", (ILicenciaService service) =>
            Results.Ok(service.ObtenerLicencia())).WithTags("Licencia");
    }
}
