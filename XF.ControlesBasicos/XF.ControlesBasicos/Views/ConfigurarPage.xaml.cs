using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.ControlesBasicos.Classes;

namespace XF.ControlesBasicos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfigurarPage : ContentPage
    {
        public ConfigurarPage()
        {
            BindingContext = App.configuracao;
            InitializeComponent();
        }

        private void AceitaReceberEmail_Changed(object sender, EventArgs e)
        {
            var selectedItem = ((SwitchCell)sender).BindingContext as Configuracao;

            if (selectedItem.AceitaReceberEmail)
                txtEnderecoEmail.IsVisible = true;
            else
                txtEnderecoEmail.IsVisible = false;
        }
    }
}