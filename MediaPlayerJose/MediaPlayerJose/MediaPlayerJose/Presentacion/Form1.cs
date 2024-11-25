using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics.SymbolStore;


namespace MediaPlayerJose
{
    public partial class Form1 : Form
    {
        List<string> archivosFiltrados = new List<string>();
        FolderBrowserDialog navegador = new FolderBrowserDialog();
        int archivoActual = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AbrirCarpetaEvento(object sender, EventArgs e)
        {
            // Se limpia el reproductor y la lista
            VetanaReproductor.Ctlcontrols.stop();
            if (archivosFiltrados.Count > 1)
            {
                archivosFiltrados.Clear();
                archivosFiltrados = null;
                ListaReproduccion.Items.Clear();
                archivoActual = 0;
            }
            DialogResult result = navegador.ShowDialog();
            if (result == DialogResult.OK)
            {
                archivosFiltrados = Directory.GetFiles(navegador.SelectedPath, "*.*").Where(
                    archivo => archivo.ToLower().EndsWith("webm") || archivo.ToLower().EndsWith("mp4")
                    || archivo.ToLower().EndsWith("wmv") || archivo.ToLower().EndsWith("mkv")
                    || archivo.ToLower().EndsWith("avi")).ToList();
                CargarListaReproduccion();
            }
        }

        private void PlayStateChangeEvento(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 0)
            {
                etiquetaDuracion.Text = "El reproductor está en espera.";
            }
            else if (e.newState == 1)
            {
                etiquetaDuracion.Text = "Se paró el reproductor";
            }
            else if (e.newState == 3)
            {
                // se está reproduciendo un archivo
                etiquetaDuracion.Text = "Duración: " + VetanaReproductor.currentMedia.durationString;
            }
            else if (e.newState == 8)
            {
                // Se acabó el video, vuelva al inicio
                if (archivoActual >= archivosFiltrados.Count - 1)
                {
                    archivoActual = 0;
                }
                else
                // Se carga el siguiente video
                {
                    archivoActual += 1;
                }
                ListaReproduccion.SelectedIndex = archivoActual;
                MostrarNombreArchivo(nombreArchivo);
            }
            else if (e.newState == 9)
            {
                etiquetaDuracion.Text = "Cargando nuevo video.";
            }
            else if (e.newState == 10)
            {
                // Reproductor listo para cargar nuevo video
                timer1.Start();
            }
        }

        private void ListaReproduccionCambiadaEvento(object sender, EventArgs e)
        {
            archivoActual = ListaReproduccion.SelectedIndex;
            ReproducirArchivo(ListaReproduccion.SelectedItem.ToString());
            MostrarNombreArchivo(nombreArchivo);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TemporizadorEvento(object sender, EventArgs e)
        {
            VetanaReproductor.Ctlcontrols.play();
            timer1.Stop();

        }

        private void CargarListaReproduccion()
        {
            VetanaReproductor.currentPlaylist = VetanaReproductor.newPlaylist("Lista de reproduccion", " ");

            foreach (String Videos in archivosFiltrados)
            {
                VetanaReproductor.currentPlaylist.appendItem(VetanaReproductor.newMedia(Videos));
                ListaReproduccion.Items.Add(Videos);
            }

            if (archivosFiltrados.Count > 0)
            {
                nombreArchivo.Text = "Files Found " + archivosFiltrados.Count;
                ListaReproduccion.SelectedIndex = archivoActual;
                ReproducirArchivo(ListaReproduccion.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("No se encontraron archivos de video en esta carpeta.");
            }
        }

        private void ReproducirArchivo(String url)
        {
            VetanaReproductor.URL = url;
        }

        private void MostrarNombreArchivo(Label nombre)
        {
            String archivo = Path.GetFileName(ListaReproduccion.SelectedItem.ToString());
            nombre.Text = "Reproduciendo archivo: " + archivo;
        }

        private void VetanaReproductor_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void agregarVideoListaEvento(object sender, EventArgs e)
        {
           
        }
    }
}
