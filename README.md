# Catálogo de Recursividad en C#

## Descripción

Este proyecto consiste en una aplicación de consola desarrollada en C# que implementa cinco ejercicios utilizando la técnica de programación recursiva.

El objetivo es comprender cómo funciona la recursividad, identificar los casos base y recursivos de cada algoritmo y observar cómo se resuelven diferentes problemas mediante llamadas sucesivas a un mismo método.

## Tecnologías utilizadas

- Lenguaje: C#
- Plataforma: .NET
- Entorno de desarrollo: Visual Studio
- Tipo de aplicación: Consola

## Ejercicios implementados

### 1. Factorial
Calcula el factorial de un número entero mediante llamadas recursivas.

- Caso base: cuando el número es 0, devuelve 1.
- Caso recursivo: multiplica el número actual por el factorial del número anterior.

### 2. Fibonacci
Genera una sucesión de Fibonacci utilizando recursividad.

- Caso base: cuando el número es 0 o 1, devuelve el mismo número.
- Caso recursivo: suma los dos valores anteriores de la sucesión.

### 3. Torres de Hanoi
Resuelve el problema de las Torres de Hanoi mostrando los movimientos necesarios para trasladar los discos entre tres torres.

- Caso base: cuando queda un solo disco, lo mueve directamente al destino.
- Caso recursivo: mueve los discos superiores a la torre auxiliar, traslada el disco restante y después mueve los discos auxiliares al destino.

### 4. Suma de arreglos
Calcula la suma de todos los elementos de un arreglo mediante llamadas recursivas.

- Caso base: cuando la posición alcanza el tamaño del arreglo, devuelve 0.
- Caso recursivo: suma el elemento actual con el resultado de la siguiente posición.

### 5. Búsqueda lineal recursiva
Busca un elemento dentro de un arreglo recorriendo sus posiciones de manera recursiva.

- Caso base: devuelve -1 cuando llega al final sin encontrar el elemento.
- Caso recursivo: compara el elemento actual y continúa con la siguiente posición si no coincide.

## Estructura del proyecto

```text
CatalogoRecursividad/
│
├── Program.cs
├── EjerciciosRecursivos.cs
├── CatalogoRecursividad.csproj
└── README.md
```

## Ejecución

1. Clonar o descargar el repositorio.
2. Abrir el proyecto en Visual Studio.
3. Ejecutar la aplicación.
4. Seleccionar uno de los ejercicios disponibles en el menú.
5. Introducir los datos solicitados y observar el resultado.

También se puede ejecutar desde una terminal ubicada en la carpeta del proyecto:

```bash
dotnet run
```

## Pruebas realizadas

Se realizaron pruebas para comprobar el funcionamiento de cada algoritmo:

| Ejercicio | Entrada | Resultado esperado |
|---|---|---|
| Factorial | 5 | 120 |
| Fibonacci | 8 números | 0, 1, 1, 2, 3, 5, 8, 13 |
| Torres de Hanoi | 3 discos | 7 movimientos |
| Suma de arreglos | 2, 4, 6, 8 | 20 |
| Búsqueda lineal | Buscar 6 | Posición 2 |

## Autor

Alumno: Cristofer Alejandro Barboza Chavez

## Propósito académico

Proyecto realizado como parte de la Unidad 2: Recursividad, en la asignatura de Estructuras de Datos.
