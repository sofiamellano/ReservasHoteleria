namespace ReservasHoteleriaDesktop.Views
{
    partial class HabitacionesViews
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
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtFiltro = new TextBox();
            label2 = new Label();
            dataGridHabitaciones = new DataGridView();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            AgregarEditar = new TabPage();
            checkDisponible = new CheckBox();
            numericPrecioPorNoche = new NumericUpDown();
            label3 = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtTipoHabitacion = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHabitaciones).BeginInit();
            AgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrecioPorNoche).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(31, 60, 136);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
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
            label1.Size = new Size(282, 46);
            label1.TabIndex = 0;
            label1.Text = "HABITACIONES";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(Lista);
            tabControl1.Controls.Add(AgregarEditar);
            tabControl1.Location = new Point(1, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(871, 444);
            tabControl1.TabIndex = 3;
            // 
            // Lista
            // 
            Lista.Controls.Add(btnBuscar);
            Lista.Controls.Add(txtFiltro);
            Lista.Controls.Add(label2);
            Lista.Controls.Add(dataGridHabitaciones);
            Lista.Controls.Add(btnEliminar);
            Lista.Controls.Add(btnEditar);
            Lista.Controls.Add(btnAgregar);
            Lista.Location = new Point(4, 24);
            Lista.Name = "Lista";
            Lista.Padding = new Padding(3);
            Lista.Size = new Size(863, 416);
            Lista.TabIndex = 0;
            Lista.Text = "LISTA";
            Lista.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(62, 146, 204);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 27;
            btnBuscar.Location = new Point(642, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 64);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.TextAlign = ContentAlignment.BottomCenter;
            btnBuscar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(115, 70);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(482, 23);
            txtFiltro.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(62, 146, 204);
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(115, 29);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 14;
            label2.Text = "Buscar Habitacion:";
            // 
            // dataGridHabitaciones
            // 
            dataGridHabitaciones.AllowUserToAddRows = false;
            dataGridHabitaciones.AllowUserToDeleteRows = false;
            dataGridHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHabitaciones.Location = new Point(115, 104);
            dataGridHabitaciones.Name = "dataGridHabitaciones";
            dataGridHabitaciones.ReadOnly = true;
            dataGridHabitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridHabitaciones.Size = new Size(746, 312);
            dataGridHabitaciones.TabIndex = 13;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(62, 146, 204);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 27;
            btnEliminar.Location = new Point(7, 342);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 64);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(62, 146, 204);
            btnEditar.ForeColor = Color.White;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnEditar.IconColor = Color.White;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 28;
            btnEditar.Location = new Point(7, 220);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 64);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "EDITAR";
            btnEditar.TextAlign = ContentAlignment.BottomCenter;
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(62, 146, 204);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnAgregar.IconColor = Color.White;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 28;
            btnAgregar.Location = new Point(7, 104);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 64);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.TextAlign = ContentAlignment.BottomCenter;
            btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AgregarEditar
            // 
            AgregarEditar.Controls.Add(checkDisponible);
            AgregarEditar.Controls.Add(numericPrecioPorNoche);
            AgregarEditar.Controls.Add(label3);
            AgregarEditar.Controls.Add(btnCancelar);
            AgregarEditar.Controls.Add(btnGuardar);
            AgregarEditar.Controls.Add(txtTipoHabitacion);
            AgregarEditar.Controls.Add(label8);
            AgregarEditar.Location = new Point(4, 24);
            AgregarEditar.Name = "AgregarEditar";
            AgregarEditar.Padding = new Padding(3);
            AgregarEditar.Size = new Size(863, 416);
            AgregarEditar.TabIndex = 1;
            AgregarEditar.Text = "AGREGAR / EDITAR";
            AgregarEditar.UseVisualStyleBackColor = true;
            // 
            // checkDisponible
            // 
            checkDisponible.AutoSize = true;
            checkDisponible.Location = new Point(374, 221);
            checkDisponible.Name = "checkDisponible";
            checkDisponible.Size = new Size(85, 19);
            checkDisponible.TabIndex = 28;
            checkDisponible.Text = "Disponible:";
            checkDisponible.TextImageRelation = TextImageRelation.ImageAboveText;
            checkDisponible.UseVisualStyleBackColor = true;
            // 
            // numericPrecioPorNoche
            // 
            numericPrecioPorNoche.Location = new Point(374, 136);
            numericPrecioPorNoche.Maximum = new decimal(new int[] { -159383552, 46653770, 5421, 0 });
            numericPrecioPorNoche.Name = "numericPrecioPorNoche";
            numericPrecioPorNoche.Size = new Size(231, 23);
            numericPrecioPorNoche.TabIndex = 27;
            numericPrecioPorNoche.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 138);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 26;
            label3.Text = "Precio Por Noche:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(62, 146, 204);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 27;
            btnCancelar.Location = new Point(494, 318);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 64);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(62, 146, 204);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 27;
            btnGuardar.Location = new Point(264, 318);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 64);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTipoHabitacion
            // 
            txtTipoHabitacion.Location = new Point(374, 66);
            txtTipoHabitacion.Name = "txtTipoHabitacion";
            txtTipoHabitacion.Size = new Size(231, 23);
            txtTipoHabitacion.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(258, 69);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 20;
            label8.Text = "Tipo de Habitacion:";
            // 
            // HabitacionesViews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 512);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "HabitacionesViews";
            Text = "HabitacionesViews";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            Lista.ResumeLayout(false);
            Lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHabitaciones).EndInit();
            AgregarEditar.ResumeLayout(false);
            AgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrecioPorNoche).EndInit();
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
        private DataGridView dataGridHabitaciones;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtFiltro;
        private Label label2;
        private TextBox txtTipoHabitacion;
        private Label label8;
        private NumericUpDown numericPrecioPorNoche;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private CheckBox checkDisponible;
    }
}