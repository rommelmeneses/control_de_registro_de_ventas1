using MySql.Data.MySqlClient;

namespace control_de_registro_de_ventas
{
    public partial class Form1 : Form

    {
        MySqlConnection conexion;
        double precio = 0;
        public Form1()
        {
            InitializeComponent();
            string cadenaConexion = "server=127.0.0.1;user=root;database=control_ventas;password=;";
            conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Today.Date.ToString("d");
            lblprecio.Text =(0).ToString("c");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = cboproductos.Text;
            if (producto.Equals("coleccion escolar")) precio = 250;
            if (producto.Equals("coleccion preuniversitario")) precio = 150;
            if (producto.Equals("coleccion profecional")) precio = 350;

            lblprecio.Text = precio.ToString("c");
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //validando
            if (cboproductos.SelectedIndex == -1)
                MessageBox.Show("debe seleccionar un producto...!!!");
            else if (txtcantidad.Text == "")
                MessageBox.Show("debe ingresar una cantidad...!!!");
            else if (cbotipo.SelectedIndex == -1)
                MessageBox.Show("debe seleccionar un tipo...!!!");
            else
            {
                //capturando datos
                string producto = cboproductos.Text;
                int cantidad = Convert.ToInt32(txtcantidad.Text);
                string tipo = cbotipo.Text;

                //procesar calculos
                double subtotal = cantidad * precio;

                double descuento = 0, recargo = 0;
                if (tipo.Equals("contado"))
                    descuento = 0.05 * subtotal;
                else
                    recargo = 0.1 * subtotal;
                double preciofinal = subtotal - descuento + recargo;

                //imprecion de resultados
                string query = "INSERT INTO Ventas (Producto, Cantidad, Precio, `Tipo de Pago`, Descuento, Recargo, `Precio Final`) VALUES ('@producto', @cantidad, @precio, '@tipoPago', @descuento, @recargo, @PrecioFinal )";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@producto", producto);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@tipoPago", tipo);
                comando.Parameters.AddWithValue("@descuento", descuento);
                comando.Parameters.AddWithValue("@recargo", recargo);
                comando.Parameters.AddWithValue("@PrecioFinal", preciofinal);
                comando.ExecuteNonQuery();

                ListViewItem fila = new ListViewItem(producto);
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString());
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(descuento.ToString());
                fila.SubItems.Add(recargo.ToString());
                fila.SubItems.Add(preciofinal.ToString());

                lvventa.Items.Add(fila);
                btncancelar_Click(sender, e);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            cboproductos.Text = "(seleccione producto)";
            cbotipo.Text="(seleccione tipo)";
            txtcantidad.Clear();
            lblprecio.Text = (0).ToString("C");
            cboproductos.Focus();

        }
    }
}