﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoversorCrypto.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConvierteCryptoResult : ContentPage
    {
        public ConvierteCryptoResult()
        {
            InitializeComponent();
        }
        private async void VolverAConvertirButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConvierteCrypto());
        }
    }
}