﻿/*
En un proyecto de biblioteca de clases, crear las clases modeladas en el siguiente diagrama:

Diagrama de clases

Ambas clases deberán encontrarse dentro de un espacio de nombres (namespace) llamado Geometria.

La clase Punto debe tener:

Dos atributos privados con acceso de sólo lectura (sólo con getters), que serán las coordenadas del punto.
Un constructor que reciba los parámetros x e y.
La clase Rectangulo:

Tiene los atributos de tipo Punto: vertice1, vertice2, vertice3 y vertice4 (que corresponden a los cuatro vértices del rectángulo).
La base de todos los rectángulos de esta clase será siempre horizontal. El constructor para calculará los vértices 2 y 4 del rectángulo a partir de los vértices 1 y 3. Utilizar el método Abs de la clase Math que retorna el valor absoluto de un número y será necesario para obtener la distancia entre puntos.
Realizar los métodos getters para los atributos privados area y perimetro.
El área (base * altura) y el perímetro ((base + altura) / 2) se deberán calcular sólo una vez cuando se llame por primera vez a su correspondiente método getter. En las siguientes invocaciones de dichos métodos se deberá retornar siempre el valor calculado anteriormente.
Crear un proyecto de consola.
En la clase Program, desarrollar un método de clase (estático) que muestre todos los datos de una instancia de Rectangulo que reciba como parámetro.
En el método Main probar las funcionalidades de las clases Punto y Rectángulo.
Instanciar un nuevo Rectangulo.
Imprimir por pantalla los valores de área y perímetro.
 */


using ClassLibrary_Geometry;

namespace Ejercicio_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crear un nuevo rectángulo
            Point vertex1 = new Point(7, 8);
            Point vertex3 = new Point(5, 4);
            Rectangle rectangle = new Rectangle(vertex1, vertex3);

            // Imprimir el área y perímetro
            Console.WriteLine("Área: " + rectangle.Area);
            Console.WriteLine("Perímetro: " + rectangle.Perimeter);

            // Esperar a que el usuario presione una tecla para salir
            Console.ReadKey();
        }
    }
}