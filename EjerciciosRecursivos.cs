
namespace CatalogoRecursividad
{
    internal class EjerciciosRecursivos
    {
        // EJERCICIO 1: FACTORIAL
        public long Factorial(int numero)
        {
            // Caso base
            if (numero == 0)
                return 1;

            // Caso recursivo
            return numero * Factorial(numero - 1);
        }

        // EJERCICIO 2: FIBONACCI
        public long Fibonacci(int numero)
        {
            // Caso base
            if (numero == 0 || numero == 1)
                return numero;

            // Caso recursivo
            return Fibonacci(numero - 1) + Fibonacci(numero - 2);
        }

        // EJERCICIO 3: TORRES DE HANOI
        public void TorresHanoi(
            int discos, char origen, char auxiliar, char destino)
        {
            // Caso base
            if (discos == 1)
            {
                Console.WriteLine(
                    $"Mover disco de {origen} a {destino}");
                return;
            }

            // Caso recursivo
            TorresHanoi(discos - 1, origen, destino, auxiliar);

            Console.WriteLine(
                $"Mover disco de {origen} a {destino}");

            TorresHanoi(discos - 1, auxiliar, origen, destino);
        }

        // EJERCICIO 4: SUMA DE ARREGLOS
        public int SumaArreglo(int[] arreglo, int posicion)
        {
            // Caso base
            if (posicion == arreglo.Length)
                return 0;

            // Caso recursivo
            return arreglo[posicion] +
                   SumaArreglo(arreglo, posicion + 1);
        }

        // EJERCICIO 5: BUSQUEDA LINEAL
        public int BusquedaLineal(
            int[] arreglo, int buscado, int posicion)
        {
            // Caso base: elemento no encontrado
            if (posicion >= arreglo.Length)
                return -1;

            // Caso base: elemento encontrado
            if (arreglo[posicion] == buscado)
                return posicion;

            // Caso recursivo
            return BusquedaLineal(
                arreglo, buscado, posicion + 1);
        }
    }
}
