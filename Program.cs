
using CatalogoRecursividad;

EjerciciosRecursivos ejercicios = new EjerciciosRecursivos();

int opcion;

do
{
    Console.Clear();

    Console.WriteLine("==================================");
    Console.WriteLine("      CATALOGO DE RECURSIVIDAD");
    Console.WriteLine("==================================");
    Console.WriteLine("1. Factorial");
    Console.WriteLine("2. Fibonacci");
    Console.WriteLine("3. Torres de Hanoi");
    Console.WriteLine("4. Suma de arreglos");
    Console.WriteLine("5. Busqueda lineal recursiva");
    Console.WriteLine("6. Salir");
    Console.WriteLine("==================================");

    Console.Write("Seleccione una opcion: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        opcion = 0;
    }

    Console.Clear();

    switch (opcion)
    {
        case 1:
            // FACTORIAL
            Console.WriteLine("EJERCICIO 1: FACTORIAL");

            int numero = LeerEntero("Ingrese un numero (0-20): ", 0, 20);

            Console.WriteLine(
                $"Resultado: {ejercicios.Factorial(numero)}");
            break;

        case 2:
            // FIBONACCI
            Console.WriteLine("EJERCICIO 2: FIBONACCI");

            int cantidad = LeerEntero(
                "Cantidad de numeros (1-40): ", 1, 40);

            Console.WriteLine("Secuencia Fibonacci:");

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write(ejercicios.Fibonacci(i) + " ");
            }

            Console.WriteLine();
            break;

        case 3:
            // TORRES DE HANOI
            Console.WriteLine("EJERCICIO 3: TORRES DE HANOI");

            int discos = LeerEntero(
                "Ingrese la cantidad de discos (1-10): ", 1, 10);

            Console.WriteLine("\nMovimientos:");

            ejercicios.TorresHanoi(discos, 'A', 'B', 'C');
            break;

        case 4:
            // SUMA DE ARREGLOS
            Console.WriteLine("EJERCICIO 4: SUMA DE ARREGLOS");

            int tamanio = LeerEntero(
                "Cantidad de elementos (1-100): ", 1, 100);

            int[] arreglo = new int[tamanio];

            for (int i = 0; i < tamanio; i++)
            {
                arreglo[i] = LeerEntero(
                    $"Ingrese el elemento {i + 1}: ",
                    int.MinValue, int.MaxValue);
            }

            int suma = ejercicios.SumaArreglo(arreglo, 0);

            Console.WriteLine($"\nLa suma total es: {suma}");
            break;

        case 5:
            // BUSQUEDA LINEAL
            Console.WriteLine("EJERCICIO 5: BUSQUEDA LINEAL");

            int cantidadElementos = LeerEntero(
                "Cantidad de elementos (1-100): ", 1, 100);

            int[] datos = new int[cantidadElementos];

            for (int i = 0; i < cantidadElementos; i++)
            {
                datos[i] = LeerEntero(
                    $"Ingrese el elemento {i + 1}: ",
                    int.MinValue, int.MaxValue);
            }

            int buscado = LeerEntero(
                "\nNumero que desea buscar: ",
                int.MinValue, int.MaxValue);

            int resultado = ejercicios.BusquedaLineal(
                datos, buscado, 0);

            if (resultado != -1)
            {
                Console.WriteLine(
                    $"Elemento encontrado en la posicion {resultado}.");
            }
            else
            {
                Console.WriteLine("El elemento no fue encontrado.");
            }
            break;

        case 6:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opcion no valida.");
            break;
    }

    if (opcion != 6)
    {
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }

} while (opcion != 6);


// METODO AUXILIAR PARA VALIDAR ENTRADAS
static int LeerEntero(string mensaje, int minimo, int maximo)
{
    int valor;

    while (true)
    {
        Console.Write(mensaje);

        if (int.TryParse(Console.ReadLine(), out valor) &&
            valor >= minimo && valor <= maximo)
        {
            return valor;
        }

        Console.WriteLine("Entrada no valida. Intente nuevamente.");
    }
}
