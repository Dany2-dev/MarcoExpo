using TareasAPI.Models;
using TareasAPI.Services;

namespace TareasAPI.Endpoint;

public static class TareasEndpoints{
    public static void MapTareaEndpoints(this WebApplication app)
    {
        //Get /api/tareas
        var group = app.MapGroup("/api/tareas").WithTags("Tareas");
        group.MapGet("/", (ITareaService services) => Result.Ok(services.ObtenerTodas()))

        //Get /tareas/{id}
        group.MapGet("/{id}",(ITareaService services, int id) =>
        {
            var tarea = services.ObtenerPorId(id);
            return tarea is null
                ? Result.NotFound(new {mensaje = "Tarea no encontrada"})
                : Result.Ok(tarea);
        });

        //Post /tareas
        group.MapPost("/",(ITareaService services, Tarea NuevaTarea) =>
        {
           var creada = service.Crear(NuevaTarea)
           return Result.Created($"/tareas/{creada.id}", creada); //201 
        });

        //Put /tareas/{id}
        group.MapPut("/{id}", (ITareaService service, int id, Tarea tareaActualizada) => 
        {
            service.Actualizar(id, tareaActualizada)
                ? Results.NoContent()//204
                : Results.NotFound(new {mensaje = "Tarea no encontrada"}); //404
        });

        //Delete /tareas/{id}
        group.MapDelete("/{id}", (ITareaService service, int id) => 
        {
            service.Eliminar(id)
                ? Results.NoContent()//204
                : Results.NotFound(new {mensaje = "Tarea no encontrada"}); //404
        });
        
    }
}