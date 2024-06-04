using EspacioCalculadora;
Calculadora miCalculadora = new Calculadora();
double respuesta, termino;
mostrarMenu();
double.TryParse(Console.ReadLine(), out respuesta);
do
{
    miCalculadora.MostrarHistorial();
    Console.WriteLine("Ingrese el valor:");
    double.TryParse(Console.ReadLine(), out termino);
    switch (respuesta)
    {
        case 1:
            miCalculadora.Sumar(termino);
            Console.WriteLine("El resultado es: " + miCalculadora.Resultado);
            break;
        case 2:
            miCalculadora.Restar(termino);
            Console.WriteLine("El resultado es: " + miCalculadora.Resultado);
            break;
        case 3:
            miCalculadora.Multiplicar(termino);
            Console.WriteLine("El resultado es: " + miCalculadora.Resultado);
            break;
        case 4:
            miCalculadora.Dividir(termino);
            Console.WriteLine("El resultado es: " + miCalculadora.Resultado);
            break;
    }
    mostrarMenu();
    double.TryParse(Console.ReadLine(), out respuesta);
} while (respuesta != 0);



void mostrarMenu()
{
    Console.WriteLine("Ingrese la operacion que realizara:");
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Multiplicar");
    Console.WriteLine("4.Dividir");
    Console.WriteLine("0.Salir");
}