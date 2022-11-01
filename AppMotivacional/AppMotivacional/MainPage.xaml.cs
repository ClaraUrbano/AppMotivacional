using AppMotivacional.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMotivacional
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnMotivacional_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(cidadeEntry.Text))
                {
                    Tempo previsaoDoTempo = await DataService.GetPrevisaoDoTempo(cidadeEntry.Text);
                    this.BindingContext = previsaoDoTempo;
                    btnPrevisao.Text = "Nova Previsâo";
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}
