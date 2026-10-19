using TareasAPI.Models;
using TareasAPI.Services;

namespace TareasAPI.Endpoints;

public static class TareasEndpoints
{
    public static void MapTareaEndpoints(this WebApplication app)
    {
        MapGrupo(app, "/api/tareas");
        MapGrupo(app, "/tareas");
    }

    private static void MapGrupo(WebApplication app, string ruta)
    {
        var group = app.MapGroup(ruta).WithTags("Tareas");

        // Obtener todas las tareas
        group.MapGet("/", (ITareaService service) => Results.Ok(service.ObtenerTodas()));

        // Obtener una tarea por id
        group.MapGet("/{id}", (ITareaService service, int id) =>
        {
            var tarea = service.ObtenertareaPorId(id);
            return tarea is null
                ? Results.NotFound(new { mensaje = "Tarea no encontrada" })
                : Results.Ok(tarea);
        });

        // Crear una tarea
        group.MapPost("/", (ITareaService service, Tarea nuevaTarea) =>
        {
            var creada = service.CrearTarea(nuevaTarea);
            return Results.Created($"{ruta}/{creada.Id}", creada);
        });

        // Actualizar una tarea
        group.MapPut("/{id}", (ITareaService service, int id, Tarea tareaActualizada) =>
            service.ActualizarTarea(id, tareaActualizada)
                ? Results.NoContent()
                : Results.NotFound(new { mensaje = "Tarea no encontrada" }));

        // Eliminar una tarea
        group.MapDelete("/{id}", (ITareaService service, int id) =>
            service.Eliminar(id)
                ? Results.NoContent()
                : Results.NotFound(new { mensaje = "Tarea no encontrada" }));
    }
}

