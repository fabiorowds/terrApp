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
    public partial class DefaultContentPage : ContentPage
    {
        public DefaultContentPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Chamar tela de listagem de produtos
            Application.Current.MainPage = new LstProdutos();
        }
    }
}