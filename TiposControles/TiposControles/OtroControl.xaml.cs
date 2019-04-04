using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposControles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OtroControl : ContentPage
	{
        bool ventanaactiva;
        public OtroControl ()
		{
			InitializeComponent ();

            this.slider1.ValueChanged += Slider1_ValueChanged;
            this.stepper1.ValueChanged += Stepper1_ValueChanged;

            this.progreso.Progress = 0;
		}

        private void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.lblstepper.Text = "Stepper: " + e.NewValue;
        }

        private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.lblslider.Text = "Slider: " + e.NewValue; 
        }

        protected override void OnAppearing()

        {

            base.OnAppearing();

            ventanaactiva = true;
            Device.StartTimer(TimeSpan.FromSeconds(0.1), TimerCallBack);

        }
        bool TimerCallBack()

        {

            this.progreso.Progress += 0.01;
            return ventanaactiva || this.progreso.Progress == 1;

            //Le

        }





        protected override void OnDisappearing()

        {

            base.OnDisappearing();

            ventanaactiva = false;

        }


    }
}