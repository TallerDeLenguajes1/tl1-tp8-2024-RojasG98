public class Tarea
{
    private int tareaId;
    private string descripcion;
    private int duracion;
    private EstadoTarea estado = EstadoTarea.Pendiente;
    
    public Tarea(int tareaId, string descripcion, int duracion)
    {
        this.tareaId = tareaId;
        this.descripcion = descripcion;
        this.duracion = duracion;
    }

    public int TareaId { get => tareaId; set => tareaId = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    internal EstadoTarea Estado { get => estado; set => estado = value; }
}