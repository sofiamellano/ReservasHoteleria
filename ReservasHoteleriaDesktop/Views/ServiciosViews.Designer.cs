namespace ReservasHoteleriaDesktop.Views
{
    partial class ServiciosViews
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            tabControl1 = new TabControl();
            Lista = new TabPage();
            AgregarEditar = new TabPage();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtFiltro = new TextBox();
            label2 = new Label();
            dataGridServicios = new DataGridView();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtNombre = new TextBox();
            label8 = new Label();
            numericPrecio = new NumericUpDown();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            Lista.SuspendLayout();
            AgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 60, 136);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 62);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(247, 247, 247);
            label1.Location = new Point(283, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 46);
            label1.TabIndex = 0;
            label1.Text = "SERVICIOS";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(Lista);
            tabControl1.Controls.Add(AgregarEditar);
            tabControl1.Location = new Point(1, 71);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(872, 441);
            tabControl1.TabIndex = 3;
            // 
            // Lista
            // 
            Lista.Controls.Add(btnBuscar);
            Lista.Controls.Add(txtFiltro);
            Lista.Controls.Add(label2);
            Lista.Controls.Add(dataGridServicios);
            Lista.Controls.Add(btnEliminar);
            Lista.Controls.Add(btnEditar);
            Lista.Controls.Add(btnAgregar);
            Lista.Location = new Point(4, 24);
            Lista.Name = "Lista";
            Lista.Padding = new Padding(3);
            Lista.Size = new Size(864, 413);
            Lista.TabIndex = 0;
            Lista.Text = "LISTA";
            Lista.UseVisualStyleBackColor = true;
            // 
            // AgregarEditar
            // 
            AgregarEditar.Controls.Add(numericPrecio);
            AgregarEditar.Controls.Add(label3);
            AgregarEditar.Controls.Add(txtNombre);
            AgregarEditar.Controls.Add(label8);
            AgregarEditar.Controls.Add(btnCancelar);
            AgregarEditar.Controls.Add(btnGuardar);
            AgregarEditar.Location = new Point(4, 24);
            AgregarEditar.Name = "AgregarEditar";
            AgregarEditar.Padding = new Padding(3);
            AgregarEditar.Size = new Size(864, 413);
            AgregarEditar.TabIndex = 1;
            AgregarEditar.Text = "AGREGAR / EDITAR";
            AgregarEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.FromArgb(62, 146, 204);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 27;
            btnEliminar.Location = new Point(7, 343);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 64);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Left;
            btnEditar.BackColor = Color.FromArgb(62, 146, 204);
            btnEditar.ForeColor = Color.White;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnEditar.IconColor = Color.White;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 28;
            btnEditar.Location = new Point(7, 225);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 64);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "EDITAR";
            btnEditar.TextAlign = ContentAlignment.BottomCenter;
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(62, 146, 204);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnAgregar.IconColor = Color.White;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 28;
            btnAgregar.Location = new Point(7, 103);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 64);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.TextAlign = ContentAlignment.BottomCenter;
            btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(62, 146, 204);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 27;
            btnBuscar.Location = new Point(641, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 64);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.TextAlign = ContentAlignment.BottomCenter;
            btnBuscar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(114, 66);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(482, 23);
            txtFiltro.TabIndex = 16;
            txtFiltro.TextChanged += this.txtFiltro_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(62, 146, 204);
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(114, 25);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 15;
            label2.Text = "Buscar Servicios:";
            label2.Click += this.label2_Click;
            // 
            // dataGridServicios
            // 
            dataGridServicios.AllowUserToAddRows = false;
            dataGridServicios.AllowUserToDeleteRows = false;
            dataGridServicios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridServicios.Location = new Point(112, 101);
            dataGridServicios.Name = "dataGridServicios";
            dataGridServicios.ReadOnly = true;
            dataGridServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridServicios.Size = new Size(746, 312);
            dataGridServicios.TabIndex = 14;
            dataGridServicios.CellContentClick += this.dataGridEmpleados_CellContentClick;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(62, 146, 204);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 27;
            btnCancelar.Location = new Point(509, 333);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 64);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(62, 146, 204);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 27;
            btnGuardar.Location = new Point(279, 333);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 64);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 184);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 28;
            label3.Text = "Precio:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(339, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(231, 23);
            txtNombre.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(279, 85);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 26;
            label8.Text = "Nombre:";
            // 
            // numericPrecio
            // 
            numericPrecio.Location = new Point(340, 182);
            numericPrecio.Maximum = new decimal(new int[] { -1486618624, 232830643, 0, 0 });
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new Size(230, 23);
            numericPrecio.TabIndex = 29;
            numericPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // ServiciosViews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 513);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ServiciosViews";
            Text = "ServiciosViews";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            Lista.ResumeLayout(false);
            Lista.PerformLayout();
            AgregarEditar.ResumeLayout(false);
            AgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage Lista;
        private TabPage AgregarEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtFiltro;
        private Label label2;
        private DataGridView dataGridServicios;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private NumericUpDown numericPrecio;
        private Label label3;
        private TextBox txtNombre;
        private Label label8;
    }
}