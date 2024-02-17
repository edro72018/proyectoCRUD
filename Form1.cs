// Form1.cs
using System;
using System.Configuration;
using System.Windows.Forms;

namespace crudApi
{
    public partial class Form1 : Form
    {
        private readonly DatabaseManager databaseManager;

        public object ConnectionString { get; private set; }

        public Form1()
        {
            InitializeComponent();

            // Conexión a la base de datos
            //string connectionString = "Server=localhost;Database=CRUDAPI;User ID=root;Password=;Port=3306;";
            //databaseManager = new DatabaseManager(connectionString);
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void btnObtenerProductos_Click(object sender, EventArgs e)
        {
            try
            {
                var productos = databaseManager.GetProductos();
                dataGridView.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
        private void btnObtenerProductoPorId_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = Convert.ToInt32(txtProductId.Text);
                var producto = databaseManager.GetProductoById(productId);

                if (producto != null)
                {
                    MostrarProductoEnControles(producto);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoProducto = new Producto
                {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = Convert.ToDecimal(txtPrecio.Text),
                    Stock = Convert.ToInt32(txtStock.Text)
                };

                databaseManager.CrearProducto(nuevoProducto);

                MessageBox.Show("Producto creado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarConexion()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                lblEstadoConexion.Text = "Conectado";
                connection.Close();
            }
            catch (Exception ex)
            {
                lblEstadoConexion.Text = $"Error de conexión: {ex.Message}";
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes manejar eventos relacionados con las celdas del DataGridView si es necesario
        }

        /*private void MostrarProductoEnControles(Producto producto)
        {
            txtNombre.Text = producto.Nombre;
            txtDescripcion.Text = producto.Descripcion;
            txtPrecio.Text = producto.Precio.ToString();
            txtStock.Text = producto.Stock.ToString();
        }
        */
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                VerificarConexion();
            });
        }

        private void VerificarConexion()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                connection.Open();
                lblEstadoConexion.Text = "Conectado";
                connection.Close();
            }
            catch (Exception ex)
            {
                lblEstadoConexion.Text = $"Error de Conexión : {ex.Message}";
            }
        }
    }
}
