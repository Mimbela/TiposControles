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
	public partial class practica1 : ContentPage
	{
        List<int> dias;
        List<int> years;
        List<string> meses;
        
		public practica1 ()
		{
			InitializeComponent ();
            //------------------------
            dias = new List<int>();
            for (int i = 1; i <=31; i++)
            {
                this.dias.Add(i);

            }
            foreach (int d in dias)
            {
                this.pickerdia.Items.Add(d.ToString());
            }

            //----
            years = new List<int>();
            for (int i = 1985; i <= 2019; i++)
            {
                this.years.Add(i);

            }
            foreach (int d in years)
            {
                this.pickeranyo.Items.Add(d.ToString());
            }
            //--------------------
            meses = new List<string>()
            {
                "enero","febrero","marzo","abril","mayo","junio","julio","agosto","septiembre",
                "octubre","noviembre","diciembre"
            };
            foreach (string m in meses)
            {
                this.pickermes.Items.Add(m);
            }

            //---------------
           

        }
        private void btnmostrardia_Click(object sender, EventArgs e)
        {
            int dia;
            int mes;
            int anyo;
            dia = int.Parse(pickerdia.SelectedItem.ToString());
            mes = pickermes.SelectedIndex+1;
            anyo = int.Parse(pickeranyo.SelectedItem.ToString());
            if (mes == 1)
            {
                mes = 13;
                anyo = anyo - 1;
            }
            else if (mes == 2)
            {
                mes = 14;
                anyo = anyo - 1;
            }
            int op1 = ((mes + 1) * 3) / 5;
            int op2 = anyo / 4;
            int op3 = anyo / 100;
            int op4 = anyo / 400;
            /*5.	Sumar el dia, el doble del mes, el año, 
             * el resultado de la operación 1, el resultado de la operación 2,
             * menos el resultado de la operación 3 más la operación 4 más 2.*/
            //  15 + (6 * 2) + 1997 + 4 + 499 - 19 + 4 + 2
            int op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            //7.	Restar el número del paso 5 con el número del paso 6 por 7.
            //2514 – (359 * 7)
            int resultado = op5 - (op6 * 7);

            String diasemana = "";
            if (resultado == 0)
            {
                diasemana = "Sábado";
            }
            else if (resultado == 1)
            {
                diasemana = "DOMINGO";
            }
            else if (resultado == 2)
            {
                diasemana = "LUNES";
            }
            else if (resultado == 3)
            {
                diasemana = "MARTES";
            }
            else if (resultado == 4)
            {
                diasemana = "MIERCOLES";
            }
            else if (resultado == 5)
            {
                diasemana = "JUEVES";
            }
            else if (resultado == 6)
            {
                diasemana = "VIERNES";
            }
            lbldato.Text = diasemana;
        }

    }

    //----------------


}