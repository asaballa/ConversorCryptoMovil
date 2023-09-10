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
    public partial class ConvierteCrypto : ContentPage
    {
        public ConvierteCrypto()
        {
            InitializeComponent();

            CriptomonedaPicker.Items.Add("Bitcoin");
            CriptomonedaPicker.Items.Add("Ethereum");
            CriptomonedaPicker.Items.Add("Cardano");
            CriptomonedaPicker.Items.Add("Solana");
            CriptomonedaPicker.Items.Add("Litecoin");

            MonedaTradicionalPicker.Items.Add("USD");
            MonedaTradicionalPicker.Items.Add("Euro");
            MonedaTradicionalPicker.Items.Add("Peso Argentino");
            MonedaTradicionalPicker.Items.Add("Peso Chileno");
            MonedaTradicionalPicker.Items.Add("Sol");
            MonedaTradicionalPicker.Items.Add("Real");
        }

        private async void ConvertirButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConvierteCryptoResult());

            // Aquí agregarás la lógica para realizar la conversión de criptomoneda a moneda tradicional
            //string monto = MontoEntry.Text;
            //string criptomoneda = CriptomonedaPicker.SelectedItem.ToString();
            //string monedaTradicional = MonedaTradicionalPicker.SelectedItem.ToString();

            // Realiza la conversión y muestra el resultado
            // Puedes mostrar el resultado en un Label o realizar cualquier otra acción necesaria.
        }
    }
}