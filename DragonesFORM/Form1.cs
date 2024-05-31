using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;




namespace DragonesFORM
{



    public partial class Form1 : Form
    {
        private SoundPlayer Sonido;

        public Form1()
        {
            InitializeComponent();


            Sonido = new SoundPlayer(@"C:/Users/mario/Downloads/ArchivoDragonesForm/Orquesta.wav");
            Sonido.Play();
        }

        private void bttonEnter_Click(object sender, EventArgs e)
        {
            // Detener la reproducción del sonido
            DetenerSonido();

            Form formulario = new RegistroDragon();
            formulario.Show();
            this.Hide();
        }
        private void DetenerSonido()
        {
            
            if (Sonido != null)
            {
               
                Sonido.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
