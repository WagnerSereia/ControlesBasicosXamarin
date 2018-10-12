using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.ControlesBasicos.Classes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XF.ControlesBasicos
{
    public partial class App : Application
    {
        public static Configuracao configuracao { get; set; }

        public App()
        {
            if (configuracao == null)
                configuracao = new Configuracao();

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
