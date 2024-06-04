namespace EspacioCalculadora
{
    public class Operacion
    {
        private double resultadoAnterior;
        private double nuevoValor;
        private TipoOperacion operacionTipo;

        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacionTipo)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacionTipo = operacionTipo;
        }
        public double Resultado
        {
            get => resultadoAnterior;
        }
        public double NuevoValor
        { 
            get => nuevoValor; 
        }
        public TipoOperacion OperacionTipo { get => operacionTipo; }

        public enum TipoOperacion
        {
            Suma,
            Resta,
            Multiplicacion,
            Division,
            Limpiar
        }
    }
    class Calculadora
    {
        private List<Operacion> Historial;
        private double dato;

        public Calculadora()
        {
            Historial = new List<Operacion>();
            this.dato = 0;
        }

        
        public double Resultado { get => dato; }
        //public List<Operacion> Historial { get => historial; set => historial = value; }

        public void Sumar(double termino)
        {
            dato = Resultado + termino;
            Historial.Add(new Operacion(Resultado,dato,Operacion.TipoOperacion.Suma));
        }
        public void Restar(double termino)
        {
            dato = Resultado - termino;
            Historial.Add(new Operacion(Resultado,dato,Operacion.TipoOperacion.Resta));
        }
        public void Multiplicar(double termino)
        {
            dato = Resultado * termino;
            Historial.Add(new Operacion(Resultado,dato,Operacion.TipoOperacion.Multiplicacion));
        }
        public void Dividir(double termino)
        {
            dato = Resultado / termino;
            Historial.Add(new Operacion(Resultado,dato,Operacion.TipoOperacion.Division));
        }
        public void Limpiar()
        {
            dato = 0;
        }
        public void MostrarHistorial()
        {
            if (Historial.Count == 0)
            {
                Console.WriteLine("No hay operaciones en el historial.");
                return;
            }

            foreach (var operacion in Historial)
            {
                Console.WriteLine("Operacion: "+operacion.OperacionTipo);
                Console.WriteLine("Valor: "+operacion.NuevoValor);
                Console.WriteLine("Resultado: "+operacion.Resultado);
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}