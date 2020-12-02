using System;
using System.Windows;

namespace PythagoreCS_WPF
{
    public static class CalculHypotenuse
    {
        public static void Calcul(double lengthX, double lengthY, string nameZ)
        {
            lengthX = Math.Pow(lengthX, 2);
            lengthY = Math.Pow(lengthY, 2);
            double lengthZ = lengthX + lengthY;

            MessageBox.Show(nameZ + " est égal à ( racine carrée de ) " + lengthZ);
            lengthZ = Math.Sqrt(lengthZ);
            MessageBox.Show(nameZ + " est ~ égal à " + lengthZ);
        }

    }
}