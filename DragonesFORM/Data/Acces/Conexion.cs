using DragonesFORM.Data.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonesFORM.Data.Acces
{
    internal class Conexion
    {
        private string connectionString = "Server=localhost;Database=db_universidad;Uid=root;Pwd=53150944cerna";
        MySqlConnection connection;

        public Conexion()
        {
            connection = new MySqlConnection(connectionString);
        }

        public void Insertar(Dragones especies)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO dragonario (numD, nombre, tipo, habitat, activo, fuerza, agilidad, resistencia, velocidad, inteligencia, carisma, defensa, experiencia, descripcion) VALUES (@numD, @nombre, @tipo, @habitat, @activo, @fuerza, @agilidad, @resistencia, @velocidad, @inteligencia, @carisma, @defensa, @experiencia, @descripcion)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@numD", especies.numD);
                    cmd.Parameters.AddWithValue("@nombre", especies.nombre);
                    cmd.Parameters.AddWithValue("@tipo", especies.tipo);
                    cmd.Parameters.AddWithValue("@habitat", especies.habitat);
                    cmd.Parameters.AddWithValue("@activo", especies.activo);
                    cmd.Parameters.AddWithValue("@fuerza", especies.fuerza);
                    cmd.Parameters.AddWithValue("@agilidad", especies.agilidad);
                    cmd.Parameters.AddWithValue("@resistencia", especies.resistencia);
                    cmd.Parameters.AddWithValue("@velocidad", especies.velocidad);
                    cmd.Parameters.AddWithValue("@inteligencia", especies.inteligencia);
                    cmd.Parameters.AddWithValue("@carisma", especies.carisma);
                    cmd.Parameters.AddWithValue("@defensa", especies.defensa);
                    cmd.Parameters.AddWithValue("@experiencia", especies.experiencia);
                    cmd.Parameters.AddWithValue("@descripcion", especies.descripcion);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }
        public void Update(Dragones especies)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE dragonario SET nombre = @nombre, tipo = @tipo, habitat = @habitat, activo = @activo, fuerza = @fuerza, agilidad = @agilidad, resistencia = @resistencia, velocidad = @velocidad, inteligencia = @inteligencia, carisma = @carisma, defensa = @defensa, experiencia = @experiencia, descripcion = @descripcion WHERE numD = @numD";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@numD", especies.numD);
                    cmd.Parameters.AddWithValue("@nombre", especies.nombre);
                    cmd.Parameters.AddWithValue("@tipo", especies.tipo);
                    cmd.Parameters.AddWithValue("@habitat", especies.habitat);
                    cmd.Parameters.AddWithValue("@activo", especies.activo);
                    cmd.Parameters.AddWithValue("@fuerza", especies.fuerza);
                    cmd.Parameters.AddWithValue("@agilidad", especies.agilidad);
                    cmd.Parameters.AddWithValue("@resistencia", especies.resistencia);
                    cmd.Parameters.AddWithValue("@velocidad", especies.velocidad);
                    cmd.Parameters.AddWithValue("@inteligencia", especies.inteligencia);
                    cmd.Parameters.AddWithValue("@carisma", especies.carisma);
                    cmd.Parameters.AddWithValue("@defensa", especies.defensa);
                    cmd.Parameters.AddWithValue("@experiencia", especies.experiencia);
                    cmd.Parameters.AddWithValue("@descripcion", especies.descripcion);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void Delete(Dragones especies)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Consulta SQL para eliminar el registro
                    string query = "DELETE FROM dragonario WHERE numD = @numD";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@numD", especies.numD);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public DataTable BuscarDragonPorId(int numD)
        {
            DataTable dragonescata = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM dragonario WHERE numD = @numD";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@numD", numD);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dragonescata);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el dragon por numero: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return dragonescata;
        }

        internal void Insertar(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9, string text10, string text11, string text12, string text13)
        {
            throw new NotImplementedException();
        }

        public List<Dragones> ObtenerTodosLosDragones()
        {
            List<Dragones> vikinga = new List<Dragones>();
            string query = "SELECT*FROM dragonario";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Dragones dragones = new Dragones
                    (
                     numD: reader.GetInt32("numD"),
                     nombre: reader.GetString("nombre"),
                     tipo: reader.GetString("tipo"),
                     habitat: reader.GetString("habitat"),
                     activo: reader.GetString("activo"),
                     fuerza: reader.GetInt32("fuerza"),
                     agilidad: reader.GetInt32("agilidad"),
                     resistencia: reader.GetInt32("resistencia"),
                     velocidad: reader.GetInt32("velocidad"),
                     inteligencia: reader.GetInt32("inteligencia"),
                     carisma: reader.GetInt32("carisma"),
                     defensa: reader.GetInt32("defensa"),
                     experiencia: reader.GetInt32("experiencia"),
                     descripcion: reader.GetString("descripcion")
                     );
                    vikinga.Add(dragones);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error:" + ex.Message);

            }
            return vikinga;

        }



        public DataTable LeerCatalogo()
        {
            DataTable dragonescatalogo = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM dragonario";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dragonescatalogo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el catálogo: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return dragonescatalogo;
        }




    }
}