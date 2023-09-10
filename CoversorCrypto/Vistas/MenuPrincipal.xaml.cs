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
    public partial class MenuPrincipal : ContentPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }

        private void LoginWithFacebookButton_Clicked(object sender, EventArgs e)
        {
            // Aquí agregarás la lógica para iniciar sesión con Facebook.
        }

        private void LoginWithTwitterButton_Clicked(object sender, EventArgs e)
        {
            // Aquí agregarás la lógica para iniciar sesión con Twitter.
        }

        private void LoginWithGoogleButton_Clicked(object sender, EventArgs e)
        {
            // Aquí agregarás la lógica para iniciar sesión con Google.
        }
    }
}