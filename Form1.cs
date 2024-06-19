using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Archivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Presionaste el botón");
            await TareaAsincronica();
            Console.WriteLine("Finalizó el código del botón");
        }


        //funcion asincrona
        private async Task TareaAsincronica()
        {
            Console.Out.WriteLine("Tarea asincronica en progreso");
            await Task.Delay(20000); //20 segundos
            Console.WriteLine("La tartea asincrona ha finalizado");

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Esperemos a que termine de ejecutarse la tarea");
            await Prueba_TareaAsincronica();
            Console.WriteLine("Ha terminado de ejecutarse la tarea");

        }

        private async Task Prueba_TareaAsincronica()
        {
            Console.Out.WriteLine("Prueba de tarea asincronica en progreso");
            await Task.Delay(15000); //15 segundos
            Console.WriteLine("La tarea asincrona ha finalizado");

        }

        private void Imprimir_Click(object sender, EventArgs e)
        {

            if (obtenerValoresJson().Length <= 0)
            {
                MessageBox.Show("No encontramos nada");
            }
            else
            {
                Cedula.Text = obtenerValoresJson()[0];
                Nombre.Text = obtenerValoresJson()[1] + "  " + obtenerValoresJson()[2];
                Edad.Text = obtenerValoresJson()[3];

            }
         
        }

        private string[] obtenerValoresJson()
        {
            string[] valores = {"","","","" };

            string ubicacionJson = Path.Combine("Jsons", "persona.json");

            try
            {
                //MessageBox.Show("Vamos bien, encontramos el archivo");

                string jsonContent = File.ReadAllText(ubicacionJson);
                var datosDelJson = JsonConvert.DeserializeObject<dynamic>(jsonContent);

                valores[0] = datosDelJson.cedula;
                valores[1] = datosDelJson.nombre;
                valores[2] = datosDelJson.apellido;
                valores[3] = datosDelJson.edad;
            }
            catch (FileNotFoundException fnfEx)
            {
                Console.WriteLine(fnfEx.Message);
            }

            return valores;
        }

        //botón que convierte la fecha actual según el pais
        private async void button3_Click(object sender, EventArgs e)
        {
            txtHoraActual.Text = await obtenerFechaActual(Paises.SelectedItem.ToString());
        }


        private async Task<string> obtenerFechaActual (string zona)
        {
            string fechaActual = "";

            try
            {
                using (HttpClient Client = new HttpClient())
                {
                    string url = $"http://worldtimeapi.org/api/timezonea/{zona}";

                    HttpResponseMessage response = await Client.GetAsync(url);

                    string respuesta = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(respuesta);


                    fechaActual = json["datetime"] +"";

                    //MessageBox.Show(fechaActual);
                }
                

            }
            catch (HttpRequestException httrEx)
            {
                Console.WriteLine("Ocurrio un error: =>" + httrEx.Message);
            }
            return fechaActual;
        }


        //botón que convierte la moneda
        private async void button4_Click(object sender, EventArgs e)
        {
            double MonedaConvertida = await CambioDolar(Dolares.Text, TipoCambio.SelectedItem.ToString());

            Resultado.Text = MonedaConvertida.ToString();
        }

        private async Task<double> CambioDolar(string CantDolar, string Moneda)
        {
            Double CambioMoneda = 0;

            try
            {
                using (HttpClient Client = new HttpClient())
                {
                    string url = $"https://api.frankfurter.app/latest?amount={CantDolar}&from=USD&to={Moneda}";

                    HttpResponseMessage response = await Client.GetAsync(url);

                    string respuesta = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(respuesta);


                    CambioMoneda = Convert.ToDouble( json["rates"][Moneda] );

                   
                }

            }
            catch (HttpRequestException httrEx)
            {
                Console.WriteLine("Ocurrio un error: =>" + httrEx.Message);
            }
            return CambioMoneda;
        }
    }
}
