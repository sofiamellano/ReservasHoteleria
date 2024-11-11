namespace ReservasHoteleriaDesktop.Views
{
    partial class ReservasViews
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
            tabControl = new TabControl();
            tabPageLista = new TabPage();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtFIltro = new TextBox();
            label2 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            dataGridReservas = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            textBox1 = new TextBox();
            txtUsuario = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            panel1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReservas).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 60, 136);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(247, 247, 247);
            label1.Location = new Point(299, 8);
            label1.Name = "label1";
            label1.Size = new Size(197, 46);
            label1.TabIndex = 0;
            label1.Text = "Reservas";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageLista);
            tabControl.Controls.Add(tabPageAgregarEditar);
            tabControl.Location = new Point(0, 69);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(918, 436);
            tabControl.TabIndex = 1;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(txtFIltro);
            tabPageLista.Controls.Add(label2);
            tabPageLista.Controls.Add(iconButton2);
            tabPageLista.Controls.Add(btnEditar);
            tabPageLista.Controls.Add(btnAgregar);
            tabPageLista.Controls.Add(dataGridReservas);
            tabPageLista.Location = new Point(4, 24);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(910, 408);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "LISTA";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(62, 146, 204);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 27;
            btnBuscar.Location = new Point(668, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 64);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.TextAlign = ContentAlignment.BottomCenter;
            btnBuscar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtFIltro
            // 
            txtFIltro.Location = new Point(158, 49);
            txtFIltro.Name = "txtFIltro";
            txtFIltro.Size = new Size(482, 23);
            txtFIltro.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(62, 146, 204);
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(158, 14);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 9;
            label2.Text = "Buscar Reserva:";
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(62, 146, 204);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 27;
            iconButton2.Location = new Point(29, 336);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(90, 64);
            iconButton2.TabIndex = 8;
            iconButton2.Text = "ELIMINAR";
            iconButton2.TextAlign = ContentAlignment.BottomCenter;
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(62, 146, 204);
            btnEditar.ForeColor = Color.White;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnEditar.IconColor = Color.White;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 28;
            btnEditar.Location = new Point(29, 214);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 64);
            btnEditar.TabIndex = 7;
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
            btnAgregar.Location = new Point(29, 88);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 64);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.TextAlign = ContentAlignment.BottomCenter;
            btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridReservas
            // 
            dataGridReservas.AllowUserToAddRows = false;
            dataGridReservas.AllowUserToDeleteRows = false;
            dataGridReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReservas.Location = new Point(158, 88);
            dataGridReservas.Name = "dataGridReservas";
            dataGridReservas.ReadOnly = true;
            dataGridReservas.Size = new Size(746, 312);
            dataGridReservas.TabIndex = 5;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(textBox1);
            tabPageAgregarEditar.Controls.Add(txtUsuario);
            tabPageAgregarEditar.Controls.Add(label9);
            tabPageAgregarEditar.Controls.Add(label8);
            tabPageAgregarEditar.Controls.Add(label7);
            tabPageAgregarEditar.Controls.Add(label6);
            tabPageAgregarEditar.Controls.Add(label5);
            tabPageAgregarEditar.Controls.Add(label4);
            tabPageAgregarEditar.Controls.Add(iconButton3);
            tabPageAgregarEditar.Controls.Add(iconButton1);
            tabPageAgregarEditar.Controls.Add(label3);
            tabPageAgregarEditar.Location = new Point(4, 24);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(910, 408);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(408, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 23);
            textBox1.TabIndex = 18;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(408, 17);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(231, 23);
            txtUsuario.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(339, 252);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 16;
            label9.Text = "Pago:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(276, 210);
            label8.Name = "label8";
            label8.Size = new Size(104, 15);
            label8.TabIndex = 15;
            label8.Text = "Estado de Reserva:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(307, 169);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 14;
            label7.Text = "Check OUT:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(318, 130);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 13;
            label6.Text = "Check IN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 89);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 12;
            label5.Text = "Fecha de Reserva:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 53);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 11;
            label4.Text = "Habitacion:";
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(62, 146, 204);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 27;
            iconButton3.Location = new Point(243, 327);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(90, 64);
            iconButton3.TabIndex = 10;
            iconButton3.Text = "ELIMINAR";
            iconButton3.TextAlign = ContentAlignment.BottomCenter;
            iconButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(62, 146, 204);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 27;
            iconButton1.Location = new Point(540, 348);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(90, 64);
            iconButton1.TabIndex = 9;
            iconButton1.Text = "ELIMINAR";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 20);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuario:";
            // 
            // ReservasViews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 247);
            ClientSize = new Size(920, 505);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Name = "ReservasViews";
            Text = "ReservasViews";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReservas).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl;
        private TabPage tabPageAgregarEditar;
        private TabPage tabPageLista;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView dataGridReservas;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtFIltro;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label3;
        private TextBox textBox1;
        private TextBox txtUsuario;
    }
}