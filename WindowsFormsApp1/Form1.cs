using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string nacimiento = txtNacimiento.Text;

            string query = "INSERT INTO dbo.alumnos (idAlumno, nombre, nacimiento) VALUES ("+id+", '"+nombre+"', '"+nacimiento+"')";

            try
            {
                SqlConnection conexion = new SqlConnection("server=KHALLED; database=colegio; integrated security = true");
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                int result = comando.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("No pudo guardarse el registro");
                } else
                {
                    MessageBox.Show("El registro se guardo exitosamente.");
                }
                conexion.Close();
                txtId.Text = "";
                txtNombre.Text = "";
                txtNacimiento.Text = "";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string nacimiento = txtNacimiento.Text;

            string query = "UPDATE dbo.alumnos SET nombre='" + nombre + "', nacimiento='" + nacimiento + "' WHERE idAlumno = " + id + ";";

            try
            {
                SqlConnection conexion = new SqlConnection("server=KHALLED; database=colegio; integrated security = true");
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                int result = comando.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("No pudo actualizarse el registro");
                }
                else
                {
                    MessageBox.Show("El registro se actualizo exitosamente.");
                }
                conexion.Close();
                txtId.Text = "";
                txtNombre.Text = "";
                txtNacimiento.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string nacimiento = txtNacimiento.Text;

            string query = "DELETE FROM dbo.alumnos WHERE idAlumno = " + id + ";";

            try
            {
                SqlConnection conexion = new SqlConnection("server=KHALLED; database=colegio; integrated security = true");
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                int result = comando.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("No pudo eliminar el registro");
                }
                else
                {
                    MessageBox.Show("El registro fue eliminado correctamente.");
                }
                conexion.Close();
                txtId.Text = "";
                txtNombre.Text = "";
                txtNacimiento.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
