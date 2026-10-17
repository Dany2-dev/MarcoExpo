using TareasAPI.Models;
using TareasAPI.Services;

namespace TareasAPI.Endpoint;

public static class TareasEndpoints{
    public static void MapTareaEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/api/tareas").WithTags("Tareas");
        group.MapGet("/", )
        
    }
}