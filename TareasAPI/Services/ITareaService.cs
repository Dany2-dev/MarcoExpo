using TareasAPI.Models;

namespace TareasAPI.Services;

public interface ITareaService
{
    IEnumerable<Tarea> ObtenerTodas();
    Tarea? ObtenertareaPorId(int id);
    Tarea CrearTarea(Tarea tarea);
    bool ActualizarTarea(int id, Tarea tarea);
    bool Eliminar(int id);
}
