namespace pryPerezSP4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private DataGridView dgvVentas;
        private Button btnValidar;
        private GroupBox grpMozoDelDia;
        private Button btnMozoDelDia;
        private Label lblNombreMozo;
        private TextBox txtNombreMozo;
        private Label lblImporteMozo;
        private TextBox txtImporteMozo;
        private GroupBox grpTotales;
        private Button btnTotales;
        private Label lblTotalGeneral;
        private TextBox txtTotalGeneral;
        private Label lblTotalComidas;
        private TextBox txtTotalComidas;
        private Label lblTotalBebidasSinAlcohol;
        private TextBox txtTotalBebidasSinAlcohol;
        private Label lblTotalBebidasConAlcohol;
        private TextBox txtTotalBebidasConAlcohol;
        private Label lblTotalPostres;
        private TextBox txtTotalPostres;
        private Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            dgvVentas = new DataGridView();
            btnValidar = new Button();
            grpMozoDelDia = new GroupBox();
            btnMozoDelDia = new Button();
            lblNombreMozo = new Label();
            txtNombreMozo = new TextBox();
            lblImporteMozo = new Label();
            txtImporteMozo = new TextBox();
            grpTotales = new GroupBox();
            btnTotales = new Button();
            lblTotalGeneral = new Label();
            txtTotalGeneral = new TextBox();
            lblTotalComidas = new Label();
            txtTotalComidas = new TextBox();
            lblTotalBebidasSinAlcohol = new Label();
            txtTotalBebidasSinAlcohol = new TextBox();
            lblTotalBebidasConAlcohol = new Label();
            txtTotalBebidasConAlcohol = new TextBox();
            lblTotalPostres = new Label();
            txtTotalPostres = new TextBox();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            pnlEncabezado.SuspendLayout();
            grpMozoDelDia.SuspendLayout();
            grpTotales.SuspendLayout();
            SuspendLayout();

            // Panel de encabezado
            pnlEncabezado.BackColor = Color.FromArgb(44, 62, 80);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1000, 60);
            pnlEncabezado.TabIndex = 0;
            pnlEncabezado.Controls.Add(lblTitulo);

            lblTitulo.AutoSize = false;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Text = "Bar La Milanga - Ventas diarias";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            lblTitulo.Padding = new Padding(20, 0, 0, 0);
            lblTitulo.TabIndex = 0;

            // dgvVentas
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.BorderStyle = BorderStyle.Fixed3D;
            dgvVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.GridColor = Color.LightGray;
            dgvVentas.Location = new Point(15, 75);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 120;
            dgvVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvVentas.Size = new Size(970, 220);
            dgvVentas.TabIndex = 1;
            dgvVentas.CellValueChanged += dgvVentas_CellValueChanged;

            // btnValidar
            btnValidar.BackColor = Color.FromArgb(230, 126, 34);
            btnValidar.FlatAppearance.BorderSize = 0;
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnValidar.ForeColor = Color.White;
            btnValidar.Location = new Point(15, 310);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(150, 40);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar Datos";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Cursor = Cursors.Hand;
            btnValidar.Click += btnValidar_Click;

            // grpMozoDelDia
            grpMozoDelDia.Controls.Add(btnMozoDelDia);
            grpMozoDelDia.Controls.Add(lblNombreMozo);
            grpMozoDelDia.Controls.Add(txtNombreMozo);
            grpMozoDelDia.Controls.Add(lblImporteMozo);
            grpMozoDelDia.Controls.Add(txtImporteMozo);
            grpMozoDelDia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpMozoDelDia.Location = new Point(15, 365);
            grpMozoDelDia.Name = "grpMozoDelDia";
            grpMozoDelDia.Size = new Size(450, 130);
            grpMozoDelDia.TabIndex = 3;
            grpMozoDelDia.TabStop = false;
            grpMozoDelDia.Text = "Mozo del día";

            // btnMozoDelDia
            btnMozoDelDia.BackColor = Color.FromArgb(52, 152, 219);
            btnMozoDelDia.FlatAppearance.BorderSize = 0;
            btnMozoDelDia.FlatStyle = FlatStyle.Flat;
            btnMozoDelDia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMozoDelDia.ForeColor = Color.White;
            btnMozoDelDia.Location = new Point(15, 45);
            btnMozoDelDia.Name = "btnMozoDelDia";
            btnMozoDelDia.Size = new Size(140, 35);
            btnMozoDelDia.TabIndex = 4;
            btnMozoDelDia.Text = "Mozo del día";
            btnMozoDelDia.UseVisualStyleBackColor = false;
            btnMozoDelDia.Cursor = Cursors.Hand;
            btnMozoDelDia.Click += btnMozoDelDia_Click;

            // lblNombreMozo
            lblNombreMozo.AutoSize = true;
            lblNombreMozo.Font = new Font("Segoe UI", 9F);
            lblNombreMozo.Location = new Point(165, 48);
            lblNombreMozo.Name = "lblNombreMozo";
            lblNombreMozo.Size = new Size(60, 15);
            lblNombreMozo.TabIndex = 5;
            lblNombreMozo.Text = "Nombre:";

            // txtNombreMozo
            txtNombreMozo.BackColor = Color.FromArgb(240, 248, 255);
            txtNombreMozo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNombreMozo.Location = new Point(235, 45);
            txtNombreMozo.Name = "txtNombreMozo";
            txtNombreMozo.ReadOnly = true;
            txtNombreMozo.Size = new Size(195, 23);
            txtNombreMozo.TabIndex = 6;
            txtNombreMozo.TextAlign = HorizontalAlignment.Center;

            // lblImporteMozo
            lblImporteMozo.AutoSize = true;
            lblImporteMozo.Font = new Font("Segoe UI", 9F);
            lblImporteMozo.Location = new Point(165, 85);
            lblImporteMozo.Name = "lblImporteMozo";
            lblImporteMozo.Size = new Size(52, 15);
            lblImporteMozo.TabIndex = 7;
            lblImporteMozo.Text = "Importe:";

            // txtImporteMozo
            txtImporteMozo.BackColor = Color.FromArgb(240, 248, 255);
            txtImporteMozo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtImporteMozo.Location = new Point(235, 82);
            txtImporteMozo.Name = "txtImporteMozo";
            txtImporteMozo.ReadOnly = true;
            txtImporteMozo.Size = new Size(195, 23);
            txtImporteMozo.TabIndex = 8;
            txtImporteMozo.TextAlign = HorizontalAlignment.Right;

            // grpTotales
            grpTotales.Controls.Add(btnTotales);
            grpTotales.Controls.Add(lblTotalGeneral);
            grpTotales.Controls.Add(txtTotalGeneral);
            grpTotales.Controls.Add(lblTotalComidas);
            grpTotales.Controls.Add(txtTotalComidas);
            grpTotales.Controls.Add(lblTotalBebidasSinAlcohol);
            grpTotales.Controls.Add(txtTotalBebidasSinAlcohol);
            grpTotales.Controls.Add(lblTotalBebidasConAlcohol);
            grpTotales.Controls.Add(txtTotalBebidasConAlcohol);
            grpTotales.Controls.Add(lblTotalPostres);
            grpTotales.Controls.Add(txtTotalPostres);
            grpTotales.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpTotales.Location = new Point(480, 365);
            grpTotales.Name = "grpTotales";
            grpTotales.Size = new Size(505, 130);
            grpTotales.TabIndex = 9;
            grpTotales.TabStop = false;
            grpTotales.Text = "Totales";

            // btnTotales
            btnTotales.BackColor = Color.FromArgb(52, 152, 219);
            btnTotales.FlatAppearance.BorderSize = 0;
            btnTotales.FlatStyle = FlatStyle.Flat;
            btnTotales.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTotales.ForeColor = Color.White;
            btnTotales.Location = new Point(15, 45);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(100, 35);
            btnTotales.TabIndex = 10;
            btnTotales.Text = "Calcular";
            btnTotales.UseVisualStyleBackColor = false;
            btnTotales.Cursor = Cursors.Hand;
            btnTotales.Click += btnTotales_Click;

            // lblTotalGeneral
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.Font = new Font("Segoe UI", 8F);
            lblTotalGeneral.Location = new Point(130, 53);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(75, 13);
            lblTotalGeneral.TabIndex = 11;
            lblTotalGeneral.Text = "Total general:";

            // txtTotalGeneral
            txtTotalGeneral.BackColor = Color.FromArgb(240, 248, 255);
            txtTotalGeneral.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            txtTotalGeneral.Location = new Point(210, 50);
            txtTotalGeneral.Name = "txtTotalGeneral";
            txtTotalGeneral.ReadOnly = true;
            txtTotalGeneral.Size = new Size(80, 20);
            txtTotalGeneral.TabIndex = 12;
            txtTotalGeneral.TextAlign = HorizontalAlignment.Right;

            // lblTotalComidas
            lblTotalComidas.AutoSize = true;
            lblTotalComidas.Font = new Font("Segoe UI", 8F);
            lblTotalComidas.Location = new Point(305, 53);
            lblTotalComidas.Name = "lblTotalComidas";
            lblTotalComidas.Size = new Size(71, 13);
            lblTotalComidas.TabIndex = 13;
            lblTotalComidas.Text = "Comidas:";

            // txtTotalComidas
            txtTotalComidas.BackColor = Color.FromArgb(240, 248, 255);
            txtTotalComidas.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            txtTotalComidas.Location = new Point(383, 50);
            txtTotalComidas.Name = "txtTotalComidas";
            txtTotalComidas.ReadOnly = true;
            txtTotalComidas.Size = new Size(80, 20);
            txtTotalComidas.TabIndex = 14;
            txtTotalComidas.TextAlign = HorizontalAlignment.Right;

            // lblTotalBebidasSinAlcohol
            lblTotalBebidasSinAlcohol.AutoSize = true;
            lblTotalBebidasSinAlcohol.Font = new Font("Segoe UI", 8F);
            lblTotalBebidasSinAlcohol.Location = new Point(130, 80);
            lblTotalBebidasSinAlcohol.Name = "lblTotalBebidasSinAlcohol";
            lblTotalBebidasSinAlcohol.Size = new Size(90, 13);
            lblTotalBebidasSinAlcohol.TabIndex = 15;
            lblTotalBebidasSinAlcohol.Text = "Bebidas s/alcohol:";

            // txtTotalBebidasSinAlcohol
            txtTotalBebidasSinAlcohol.BackColor = Color.FromArgb(240, 248, 255);
            txtTotalBebidasSinAlcohol.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            txtTotalBebidasSinAlcohol.Location = new Point(225, 77);
            txtTotalBebidasSinAlcohol.Name = "txtTotalBebidasSinAlcohol";
            txtTotalBebidasSinAlcohol.ReadOnly = true;
            txtTotalBebidasSinAlcohol.Size = new Size(65, 20);
            txtTotalBebidasSinAlcohol.TabIndex = 16;
            txtTotalBebidasSinAlcohol.TextAlign = HorizontalAlignment.Right;

            // lblTotalBebidasConAlcohol
            lblTotalBebidasConAlcohol.AutoSize = true;
            lblTotalBebidasConAlcohol.Font = new Font("Segoe UI", 8F);
            lblTotalBebidasConAlcohol.Location = new Point(305, 80);
            lblTotalBebidasConAlcohol.Name = "lblTotalBebidasConAlcohol";
            lblTotalBebidasConAlcohol.Size = new Size(88, 13);
            lblTotalBebidasConAlcohol.TabIndex = 17;
            lblTotalBebidasConAlcohol.Text = "Bebidas c/alcohol:";

            // txtTotalBebidasConAlcohol
            txtTotalBebidasConAlcohol.BackColor = Color.FromArgb(240, 248, 255);
            txtTotalBebidasConAlcohol.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            txtTotalBebidasConAlcohol.Location = new Point(399, 77);
            txtTotalBebidasConAlcohol.Name = "txtTotalBebidasConAlcohol";
            txtTotalBebidasConAlcohol.ReadOnly = true;
            txtTotalBebidasConAlcohol.Size = new Size(65, 20);
            txtTotalBebidasConAlcohol.TabIndex = 18;
            txtTotalBebidasConAlcohol.TextAlign = HorizontalAlignment.Right;

            // lblTotalPostres
            lblTotalPostres.AutoSize = true;
            lblTotalPostres.Font = new Font("Segoe UI", 8F);
            lblTotalPostres.Location = new Point(15, 80);
            lblTotalPostres.Name = "lblTotalPostres";
            lblTotalPostres.Size = new Size(52, 13);
            lblTotalPostres.TabIndex = 19;
            lblTotalPostres.Text = "Postres:";

            // txtTotalPostres
            txtTotalPostres.BackColor = Color.FromArgb(240, 248, 255);
            txtTotalPostres.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            txtTotalPostres.Location = new Point(75, 77);
            txtTotalPostres.Name = "txtTotalPostres";
            txtTotalPostres.ReadOnly = true;
            txtTotalPostres.Size = new Size(65, 20);
            txtTotalPostres.TabIndex = 20;
            txtTotalPostres.TextAlign = HorizontalAlignment.Right;

            // btnCerrar
            btnCerrar.BackColor = Color.FromArgb(192, 57, 43);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(850, 510);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(135, 40);
            btnCerrar.TabIndex = 21;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Click += btnCerrar_Click;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1000, 570);
            Controls.Add(btnCerrar);
            Controls.Add(grpTotales);
            Controls.Add(grpMozoDelDia);
            Controls.Add(btnValidar);
            Controls.Add(dgvVentas);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bar La Milanga - Sistema de ventas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            grpMozoDelDia.ResumeLayout(false);
            grpMozoDelDia.PerformLayout();
            grpTotales.ResumeLayout(false);
            grpTotales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
