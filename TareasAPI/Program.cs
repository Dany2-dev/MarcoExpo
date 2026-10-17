var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("AllowAll");

app.UseHttpsRedirection();
// Datos temporales de la licencia en memoria
var licenciaActual = new Licencia
{
    Nombre = "Bob Esponja Pantalones Cuadrados",
    NumeroLicencia = "FQ-000112",
    FechaNacimiento = "14/07/1986",
    FechaVencimiento = "14/07/2030",
    TipoLicencia = "Clase B",
    Direccion = "Piña 124, Fondo de Bikini",
    Estado = "Activa",
    Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ25Zq0Z0lNdRVbjFGH5du0249Dh3pGfX0ekEGoEhRaipZXK4o8BusOKww&s=100"
};

// Endpoints CRUD
app.MapGet("/tareas", () => Results.Ok(tareas));

app.MapGet("/tareas/{id}", (int id) =>
{
    var t = tareas.FirstOrDefault(t => t.Id == id);
    return t == null ? Results.NotFound(new { mensaje = "Tarea no encontrada" }) : Results.Ok(t);
});

app.MapPost("/tareas", (Tarea nueva) =>
{
    if (string.IsNullOrWhiteSpace(nueva.Titulo))
        return Results.BadRequest(new { error = "El título es obligatorio" });

    nueva.Id = tareas.Count > 0 ? tareas.Max(t => t.Id) + 1 : 1;
    tareas.Add(nueva);
    return Results.Created($"/tareas/{nueva.Id}", nueva);
});

app.MapPut("/tareas/{id}", (int id, Tarea actualizada) =>
{
    var t = tareas.FirstOrDefault(t => t.Id == id);
    if (t == null) return Results.NotFound(new { mensaje = "Tarea no encontrada" });

    t.Titulo = actualizada.Titulo;
    t.Descripcion = actualizada.Descripcion;
    t.Completada = actualizada.Completada;

    return Results.NoContent();
});

app.MapDelete("/tareas/{id}", (int id) =>
{
    var t = tareas.FirstOrDefault(t => t.Id == id);
    if (t == null) return Results.NotFound(new { mensaje = "Tarea no encontrada" });

    tareas.Remove(t);
    return Results.NoContent();
});

// Endpoint para obtener la información de la licencia (Get Info / Back)
app.MapGet("/licencia", () => Results.Ok(licenciaActual));

app.Run();