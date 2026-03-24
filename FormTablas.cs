using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace Formulario_Clientes
{
    public partial class FormTablas : Form
    {
        public FormTablas()
        {
            InitializeComponent();
            CargarDatos();
            panel1.Dock = DockStyle.Fill;
            panel1.Padding = new Padding(10);
        }
        private void CargarDatos()
        {
            using (NpgsqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM CLIENTES";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, con);
                DataTable cliente = new DataTable();

                da.Fill(cliente);

                dgvDatos.DataSource = cliente;
            }
        }
        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormTablas_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
