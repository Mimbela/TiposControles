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
	public partial class PickerView : ContentPage
	{
        List<string> ingredientes;
		public PickerView ()
		{
			InitializeComponent ();
            ingredientes = new List<string>()
            { "leche","cacao","avellanas","azúcar"};
            foreach (string ing in ingredientes)
            {
                this.picker1.Items.Add(ing);
            }

            //otra forma de hacer el método delegado
            this.picker1.SelectedIndexChanged += (sender, args) => 
            {
                int indice = this.picker1.SelectedIndex;//selecciono el indice
                if (indice==-1)
                {
                    this.lbldato.Text = "No ha seleccionado nada";
                }
                else
                {
                    this.lbldato.Text = "Seleccionado " + this.ingredientes[indice];//seleccionado
                }

            };

            

		}
	}
}