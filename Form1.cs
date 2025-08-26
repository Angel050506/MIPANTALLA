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

namespace pacientes_pantalla
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "workstation id=generador_de_citas.mssql.somee.com;packet size=4096;user id=uts2025_SQLLogin_1;pwd=ueow787blr;data source=generador_de_citas.mssql.somee.com;persist security info=False;initial catalog=generador_de_citas;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGuardar_paciente_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Pacientes 
                         (ID, Nombre, Apellido, FechaNacimiento, Sexo, Email, Direccion, HistorialMedico)
                         VALUES 
                         (@ID, @Nombre, @Apellido, @FechaNacimiento, @Sexo, @Email, @Direccion, @HistorialMedico)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", int.Parse(txtIDPaciente.Text));
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                command.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value.Date);
                command.Parameters.AddWithValue("@Sexo", cmbSexo.SelectedItem?.ToString() ?? "");
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                command.Parameters.AddWithValue("@HistorialMedico", txtHistorial.Text);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Paciente guardado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }

        private void buttonActualizar_datos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDPaciente.Text))
            {
                MessageBox.Show("Por favor, ingresa el ID del paciente que deseas actualizar.");
                return;
            }

            string query = @"UPDATE Pacientes SET 
                         Nombre = @Nombre,
                         Apellido = @Apellido,
                         FechaNacimiento = @FechaNacimiento,
                         Sexo = @Sexo,
                         Email = @Email,
                         Direccion = @Direccion,
                         HistorialMedico = @HistorialMedico
                         WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", int.Parse(txtIDPaciente.Text));
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                command.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value.Date);
                command.Parameters.AddWithValue("@Sexo", cmbSexo.SelectedItem?.ToString() ?? "");
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                command.Parameters.AddWithValue("@HistorialMedico", txtHistorial.Text);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Datos del paciente actualizados correctamente.");
                    else
                        MessageBox.Show("No se encontró un paciente con ese ID.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }
            }
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                    textBox.Clear();
                else if (control is ComboBox comboBox)
                    comboBox.SelectedIndex = -1;
                else if (control is CheckBox checkBox)
                    checkBox.Checked = false;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Pacientes WHERE Nombre LIKE @Nombre OR ID = @ID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", string.IsNullOrWhiteSpace(txtIDPaciente.Text) ? (object)DBNull.Value : int.Parse(txtIDPaciente.Text));
                cmd.Parameters.AddWithValue("@Nombre", "%" + txtNombre.Text + "%");

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDPaciente.Text))
            {
                MessageBox.Show("Ingresa el ID del paciente que deseas eliminar.");
                return;
            }

            int id = int.Parse(txtIDPaciente.Text);
            string query = "DELETE FROM Pacientes WHERE ID = @ID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);

                try
                {
                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                        MessageBox.Show("Paciente eliminado correctamente.");
                    else
                        MessageBox.Show("No se encontró el paciente con ese ID.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}


