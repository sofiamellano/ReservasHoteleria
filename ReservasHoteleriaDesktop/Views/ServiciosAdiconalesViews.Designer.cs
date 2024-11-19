namespace ReservasHoteleriaDesktop.Views
{
    partial class ServiciosAdiconalesViews
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
            dataGridServiciosAdicionales = new DataGridView();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            AgregarEditar = new TabPage();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtTipoServicio = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridServiciosAdicionales).BeginInit();
            AgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 60, 136);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 62);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(247, 247, 247);
            label1.Location = new Point(227, 8);
            label1.Name = "label1";
            label1.Size = new Size(442, 46);
            label1.TabIndex = 0;
            label1.Text = "SERVICIOS ADICIONALES";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Lista);
            tabControl1.Controls.Add(AgregarEditar);
            tabControl1.Location = new Point(2, 69);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(886, 452);
            tabControl1.TabIndex = 3;
            // 
            // Lista
            // 
            Lista.Controls.Add(btnBuscar);
            Lista.Controls.Add(txtFiltro);
            Lista.Controls.Add(label2);
            Lista.Controls.Add(dataGridServiciosAdicionales);
            Lista.Controls.Add(btnEliminar);
            Lista.Controls.Add(btnEditar);
            Lista.Controls.Add(btnAgregar);
            Lista.Location = new Point(4, 24);
            Lista.Name = "Lista";
            Lista.Padding = new Padding(3);
            Lista.Size = new Size(878, 424);
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
            btnBuscar.Location = new Point(655, 32);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 64);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.TextAlign = ContentAlignment.BottomCenter;
            btnBuscar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(128, 74);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(482, 23);
            txtFiltro.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(62, 146, 204);
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(128, 33);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 18;
            label2.Text = "Buscar Empleado:";
            // 
            // dataGridServiciosAdicionales
            // 
            dataGridServiciosAdicionales.AllowUserToAddRows = false;
            dataGridServiciosAdicionales.AllowUserToDeleteRows = false;
            dataGridServiciosAdicionales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridServiciosAdicionales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridServiciosAdicionales.Location = new Point(126, 109);
            dataGridServiciosAdicionales.Name = "dataGridServiciosAdicionales";
            dataGridServiciosAdicionales.ReadOnly = true;
            dataGridServiciosAdicionales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridServiciosAdicionales.Size = new Size(746, 312);
            dataGridServiciosAdicionales.TabIndex = 17;
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
            btnEliminar.Location = new Point(20, 349);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 64);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            btnEditar.Location = new Point(20, 231);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 64);
            btnEditar.TabIndex = 15;
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
            btnAgregar.Location = new Point(20, 109);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 64);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.TextAlign = ContentAlignment.BottomCenter;
            btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AgregarEditar
            // 
            AgregarEditar.Controls.Add(btnCancelar);
            AgregarEditar.Controls.Add(btnGuardar);
            AgregarEditar.Controls.Add(txtTipoServicio);
            AgregarEditar.Controls.Add(label3);
            AgregarEditar.Location = new Point(4, 24);
            AgregarEditar.Name = "AgregarEditar";
            AgregarEditar.Padding = new Padding(3);
            AgregarEditar.Size = new Size(878, 424);
            AgregarEditar.TabIndex = 1;
            AgregarEditar.Text = "AGREGAR / EDITAR";
            AgregarEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(62, 146, 204);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 27;
            btnCancelar.Location = new Point(546, 240);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 64);
            btnCancelar.TabIndex = 27;
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
            btnGuardar.Location = new Point(291, 240);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 64);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTipoServicio
            // 
            txtTipoServicio.Location = new Point(405, 121);
            txtTipoServicio.Name = "txtTipoServicio";
            txtTipoServicio.Size = new Size(231, 23);
            txtTipoServicio.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 124);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 24;
            label3.Text = "Tipo de Sercivio:";
            // 
            // ServiciosAdiconalesViews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 524);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ServiciosAdiconalesViews";
            Text = "ServiciosAdiconalesViews";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            Lista.ResumeLayout(false);
            Lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridServiciosAdicionales).EndInit();
            AgregarEditar.ResumeLayout(false);
            AgregarEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage Lista;
        private TabPage AgregarEditar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtFiltro;
        private Label label2;
        private DataGridView dataGridServiciosAdicionales;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtTipoServicio;
        private Label label3;
    }
}