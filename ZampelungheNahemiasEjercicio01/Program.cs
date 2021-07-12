using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZampelungheNahemiasEjercicio01
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.Title = "Triangulo Rectangulo";
			double cateto1, cateto2;
			double superficie, perimetro, hipotenusa;

			Console.Write("ingrese el cateto Nº 1: ");
			cateto1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("ingrese el cateto Nº 2: ");
			cateto2 = Convert.ToDouble(Console.ReadLine());

			superficie = (cateto1 * cateto2) / 2;
			hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
			perimetro = cateto1 + cateto2 + hipotenusa;
			Console.WriteLine($"La superficie de un triangulo rectangulo cuyos catetos son: {cateto1} y {cateto2} es de {superficie}");
			Console.WriteLine($"El perimetro de un triangulo rectangulo cuyos catetos son: {cateto1} y {cateto2} es de {perimetro}");
			Console.ReadKey();
		}
	}
}
