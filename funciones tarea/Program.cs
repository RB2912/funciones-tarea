// See https://aka.ms/new-console-template for more information 

//1.Crear una función que calcule el área de un círculo, recibiendo como parámetro el radio.

//namespace CalcularAreaCirculo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double radio = 11.0;
//            double area = radio * radio * Math.PI;
//            Console.WriteLine($"El área del círculo con radio {radio} es {area}");
//        }
//    }
//}


//2.Crear una función que calcule el perímetro de un rectángulo, recibiendo como parámetros el ancho y la altura


//namespace CalcularPerimetroRectangulo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double ancho = 15.0;
//            double altura = 25.0;
//            double perimetro = CalcularPerimetro(ancho, altura);
//            Console.WriteLine($"El perímetro del rectángulo con ancho {ancho} y altura {altura} es {perimetro}");
//        }

//        static double CalcularPerimetro(double ancho, double altura)
//        {
//            double perimetro = 2 * (ancho + altura);
//            return perimetro;
//        }
//    }
//}

//3.Crear una función que calcule el promedio de una lista de números, recibiendo como parámetro una lista de enteros.


//namespace CalcularPromedioLista
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            List<int> numeros = new List<int>() { 2, 4, 6, 8, 10 };
//            double promedio = CalcularPromedio(numeros);
//            Console.WriteLine($"El promedio de la lista es {promedio}");
//        }

//        static double CalcularPromedio(List<int> numeros)
//        {
//            return numeros.Count > 0 ? (double)numeros.Sum() / numeros.Count : 0;
//        }
//    }
//}

//4.Crear una función que determine si un número es par o impar, recibiendo como parámetro el número.

//namespace ParImpar
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int numero = 6;
//            if (EsPar(numero))
//            {
//                Console.WriteLine($"{numero} es un número par");
//            }
//            else
//            {
//                Console.WriteLine($"{numero} es un número impar");
//            }
//        }

//        static bool EsPar(int numero)
//        {
//            return numero % 2 == 0;
//        }
//    }
//}

//5.Crear una función que convierta una cadena a mayúsculas, recibiendo como parámetro la cadena.

//namespace ConvertirMayusculas
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Ejemplo de uso
//            string cadena = "hola mundo!";
//            Console.WriteLine($"Cadena original: {cadena}");
//            string cadenaMayusculas = ConvertirAMayusculas(cadena);
//            Console.WriteLine($"Cadena en mayúsculas: {cadenaMayusculas}");
//        }

//        static string ConvertirAMayusculas(string cadena)
//        {
//            return cadena.ToUpper();
//        }
//    }
//}


//6.Crear una función que calcule la distancia entre dos puntos en un plano cartesiano, recibiendo como parámetros las coordenadas x e y de ambos puntos.

//namespace CalcularDistanciaEntrePuntos
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Ejemplo de uso
//            double x1 = 1.0;
//            double y1 = 2.0;
//            double x2 = 4.0;
//            double y2 = 6.0;

//            double distancia = CalcularDistanciaEntrePuntos(x1, y1, x2, y2);

//            Console.WriteLine($"La distancia entre los puntos ({x1},{y1}) y ({x2},{y2}) es: {distancia}");
//        }

//        static double CalcularDistanciaEntrePuntos(double x1, double y1, double x2, double y2)
//        {
//            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//            return distancia;
//        }
//    }
//}

//7.Crear una función que calcule la suma de los primeros n números naturales, recibiendo como parámetro el número n.

//public int SumaNaturales(int n)
//{
//    int suma = 0;

//    for (int i = 1; i <= n; i++)
//    {
//        suma += i;
//    }

//    return suma;
//}


//8.Crear una función que calcule el factorial de un número, recibiendo como parámetro el número.
//public int Factorial(int n)
//{
//    int factorial = 1;

//    for (int i = 1; i <= n; i++)
//    {
//        factorial *= i;
//    }

//    return factorial;
//}







