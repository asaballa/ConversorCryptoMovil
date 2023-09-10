using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoversorCrypto.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Billetera : ContentPage
    {
        public Billetera()
        {
            InitializeComponent();
        }

        private async void IngresarNuevoItemButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BilleteraNewItem());
        }

        private async void ActualizarDatosButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BilleteraActualiza());
        }
    }
}