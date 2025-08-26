using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacientes_pantalla
{
    internal class pacienteControlador
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string HistorialMedico { get; set; }

    }


    public class PacienteControlador
    {
        private readonly string _conexionString;

        public PacienteControlador(string conexionString)
        {
            _conexionString = conexionString;
        }

        public bool AgregarPaciente(Paciente paciente)
        {
            string query = @"INSERT INTO Pacientes 
                         (ID, Nombre, Apellido, FechaNacimiento, Sexo, Email, Direccion, HistorialMedico)
                         VALUES 
                         (@ID, @Nombre, @Apellido, @FechaNacimiento, @Sexo, @Email, @Direccion, @HistorialMedico)";

            try
            {
                using (SqlConnection conn = new SqlConnection(_conexionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    AsignarParametros(cmd, paciente);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el paciente: " + ex.Message);
                return false;
            }
        }

        public bool ActualizarPaciente(Paciente paciente)
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

            try
            {
                using (SqlConnection conn = new SqlConnection(_conexionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    AsignarParametros(cmd, paciente);
                    conn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el paciente: " + ex.Message);
                return false;
            }
        }

        public bool EliminarPaciente(int id)
        {
            string query = "DELETE FROM Pacientes WHERE ID = @ID";

            try
            {
                using (SqlConnection conn = new SqlConnection(_conexionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    conn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el paciente: " + ex.Message);
                return false;
            }
        }

        public List<Paciente> BuscarPacientes(string nombre, int? id)
        {
            string query = "SELECT * FROM Pacientes WHERE Nombre LIKE @Nombre OR ID = @ID";
            var lista = new List<Paciente>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_conexionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = "%" + nombre + "%";
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id.HasValue ? id.Value : (object)DBNull.Value;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        lista.Add(new Paciente
                        {
                            ID = Convert.ToInt32(row["ID"]),
                            Nombre = row["Nombre"].ToString(),
                            Apellido = row["Apellido"].ToString(),
                            FechaNacimiento = Convert.ToDateTime(row["FechaNacimiento"]),
                            Sexo = row["Sexo"].ToString(),
                            Email = row["Email"].ToString(),
                            Direccion = row["Direccion"].ToString(),
                            HistorialMedico = row["HistorialMedico"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar pacientes: " + ex.Message);
            }

            return lista;
        }

        private void AsignarParametros(SqlCommand cmd, Paciente paciente)
        {
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = paciente.ID;
            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = paciente.Nombre;
            cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar, 100).Value = paciente.Apellido;
            cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = paciente.FechaNacimiento;
            cmd.Parameters.Add("@Sexo", SqlDbType.NVarChar, 10).Value = paciente.Sexo;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = paciente.Email;
            cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar, 200).Value = paciente.Direccion;
            cmd.Parameters.Add("@HistorialMedico", SqlDbType.NVarChar, 500).Value = paciente.HistorialMedico;
        }
    }
    public class Paciente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string HistorialMedico { get; set; }
    }
}
