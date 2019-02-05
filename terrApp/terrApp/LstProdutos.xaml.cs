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
    }
}