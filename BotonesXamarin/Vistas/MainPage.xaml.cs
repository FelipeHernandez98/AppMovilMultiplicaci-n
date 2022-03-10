using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BotonesXamarin.Vistas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        double n1;
        double n2;
        double result;

        private void btnhola_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alerta", "Hola", "OK");
        }

        private void btncasa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeraPagina());
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            calcular();
        }

        private void calcular()
        {
            if (!string.IsNullOrEmpty(txtnumero1.Text))
            {
                if (!string.IsNullOrEmpty(txtnumero2.Text))
                {
                    n1 = Convert.ToDouble( txtnumero1.Text);
                    n2 = Convert.ToDouble( txtnumero2.Text);
                    result = n1 * n2;
                    DisplayAlert("Resultado", "El resultado es: " + result.ToString(), "Aceptar");
                }
                else
                {
                    DisplayAlert("Error", "Ingrese el numero 2", "Aceptar");
                }
                
            }
            else
            {
                DisplayAlert("Error", "Ingrese el numero 1", "Aceptar");
            }
            
        }
    }
}
