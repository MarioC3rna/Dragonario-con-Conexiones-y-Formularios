using DragonesFORM.Data.Acces;
using DragonesFORM.Data.Model;
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

using System.Media;
namespace DragonesFORM
{
    public partial class RegistroDragon : Form
    {
        private SoundPlayer Sonido;
        private Timer timer;
        Dragones especies = new Dragones();
        Conexion Clscone = new Conexion();
        private Conexion dragonescata;
        public RegistroDragon()
        {

            InitializeComponent();
            timer = new Timer();
            timer.Interval = 2000; 
            timer.Tick += Timer_Tick;
            dragonescata = new Conexion();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            
            Sonido.Stop();
          
            timer.Stop();
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttonInsert_Click(object sender, EventArgs e)
        {
            especies.numD = int.Parse(txtNo.Text);
            especies.nombre = txtNombre.Text;
            especies.tipo = txtTipo.Text;
            especies.habitat = txtHabitat.Text;
            especies.activo = txtActivo.Text;
            especies.fuerza = int.Parse(txtFuerza.Text);
            especies.agilidad = int.Parse(txtAgilidad.Text);
            especies.resistencia = int.Parse(txtResistencia.Text);
            especies.velocidad = int.Parse(txtVelocidad.Text);
            especies.inteligencia = int.Parse(txtInteligencia.Text);
            especies.carisma = int.Parse(txtCarisma.Text);
            especies.defensa = int.Parse(txtDefensa.Text);
            especies.experiencia = int.Parse(txtExperiencia.Text);
            especies.descripcion = txtDescripcion.Text;
            Clscone.Insertar(especies);
            dataGridView1.DataSource = dragonescata.LeerCatalogo();
            MessageBox.Show("Se ha agregado un Nuevo Dragon al libro");
            Sonido = new SoundPlayer(@"C:\Users\mario\Downloads\libro.wav");
            Sonido.Play();
            timer.Start();
        }

        private void bttonTabla_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    DataTable dt = dragonescata.LeerCatalogo();
                    dataGridView1.DataSource = dt;
                    Sonido = new SoundPlayer(@"C:\Users\mario\Downloads\libro.wav");
                    Sonido.Play();
                    timer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }

            }
            
        }
        private void BuscarPorId()
        {
            try
            {
                int idbuscar = int.Parse(txtNo.Text);
                DataTable dragondato = dragonescata.BuscarDragonPorId(idbuscar);
                if (dragondato.Rows.Count > 0)
                {
                    string nombre = dragondato.Rows[0]["nombre"].ToString();
                    string tipo = dragondato.Rows[0]["tipo"].ToString();
                    string habitat = dragondato.Rows[0]["habitat"].ToString();
                    string activo = dragondato.Rows[0]["activo"].ToString();
                    int fuerza = int.Parse(dragondato.Rows[0]["fuerza"].ToString());
                    int agilidad = int.Parse(dragondato.Rows[0]["agilidad"].ToString());
                    int resistencia = int.Parse(dragondato.Rows[0]["resistencia"].ToString());
                    int velocidad = int.Parse(dragondato.Rows[0]["velocidad"].ToString());
                    int inteligencia = int.Parse(dragondato.Rows[0]["inteligencia"].ToString());
                    int carisma = int.Parse(dragondato.Rows[0]["carisma"].ToString());
                    int defensa = int.Parse(dragondato.Rows[0]["defensa"].ToString());
                    int experiencia = int.Parse(dragondato.Rows[0]["experiencia"].ToString());
                    string descripcion = dragondato.Rows[0]["descripcion"].ToString();



                    txtNombre.Text = nombre;
                    txtTipo.Text = tipo;
                    txtHabitat.Text = habitat;
                    txtActivo.Text = activo;
                    txtFuerza.Text = fuerza.ToString();
                    txtAgilidad.Text = agilidad.ToString();
                    txtResistencia.Text = resistencia.ToString();
                    txtVelocidad.Text = velocidad.ToString();
                    txtInteligencia.Text = inteligencia.ToString();
                    txtCarisma.Text = carisma.ToString();
                    txtDefensa.Text = defensa.ToString();
                    txtExperiencia.Text = experiencia.ToString();
                    txtDescripcion.Text = descripcion;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar por ID: " + ex.Message);
            }
        }
        

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

            {
                
            }

        }

        private void bttonDelete_Click_1(object sender, EventArgs e)
        {
            especies.numD = int.Parse(txtNo.Text);
            especies.nombre = txtNombre.Text;
            especies.tipo = txtTipo.Text;
            especies.habitat = txtHabitat.Text;
            especies.activo = txtActivo.Text;
            especies.fuerza = int.Parse(txtFuerza.Text);
            especies.agilidad = int.Parse(txtAgilidad.Text);
            especies.resistencia = int.Parse(txtResistencia.Text);
            especies.velocidad = int.Parse(txtVelocidad.Text);
            especies.inteligencia = int.Parse(txtInteligencia.Text);
            especies.carisma = int.Parse(txtCarisma.Text);
            especies.defensa = int.Parse(txtDefensa.Text);
            especies.experiencia = int.Parse(txtExperiencia.Text);
            especies.descripcion = txtDescripcion.Text;
            Clscone.Delete(especies);
            dataGridView1.DataSource = dragonescata.LeerCatalogo();
            MessageBox.Show("Se ha eliminado el Dragón del Libro");
            Sonido = new SoundPlayer(@"C:\Users\mario\Downloads\libro.wav");
            Sonido.Play();
            timer.Start();
        }

        private void bttonLimpiar_Click(object sender, EventArgs e)
        {
           
           txtNo.Clear();
           txtNombre.Clear();
           txtTipo.Clear();
           txtHabitat.Clear();
           txtActivo.Clear();
           txtFuerza.Clear();
           txtResistencia.Clear();
           txtVelocidad.Clear();
           txtInteligencia.Clear();
           txtCarisma.Clear();
           txtDefensa.Clear();
           txtExperiencia.Clear();
           txtAgilidad.Clear();
           txtDescripcion.Clear();
            Sonido = new SoundPlayer(@"C:\Users\mario\Downloads\libro.wav");
            Sonido.Play();
            timer.Start();
        }

        private void gbox1_Enter(object sender, EventArgs e)
        {


        }

        private void bttonUpdate_Click_1(object sender, EventArgs e)
        {
            especies.numD = int.Parse(txtNo.Text);
            especies.nombre = txtNombre.Text;
            especies.tipo = txtTipo.Text;
            especies.habitat = txtHabitat.Text;
            especies.activo = txtActivo.Text;
            especies.fuerza = int.Parse(txtFuerza.Text);
            especies.agilidad = int.Parse(txtAgilidad.Text);
            especies.resistencia = int.Parse(txtResistencia.Text);
            especies.velocidad = int.Parse(txtVelocidad.Text);
            especies.inteligencia = int.Parse(txtInteligencia.Text);
            especies.carisma = int.Parse(txtCarisma.Text);
            especies.defensa = int.Parse(txtDefensa.Text);
            especies.experiencia = int.Parse(txtExperiencia.Text);
            especies.descripcion = txtDescripcion.Text;
            Clscone.Update(especies);
            dataGridView1.DataSource = dragonescata.LeerCatalogo();
            MessageBox.Show("Se han cambiado los atributos del Dragon");
            Sonido = new SoundPlayer(@"C:\Users\mario\Downloads\libro.wav");
            Sonido.Play();
            timer.Start();
        }

        private void bttonSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarPorId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: ");
            }
            Sonido = new SoundPlayer(@"C:\Users\mario\Downloads\libro.wav");
            Sonido.Play();
            timer.Start();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegistroDragon_Load(object sender, EventArgs e)
        {

        }
    }
}