namespace pryPerezSP4
{
    public partial class Form1 : Form
    {
        private readonly string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
        private readonly string[] categorias = { "Comidas", "Bebidas sin alcohol", "Bebidas con alcohol", "Postres" };
        private float[,] ventas = new float[5, 4];
        private bool datosValidados;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            DeshabilitarConsultas();
        }

        // Configura los encabezados y las filas de la grilla, y aplica estilos visuales.
        private void ConfigurarGrilla()
        {
            dgvVentas.Columns.Clear();
            dgvVentas.Rows.Clear();

            for (int columna = 0; columna < categorias.Length; columna++)
            {
                dgvVentas.Columns.Add("columna" + columna, categorias[columna]);
            }

            for (int fila = 0; fila < mozos.Length; fila++)
            {
                int indice = dgvVentas.Rows.Add();
                dgvVentas.Rows[indice].HeaderCell.Value = mozos[fila];
            }

            // Estilos visuales de la grilla
            AplicarEstilosGrilla();
            dgvVentas.ClearSelection();
        }

        // Aplica estilos visuales a la grilla: colores, fuentes, alineamientos.
        private void AplicarEstilosGrilla()
        {
            // Estilo de encabezados de columna
            dgvVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvVentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Estilo de encabezados de fila
            dgvVentas.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvVentas.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVentas.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvVentas.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Estilo de celdas de datos
            dgvVentas.DefaultCellStyle.BackColor = Color.White;
            dgvVentas.DefaultCellStyle.ForeColor = Color.Black;
            dgvVentas.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvVentas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVentas.DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

            // Filas alternas con color suave
            dgvVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 250, 255);
            dgvVentas.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgvVentas.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvVentas.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVentas.AlternatingRowsDefaultCellStyle.Padding = new Padding(5, 0, 5, 0);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (!ValidarGrilla())
            {
                datosValidados = false;
                DeshabilitarConsultas();
                MessageBox.Show("Todos los importes deben ser valores numéricos. Revise la celda indicada.",
                    "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarArreglo();
            datosValidados = true;
            btnMozoDelDia.Enabled = true;
            btnTotales.Enabled = true;
            MessageBox.Show("Los datos se validaron correctamente.",
                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Comprueba las 20 celdas y enfoca la primera que no sea válida.
        private bool ValidarGrilla()
        {
            for (int fila = 0; fila < mozos.Length; fila++)
            {
                for (int columna = 0; columna < categorias.Length; columna++)
                {
                    object? valorCelda = dgvVentas.Rows[fila].Cells[columna].Value;
                    string texto = valorCelda?.ToString()?.Trim() ?? string.Empty;

                    if (string.IsNullOrWhiteSpace(texto) || !float.TryParse(texto, out _))
                    {
                        dgvVentas.CurrentCell = dgvVentas.Rows[fila].Cells[columna];
                        dgvVentas.Focus();
                        return false;
                    }
                }
            }

            return true;
        }

        // Copia los importes de la grilla al arreglo bidimensional.
        private void CargarArreglo()
        {
            for (int fila = 0; fila < mozos.Length; fila++)
            {
                for (int columna = 0; columna < categorias.Length; columna++)
                {
                    float.TryParse(dgvVentas.Rows[fila].Cells[columna].Value?.ToString(), out ventas[fila, columna]);
                }
            }
        }

        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {
            if (!datosValidados)
            {
                return;
            }

            CalcularMozoDelDia(out string nombre, out float importe);
            txtNombreMozo.Text = nombre;
            txtImporteMozo.Text = importe.ToString("N2");
        }

        // Obtiene el mozo con mayor importe vendido.
        private void CalcularMozoDelDia(out string nombre, out float importe)
        {
            int indiceMayor = 0;
            float mayor = 0;

            for (int fila = 0; fila < mozos.Length; fila++)
            {
                float totalMozo = 0;
                for (int columna = 0; columna < categorias.Length; columna++)
                {
                    totalMozo += ventas[fila, columna];
                }

                if (fila == 0 || totalMozo > mayor)
                {
                    mayor = totalMozo;
                    indiceMayor = fila;
                }
            }

            nombre = mozos[indiceMayor];
            importe = mayor;
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            if (!datosValidados)
            {
                return;
            }

            CalcularTotales(out float totalGeneral, out float[] totalesCategorias);
            txtTotalGeneral.Text = totalGeneral.ToString("N2");
            txtTotalComidas.Text = totalesCategorias[0].ToString("N2");
            txtTotalBebidasSinAlcohol.Text = totalesCategorias[1].ToString("N2");
            txtTotalBebidasConAlcohol.Text = totalesCategorias[2].ToString("N2");
            txtTotalPostres.Text = totalesCategorias[3].ToString("N2");
        }

        // Calcula el total general y el total de cada categoría.
        private void CalcularTotales(out float totalGeneral, out float[] totalesCategorias)
        {
            totalGeneral = 0;
            totalesCategorias = new float[categorias.Length];

            for (int fila = 0; fila < mozos.Length; fila++)
            {
                for (int columna = 0; columna < categorias.Length; columna++)
                {
                    totalGeneral += ventas[fila, columna];
                    totalesCategorias[columna] += ventas[fila, columna];
                }
            }
        }

        private void dgvVentas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                datosValidados = false;
                DeshabilitarConsultas();
            }
        }

        private void DeshabilitarConsultas()
        {
            btnMozoDelDia.Enabled = false;
            btnTotales.Enabled = false;
            txtNombreMozo.Clear();
            txtImporteMozo.Clear();
            txtTotalGeneral.Clear();
            txtTotalComidas.Clear();
            txtTotalBebidasSinAlcohol.Clear();
            txtTotalBebidasConAlcohol.Clear();
            txtTotalPostres.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
