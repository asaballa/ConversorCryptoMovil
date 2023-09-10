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
    public partial class BilleteraNewItem : ContentPage
    {
        public BilleteraNewItem()
        {
            InitializeComponent();

            CriptomonedaPicker.Items.Add("Bitcoin");
            CriptomonedaPicker.Items.Add("Ethereum");
            CriptomonedaPicker.Items.Add("Cardano");
            CriptomonedaPicker.Items.Add("Solana");
            CriptomonedaPicker.Items.Add("Litecoin");
        }

        private void IngresarNuevoItemButton_Clicked(object sender, EventArgs e)
        {
            // Aquí puedes obtener el monto y la criptomoneda seleccionada
            string monto = MontoEntry.Text;
            string criptomoneda = CriptomonedaPicker.SelectedItem as string;

            // Agrega la lógica para ingresar el nuevo item a la billetera
        }
    }
}