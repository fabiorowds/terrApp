using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terrApp.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace terrApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LstProdutos : ContentPage
	{
		public LstProdutos ()
		{
			InitializeComponent ();
		}

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new VerProduto());
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new CadProdutos());
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Carrinho());
        }

        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new CadUsuario());
        }
    }
}