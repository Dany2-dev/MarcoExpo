using TareasAPI.Models;
using TareasAPI.Services;

namespace TareasAPI.Endpoint;

public static class TareasEndpoints{
    public static void MapTareaEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/api/tareas").WithTags("Tareas");
        group.MapGet("/", (ITareaService services) => Result.Ok(services.ObtenerTodas()))
        group.MapGet("/{id}",(ITareaService services, int id) =>
        {
            var tarea = services.ObtenerPorId(id);
            return tarea is null
                ? Result.NotFound(new {mensaje = "Tarea no encontrada"})
                : Result.Ok(tarea);
        });
        
    }
}