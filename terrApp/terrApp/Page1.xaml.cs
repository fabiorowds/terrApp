﻿using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace terrApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("Nenhuma Câmera", ":( Nenuma Câmera disponível.", "OK");
                return;
            }

            var armazenamento = new StoreCameraMediaOptions()
            {
                SaveToAlbum = true,
                Name = "MinhaFoto.jpg"
            };

            var foto = await CrossMedia.Current.TakePhotoAsync(armazenamento);

            if (foto == null)
            {
                return;
            }

            imgFoto.Source = ImageSource.FromStream(() => 
            {
                var stream = foto.GetStream();
                foto.Dispose();
                return stream;
            });
        }

        private void BtnSelecionarImg_Clicked(object sender, EventArgs e)
        {

        }
    }
}