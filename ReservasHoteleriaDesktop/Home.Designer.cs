namespace ReservasHotelDesktop
{
    partial class Home
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
            label1 = new Label();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            MenuReservas = new FontAwesome.Sharp.IconMenuItem();
            MenuEmpleados = new FontAwesome.Sharp.IconMenuItem();
            MenuHabitaciones = new FontAwesome.Sharp.IconMenuItem();
            MenuPagos = new FontAwesome.Sharp.IconMenuItem();
            MenuServicios = new FontAwesome.Sharp.IconMenuItem();
            MenuServiciosAdicionales = new FontAwesome.Sharp.IconMenuItem();
            MenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            MenuSalir = new FontAwesome.Sharp.IconMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(247, 247, 247);
            label1.Location = new Point(202, 7);
            label1.Name = "label1";
            label1.Size = new Size(406, 46);
            label1.TabIndex = 0;
            label1.Text = "Reservas Hoteleria";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 60, 136);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 65);
            panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuReservas, MenuEmpleados, MenuHabitaciones, MenuPagos, MenuServicios, MenuServiciosAdicionales, MenuUsuarios, MenuSalir });
            menuStrip1.Location = new Point(0, 69);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(863, 46);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuReservas
            // 
            MenuReservas.BackColor = Color.FromArgb(31, 60, 136);
            MenuReservas.ForeColor = Color.White;
            MenuReservas.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            MenuReservas.IconColor = Color.White;
            MenuReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuReservas.IconSize = 38;
            MenuReservas.ImageScaling = ToolStripItemImageScaling.None;
            MenuReservas.Name = "MenuReservas";
            MenuReservas.Size = new Size(109, 42);
            MenuReservas.Text = "RESERVAS";
            MenuReservas.Click += MenuReservas_Click;
            // 
            // MenuEmpleados
            // 
            MenuEmpleados.BackColor = Color.FromArgb(31, 60, 136);
            MenuEmpleados.ForeColor = Color.White;
            MenuEmpleados.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            MenuEmpleados.IconColor = Color.White;
            MenuEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuEmpleados.IconSize = 38;
            MenuEmpleados.ImageScaling = ToolStripItemImageScaling.None;
            MenuEmpleados.Name = "MenuEmpleados";
            MenuEmpleados.Size = new Size(124, 42);
            MenuEmpleados.Text = "EMPLEADOS";
            MenuEmpleados.Click += MenuEmpleados_Click;
            // 
            // MenuHabitaciones
            // 
            MenuHabitaciones.BackColor = Color.FromArgb(31, 60, 136);
            MenuHabitaciones.ForeColor = Color.White;
            MenuHabitaciones.IconChar = FontAwesome.Sharp.IconChar.Bed;
            MenuHabitaciones.IconColor = Color.White;
            MenuHabitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuHabitaciones.IconSize = 38;
            MenuHabitaciones.ImageScaling = ToolStripItemImageScaling.None;
            MenuHabitaciones.Name = "MenuHabitaciones";
            MenuHabitaciones.Size = new Size(138, 42);
            MenuHabitaciones.Text = "HABITACIONES";
            MenuHabitaciones.Click += MenuHabitaciones_Click;
            // 
            // MenuPagos
            // 
            MenuPagos.IconChar = FontAwesome.Sharp.IconChar.None;
            MenuPagos.IconColor = Color.Black;
            MenuPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuPagos.Name = "MenuPagos";
            MenuPagos.Size = new Size(72, 42);
            MenuPagos.Text = "PAGOS";
            MenuPagos.Click += MenuPagos_Click;
            // 
            // MenuServicios
            // 
            MenuServicios.IconChar = FontAwesome.Sharp.IconChar.None;
            MenuServicios.IconColor = Color.Black;
            MenuServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuServicios.Name = "MenuServicios";
            MenuServicios.Size = new Size(90, 42);
            MenuServicios.Text = "SERVICIOS";
            MenuServicios.Click += MenuServicios_Click;
            // 
            // MenuServiciosAdicionales
            // 
            MenuServiciosAdicionales.IconChar = FontAwesome.Sharp.IconChar.None;
            MenuServiciosAdicionales.IconColor = Color.Black;
            MenuServiciosAdicionales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuServiciosAdicionales.Name = "MenuServiciosAdicionales";
            MenuServiciosAdicionales.Size = new Size(167, 42);
            MenuServiciosAdicionales.Text = "SERVICIOS ADICIONALES";
            MenuServiciosAdicionales.Click += MenuServiciosAdicionales_Click;
            // 
            // MenuUsuarios
            // 
            MenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            MenuUsuarios.IconColor = Color.Black;
            MenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuUsuarios.Name = "MenuUsuarios";
            MenuUsuarios.Size = new Size(90, 42);
            MenuUsuarios.Text = "USUARIOS";
            MenuUsuarios.Click += MenuUsuarios_Click;
            // 
            // MenuSalir
            // 
            MenuSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            MenuSalir.IconColor = Color.Black;
            MenuSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuSalir.Name = "MenuSalir";
            MenuSalir.Size = new Size(65, 42);
            MenuSalir.Text = "SALIR";
            MenuSalir.Click += MenuSalir_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 247);
            ClientSize = new Size(826, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem MenuReservas;
        private FontAwesome.Sharp.IconMenuItem MenuEmpleados;
        private FontAwesome.Sharp.IconMenuItem MenuHabitaciones;
        private FontAwesome.Sharp.IconMenuItem MenuPagos;
        private FontAwesome.Sharp.IconMenuItem MenuServicios;
        private FontAwesome.Sharp.IconMenuItem MenuServiciosAdicionales;
        private FontAwesome.Sharp.IconMenuItem MenuUsuarios;
        private FontAwesome.Sharp.IconMenuItem MenuSalir;
    }
}