using Microsoft.Data.SqlClient;
using Npgsql;
using System.Drawing.Drawing2D;
namespace Formulario_Clientes;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    void InsertarCliente(int codigo, string nombre, string rfc, string curp)
    {
        using (NpgsqlConnection con = Conexion.ObtenerConexion())
        {
            string query = "INSERT INTO clientes (codigo, nombre, rfc, curp) VALUES (@Codigo, @Nombre, @Rfc, @Curp)";

            NpgsqlCommand FL = new NpgsqlCommand(query, con);

            FL.Parameters.AddWithValue("@Codigo", codigo);
            FL.Parameters.AddWithValue("@Nombre", nombre);
            FL.Parameters.AddWithValue("@Rfc", rfc);
            FL.Parameters.AddWithValue("@Curp", curp);

            FL.ExecuteNonQuery();
        }
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {
        LinearGradientBrush degradado = new LinearGradientBrush(panel2.ClientRectangle, Color.White, Color.LightCyan, LinearGradientMode.Horizontal);
        e.Graphics.FillRectangle(degradado, panel2.ClientRectangle);
    }
    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void panel4_Paint(object sender, PaintEventArgs e)
    {
    }
    private void label11_Click(object sender, EventArgs e)
    {
    }

    private void textBox21_TextChanged(object sender, EventArgs e)
    {
    }

    private void label27_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox6_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
        try
        {
            InsertarCliente(
                int.Parse(txtCodigo.Text),
                txtNombre.Text,
                txtRFC.Text,
                txtCurp.Text
            );

            MessageBox.Show("Cliente guardado correctamente");
        }
        catch (Exception)
        {
            MessageBox.Show("Error al guardar cliente");
        }
    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {
        txtCodigo.Clear();
        txtNombre.Clear();
        txtCurp.Clear();
        txtRFC.Clear();
    }

    private void pictureBox7_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Anota su codigo, nombre, RFC y CURP unicamente, gracias");
    }

    private void pictureBox9_Click(object sender, EventArgs e)
    {
        FormTablas form = new FormTablas();
        form.ShowDialog();
    }

    private void pictureBox8_Click(object sender, EventArgs e) 
    {
        try
        {
            using (NpgsqlConnection con = Conexion.ObtenerConexion())
            {
                MessageBox.Show("Conexión a PostgreSQL exitosa!!!");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error de conexión: " + ex.Message);
        }
    }
}