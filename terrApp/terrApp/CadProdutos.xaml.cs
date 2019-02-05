using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terrApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace terrApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadProdutos : ContentPage
	{

        MediaFile photo;

        public CadProdutos ()
		{
			InitializeComponent ();
		}

        private async void BtnFoto_Clicked(object sender, EventArgs e)
        {
            photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions() { });
            if (photo != null)
            {
                imgProduto.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
            }
        }

        private void BtnGravar_Clicked(object sender, EventArgs e)
        {
            Gravar();
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            imgProduto.Source = null;
            txtValor.Text = string.Empty;
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
                await DisplayAlert("Atenção!", "Item " + item.ID + " gravado com sucesso!", "OK");
                LimparCampos();
            }
            else
            {
                await DisplayAlert("Atenção!", "Erro ao gravar item!", "OK");
            }
        }
    }
}