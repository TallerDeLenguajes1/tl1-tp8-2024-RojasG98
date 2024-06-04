string[] descripciones = { "Crear puntero", "Hacer lista", "Tomar mate", "Dormir" };
var seed = Environment.TickCount;
var random = new Random(seed);
int idTar = 1000;
string descripcion;
List<Tarea> TareasPendientes = new List<Tarea>();
List<Tarea> TareasRealizadas = new List<Tarea>();


Console.WriteLine("Ingrese un numero N");
Int32.TryParse(Console.ReadLine(), out int N);
TareasPendientes = crearTareas(N, idTar);
pasaraRealizadas(TareasPendientes, TareasRealizadas);
Console.WriteLine("------------PENDIENTES-------------");
mostrarTareas(TareasPendientes);
Console.WriteLine("------------REALIZADAS-------------");
mostrarTareas(TareasRealizadas);
Console.WriteLine("Ingrese la descripcion de la tarea pendiente que quiere buscar:");
descripcion = Console.ReadLine();
Tarea porDesc = BuscarTarea(TareasPendientes,descripcion);
if (porDesc != null)
{
    mostrarTarea(porDesc);
}
else
{
    Console.WriteLine("No se encontro la tarea");
}



void mostrarTareas(List<Tarea> tareas)
{
    foreach (var tarea in tareas)
    {
        Console.WriteLine("Tarea: " + tarea.TareaId);
        Console.WriteLine("Descripcion: " + tarea.Descripcion);
        Console.WriteLine("Duracion: " + tarea.Duracion);

    }
}

void mostrarTarea(Tarea tarea)
{
    Console.WriteLine("Tarea: " + tarea.TareaId);
    Console.WriteLine("Descripcion: " + tarea.Descripcion);
    Console.WriteLine("Duracion: " + tarea.Duracion);

}


List<Tarea> crearTareas(int cantidad, int idTar)
{
    List<Tarea> tareas = new List<Tarea>();
    for (int i = 0; i < cantidad; i++)
    {
        var ndescripcion = random.Next(0, 3);
        var id = idTar++;
        var dur = random.Next(100);
        tareas.Add(new Tarea(id, descripciones[ndescripcion], dur));

    }
    return tareas;
}
void pasaraRealizadas(List<Tarea> pendientes, List<Tarea> realizadas)
{
    int resp = 1;

    do
    {
        int borrar = -1;
        int indice = 0;
        mostrarTareas(pendientes);
        Console.WriteLine("Ingrese el ID de la tarea Realizada");
        Int32.TryParse(Console.ReadLine(), out int id);

        foreach (var tareas in pendientes)
        {
            if (tareas.TareaId == id)
            {
                realizadas.Add(tareas);
                borrar = indice;
            }
            indice++;
        }
        if (borrar != -1)
        {
            pendientes.Remove(pendientes[borrar]);
        }
        Console.WriteLine("Desea mover otra tarea?1.SI 2.NO");
        Int32.TryParse(Console.ReadLine(), out resp);
    } while (resp == 1);



}
Tarea? BuscarTarea(List<Tarea> tareas, string descripcion)
{

    foreach (var tarea in tareas)
    {
        if (tarea.Descripcion.Contains(descripcion))
        {
            return tarea;
        }
    }
    return null;
}