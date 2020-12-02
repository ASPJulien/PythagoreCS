using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace PythagoreCS_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        CultureInfo ci = CultureInfo.InstalledUICulture;
        private static bool Calcul = true; // true = calcul hypotenuse
        
        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            double lengthX;
            double lengthY;

            bool isCorrect;
            isCorrect = double.TryParse(LongeurX.Text, out lengthX);
            if (isCorrect == false)
            {
                MessageBox.Show("Erreur, Merci de recommencer");
                Environment.Exit(0);                
            }
            isCorrect = double.TryParse(LongeurY.Text, out lengthY);
            if (isCorrect == false)
            {
                MessageBox.Show("Erreur, Merci de recommencer");
                Environment.Exit(0);
            }

            if (Calcul == true)
            {
                CalculHypotenuse.Calcul(lengthX, lengthY, NomZ.Text);
            }
            else
            {
                CalculCote.Calcul(lengthX, lengthY, NomZ.Text);
            }
        }

        private void RadioButton_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            Calcul = true;
        }
        
        private void RadioButton_Checked_1(object sender, System.Windows.RoutedEventArgs e)
        {
            Calcul = false;
        }
        
    }   
}