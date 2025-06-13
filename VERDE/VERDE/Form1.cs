using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace VERDE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void Cargar_Datos()
        {
            try
            {
                string conexion = "Data Source=LAB-INF-10\\SQLEXPRESS;Initial Catalog=carla delgado;Integrated Security=True;";
                SqlConnection Connection = new SqlConnection(conexion);
                Connection.Open();
                string query = "select * from carla_delgado";
                SqlCommand command = new SqlCommand(query, Connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "carla_delgado");
                dataGridView1.DataSource = ds.Tables["carla_delgado"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
