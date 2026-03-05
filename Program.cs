using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_10_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cree un diccionario donde la clave sea el carné (int) y el valor sea una tupla con Nombre, Edad y Carrera. Permita agregar 3 estudiantes y luego muestre toda la información usando foreach.");
            Dictionary<int,(string,int,string)>carne=new Dictionary<int,(string,int,string)>();
            int clave;
            string nombre;
            int edad;
            string carrera;
            for (int i = 0; i < 3; i++)
           {
                Console.WriteLine($"Ingrese  ID NO.{i + 1} de 3 productos");
                int.TryParse(Console.ReadLine(), out clave);
                if (carne.ContainsKey(clave))
                {
                    Console.WriteLine("ID ya ingresado");
                    i--;

                }
                else
                {
                    Console.WriteLine("ingrese nombre:");
                    nombre = Console.ReadLine();
                    Console.WriteLine("ingrese edad");
                    int.TryParse (Console.ReadLine(), out edad);
                    Console.WriteLine("ingrese carrera");
                    carrera = Console.ReadLine();
                    carne.Add(clave,(nombre,edad,carrera));

                }

            }
           
            foreach (var item in carne)
            {
                Console.WriteLine("carne Id: " + item.Key + "valor: " + item.Value);

            }

        }
    }
}
