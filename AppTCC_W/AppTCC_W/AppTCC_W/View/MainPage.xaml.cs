using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppTCC_W.View;
namespace AppTCC_W
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnusuarios.Source = ImageSource.FromResource("AppTCC_W.Img.usuario.png");
            btnmedicamentos.Source = ImageSource.FromResource("AppTCC_W.Img.medicamentos.png");
            btnhistorico.Source = ImageSource.FromResource("AppTCC_W.Img.historico.png");
            btnsos.Source = ImageSource.FromResource("AppTCC_W.Img.sos.png");
        }

        private async void btn_usuarios(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Usuario());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro", ex.Message, "OK");
            }

        }

        private void btn_medicamentos(object sender, EventArgs e)
        {

        }

        private void btn_historico(object sender, EventArgs e)
        {

        }

        private void btn_sos(object sender, EventArgs e)
        {

        }
    }
}
