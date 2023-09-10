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
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private async void ConvertirMonedaButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConvierteCrypto());
        }

        private async void MiBilleteraButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Billetera());
        }
    }
}