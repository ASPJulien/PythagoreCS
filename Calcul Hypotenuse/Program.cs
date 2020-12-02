using System;

namespace Calcul_Hypotenuse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculation de l'hypoténuse");
            Calculate(lengthX(), lengthY(), nameZ());


            string nameX()
            {
                Console.WriteLine("Donnez le nom de la longueur connue \"x\" ");
                return Console.ReadLine();
            }

            double lengthX()
            {
                Console.WriteLine("Donnez la longueur de " + nameX());

                string LengthX = Console.ReadLine();
                bool lengthXCorrect = double.TryParse(LengthX, out _);

                if (!lengthXCorrect)
                {
                    Console.WriteLine("La longueur n'est pas correcte");
                    return 0;
                }
                else
                {
                    return double.Parse(LengthX);
                }
            }

            string nameY()
            {
                Console.WriteLine("Donnez le nom de la longueur connue \"y\" ");
                return Console.ReadLine();
            }

            double lengthY()
            {
                Console.WriteLine("Donnez la longueur de " + nameY());

                string LengthY = Console.ReadLine();
                bool lengthYCorrect = double.TryParse(LengthY, out _);

                if (!lengthYCorrect)
                {
                    Console.WriteLine("La longueur n'est pas correcte");
                    return 0;
                }
                else
                {
                    return double.Parse(LengthY);
                }
            }

            string nameZ()
            {
                Console.WriteLine("Donnez le nom de la longueur inconnue \"z\" ");
                return Console.ReadLine();
            }

            void Calculate(double _lengthX, double _lengthY, string _nameZ)
            {
                _lengthX = Math.Pow(_lengthX, 2);
                _lengthY = Math.Pow(_lengthY, 2);
                double lengthZ = _lengthX + _lengthY;

                Console.WriteLine(_nameZ + " est égal à ( racine carrée de ) " + lengthZ);
                lengthZ = Math.Sqrt(lengthZ);
                Console.WriteLine(_nameZ + " est ~ égal à " + lengthZ);
                Console.ReadLine();
                
            }
        }
    }
}