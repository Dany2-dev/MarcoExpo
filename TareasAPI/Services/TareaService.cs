using TareasAPI.Models;

namespace TareasAPI.Services;

public class TareaService : ITareaService
{
    private readonly List<Tarea> _tareas = new List<Tarea>();
    {
        new Tarea { Id = 1, Titulo = "Aprender .NET", Completada = false },
        new Tarea { Id = 2, Titulo = "Crear mi primera API", Completada = true }
    }

    public IEnumerable<Tarea> ObtenerTodas() => _tareas;
    public Tarea? ObtenertareaPorId(int id) => _tareas.FirstOrDefault(t => t.Id == id);
    public Tarea CrearTarea(Tarea tarea){
        tarea.Id = _tareas.Count > 0 ? _tareas.Max(t => t.Id) + 1 : 1;
        _tareas.Add(tarea);
        return tarea;
    }
    public Tarea ActualizarTarea(Tarea tarea){
        var existente = ObtenertareaPorId(id);
        if (existente is null) return false;
        existente.Titulo = tarea.titulo;
        existente.Descripcion = tarea.descripcion;
        existente.Completada = tarea.completada;

        return true;
    }

    public bool Eliminar(int id){
        var existente = ObtenertareaPorId(id);
        if (existente is null ) return false
        _tareas.Remove(existente);
        return true;
    }
} 