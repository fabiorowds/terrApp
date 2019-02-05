using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terrApp.Database;
using terrApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace terrApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadItem : ContentPage
	{
        MediaFile photo;

        public CadItem ()
		{
			InitializeComponent ();
		}

        
        private async void Gravar()
        {
            Item item = new Item();
            //Secao secao = await App.DbSecao.GetSecaoAsync();

            item.Descricao = txtDescricao.Text;
            item.IDUsuario = 1;
            item.Nome = txtNome.Text;
            decimal decValor = 0;

            if (decimal.TryParse(txtValor.Text, out decValor))
            {
                item.Valor = Convert.ToDecimal(txtValor.Text);
            }

            if (photo != null)
            {
                MemoryStream msImage = new MemoryStream();
                photo.GetStream().CopyTo(msImage);
                photo.Dispose();

                item.Imagem = msImage.ToArray();
            }
            if (await App.DbItem.SaveItemAsync(item) == 1)
            {
                await DisplayAlert("Atenção!", "Item gravado com sucesso!", "OK");
                //this.cli
            }
            else
            {
                await DisplayAlert("Atenção!", "Erro ao gravar item!", "OK");
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions() { });
            if (photo != null)
            {
                imgFoto.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Gravar();
        }
    }
}