using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
        public class MainPageViewModel : BindableObject
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Edad { get; set; }
            public string Correo { get; set; }
            public Command EnviarCommand { get; }

            public MainPageViewModel()
            {
                EnviarCommand = new Command(Enviar);
            }

            private void Enviar()
            {
                var secondPage = new Page1();
                secondPage.BindingContext = this;

                // Obtén la instancia de NavigationPage actual desde la MainPage
                var navigationPage = (Application.Current.MainPage as NavigationPage);

                // Realiza la navegación utilizando PushAsync del NavigationPage
                navigationPage.PushAsync(secondPage);
            }
        }
    }
}
