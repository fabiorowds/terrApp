using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terrApp.Database;
using terrApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace terrApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadUsuario : ContentPage
    {
        public CadUsuario()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Usuario objUser = new Usuario();
            objUser.Nome = xNome.Text;
            objUser.Email = xEmail.Text;
            objUser.Telefone = xTelefone.Text;
            objUser.CPF = xCPF.Text;
            objUser.Endereco = xLocalizacao.Text;
            

        }
    }
}