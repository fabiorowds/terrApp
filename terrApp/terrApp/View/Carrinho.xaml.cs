using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace terrApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carrinho : ContentPage
    {
        public Carrinho()
        {
            InitializeComponent();
        }

        private void BtnPagar_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new RealizarPagamento());
        }

        private void BtnContinuarComprando_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
    }
}