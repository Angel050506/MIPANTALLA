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
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonGuardar_paciente_Click(object sender, EventArgs e)
        {
            string connectionString = "workstation id=generador_de_citas.mssql.somee.com;packet size=4096;user id=uts2025_SQLLogin_1;pwd=ueow787blr;data source=generador_de_citas.mssql.somee.com;persist security info=False;initial catalog=generador_de_citas;TrustServerCertificate=True ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Pacientes 
                         (ID, Nombre, Apellido, FechaNacimiento, Sexo, Email, Direccion, HistorialMedico)
                         VALUES 
                         (@ID, @Nombre, @Apellido, @FechaNacimiento, @Sexo, @Email, @Direccion, @HistorialMedico)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", int.Parse(txtIDPaciente.Text));
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                command.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value.Date);
                command.Parameters.AddWithValue("@Sexo", cmbSexo.SelectedItem.ToString());
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

            string connectionString = "workstation id=generador_de_citas.mssql.somee.com;packet size=4096;user id=uts2025_SQLLogin_1;pwd=ueow787blr;data source=generador_de_citas.mssql.somee.com;persist security info=False;initial catalog=generador_de_citas;TrustServerCertificate=True ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Pacientes SET 
                            Nombre = @Nombre,
                            Apellido = @Apellido,
                            FechaNacimiento = @FechaNacimiento,
                            Sexo = @Sexo,
                            Email = @Email,
                            Direccion = @Direccion,
                            HistorialMedico = @HistorialMedico
                           
                         WHERE ID = @ID";
                
                SqlCommand command = new SqlCommand(query, connection);
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
                    {
                        MessageBox.Show("Datos del paciente actualizados correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un paciente con ese ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }
            }

        }

        private void buttonCONSULTAR_Click(object sender, EventArgs e)
        {
            string connectionString = "workstation id=generador_de_citas.mssql.somee.com;packet size=4096;user id=uts2025_SQLLogin_1;pwd=ueow787blr;data source=generador_de_citas.mssql.somee.com;persist security info=False;initial catalog=generador_de_citas;TrustServerCertificate=True ";
            string idPaciente = txtIDPaciente.Text.Trim();

            if (string.IsNullOrEmpty(idPaciente))
            {
                MessageBox.Show("Por favor ingresa el ID del paciente.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT HistorialMedico FROM HistorialMedico WHERE IDPaciente = @IDPaciente";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdPaciente", idPaciente);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable historialTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(historialTable);
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar el historial: " + ex.Message);
                }
            }

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }

        }
    }
}
