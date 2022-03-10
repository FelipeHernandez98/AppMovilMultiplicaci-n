using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BotonesXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeraPagina : ContentPage
    {
        public PrimeraPagina()
        {
            InitializeComponent();
        }

        private void btnRedireccionar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}