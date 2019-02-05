using System;
using System.IO;
using terrApp.Database;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace terrApp
{
    public partial class App : Application
    {

        static CartaoCreditoDB dbCartao;
        static ItemDB dbItem;
        static PedidoDB dbPedido;
        static PedidoItemDB dbPedidoItem;
        static SecaoDB dbSecao;
        static UsuarioDB dbUsuario;

        public static CartaoCreditoDB DbCartao
        {
            get
            {
                if (dbCartao == null)
                {
                    dbCartao = new CartaoCreditoDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Banco.db3"));
                }
                return dbCartao;
            }
        }

        public static ItemDB DbItem
        {
            get
            {
                if (dbItem == null)
                {
                    dbItem = new ItemDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Banco.db3"));
                }
                return dbItem;
            }
        }

        public static PedidoDB DbPedido
        {
            get
            {
                if (dbPedido == null)
                {
                    dbPedido = new PedidoDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Banco.db3"));
                }
                return dbPedido;
            }
        }

        public static PedidoItemDB DbPedidoItem
        {
            get
            {
                if (dbPedidoItem == null)
                {
                    dbPedidoItem = new PedidoItemDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Banco.db3"));
                }
                return dbPedidoItem;
            }
        }

        public static SecaoDB DbSecao
        {
            get
            {
                if (dbSecao == null)
                {
                    dbSecao = new SecaoDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Banco.db3"));
                }
                return dbSecao;
            }
        }

        public static UsuarioDB DbUsuario
        {
            get
            {
                if (dbUsuario == null)
                {
                    dbUsuario = new UsuarioDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Banco.db3"));
                }
                return dbUsuario;
            }
        }


        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            MainPage = new CadItem();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
