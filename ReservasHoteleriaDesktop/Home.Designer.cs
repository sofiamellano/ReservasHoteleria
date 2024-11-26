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
            MenuServicios = new FontAwesome.Sharp.IconMenuItem();
            MenuServiciosAdicionales = new FontAwesome.Sharp.IconMenuItem();
            iconMenuListados = new FontAwesome.Sharp.IconMenuItem();
            MenuSalir = new FontAwesome.Sharp.IconMenuItem();
            iconMenuEmpleados = new FontAwesome.Sharp.IconMenuItem();
            iconMenuHabitaciones = new FontAwesome.Sharp.IconMenuItem();
            iconMenuServicios = new FontAwesome.Sharp.IconMenuItem();
            iconMenuServiciosAdicionales = new FontAwesome.Sharp.IconMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(247, 247, 247);
            label1.Location = new Point(295, 8);
            label1.Name = "label1";
            label1.Size = new Size(406, 46);
            label1.TabIndex = 0;
            label1.Text = "Reservas Hoteleria";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(31, 60, 136);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 65);
            panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuReservas, MenuEmpleados, MenuHabitaciones, MenuServicios, MenuServiciosAdicionales, iconMenuListados, MenuSalir });
            menuStrip1.Location = new Point(0, 69);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(874, 46);
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
            // MenuServicios
            // 
            MenuServicios.BackColor = Color.FromArgb(31, 60, 136);
            MenuServicios.ForeColor = Color.White;
            MenuServicios.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            MenuServicios.IconColor = Color.White;
            MenuServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuServicios.IconSize = 38;
            MenuServicios.ImageScaling = ToolStripItemImageScaling.None;
            MenuServicios.Name = "MenuServicios";
            MenuServicios.Size = new Size(112, 42);
            MenuServicios.Text = "SERVICIOS";
            MenuServicios.Click += MenuServicios_Click;
            // 
            // MenuServiciosAdicionales
            // 
            MenuServiciosAdicionales.BackColor = Color.FromArgb(31, 60, 136);
            MenuServiciosAdicionales.ForeColor = Color.White;
            MenuServiciosAdicionales.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            MenuServiciosAdicionales.IconColor = Color.White;
            MenuServiciosAdicionales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuServiciosAdicionales.IconSize = 38;
            MenuServiciosAdicionales.ImageScaling = ToolStripItemImageScaling.None;
            MenuServiciosAdicionales.Name = "MenuServiciosAdicionales";
            MenuServiciosAdicionales.Size = new Size(189, 42);
            MenuServiciosAdicionales.Text = "SERVICIOS ADICIONALES";
            MenuServiciosAdicionales.Click += MenuServiciosAdicionales_Click;
            // 
            // iconMenuListados
            // 
            iconMenuListados.BackColor = Color.FromArgb(31, 60, 136);
            iconMenuListados.DropDownItems.AddRange(new ToolStripItem[] { iconMenuEmpleados, iconMenuHabitaciones, iconMenuServicios, iconMenuServiciosAdicionales });
            iconMenuListados.ForeColor = Color.White;
            iconMenuListados.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            iconMenuListados.IconColor = Color.White;
            iconMenuListados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuListados.IconSize = 38;
            iconMenuListados.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuListados.Name = "iconMenuListados";
            iconMenuListados.Size = new Size(108, 42);
            iconMenuListados.Text = "LISTADOS";
            // 
            // MenuSalir
            // 
            MenuSalir.BackColor = Color.FromArgb(31, 60, 136);
            MenuSalir.ForeColor = Color.White;
            MenuSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            MenuSalir.IconColor = Color.White;
            MenuSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuSalir.IconSize = 38;
            MenuSalir.ImageScaling = ToolStripItemImageScaling.None;
            MenuSalir.Name = "MenuSalir";
            MenuSalir.Size = new Size(87, 42);
            MenuSalir.Text = "SALIR";
            MenuSalir.Click += MenuSalir_Click;
            // 
            // iconMenuEmpleados
            // 
            iconMenuEmpleados.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuEmpleados.IconColor = Color.Black;
            iconMenuEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuEmpleados.Name = "iconMenuEmpleados";
            iconMenuEmpleados.Size = new Size(237, 22);
            iconMenuEmpleados.Text = "LISTA EMPLEADOS";
            iconMenuEmpleados.Click += iconMenuEmpleados_Click;
            // 
            // iconMenuHabitaciones
            // 
            iconMenuHabitaciones.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuHabitaciones.IconColor = Color.Black;
            iconMenuHabitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuHabitaciones.Name = "iconMenuHabitaciones";
            iconMenuHabitaciones.Size = new Size(237, 22);
            iconMenuHabitaciones.Text = "LISTA HABITACIONES";
            iconMenuHabitaciones.Click += iconMenuHabitaciones_Click;
            // 
            // iconMenuServicios
            // 
            iconMenuServicios.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuServicios.IconColor = Color.Black;
            iconMenuServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuServicios.Name = "iconMenuServicios";
            iconMenuServicios.Size = new Size(237, 22);
            iconMenuServicios.Text = "LISTA SERVICIOS";
            iconMenuServicios.Click += iconMenuServicios_Click;
            // 
            // iconMenuServiciosAdicionales
            // 
            iconMenuServiciosAdicionales.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuServiciosAdicionales.IconColor = Color.Black;
            iconMenuServiciosAdicionales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuServiciosAdicionales.Name = "iconMenuServiciosAdicionales";
            iconMenuServiciosAdicionales.Size = new Size(237, 22);
            iconMenuServiciosAdicionales.Text = "LISTA SERVICIOS ADICIONALES";
            iconMenuServiciosAdicionales.Click += iconMenuServiciosAdicionales_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 247);
            ClientSize = new Size(990, 487);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
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
        private FontAwesome.Sharp.IconMenuItem MenuServicios;
        private FontAwesome.Sharp.IconMenuItem MenuServiciosAdicionales;
        private FontAwesome.Sharp.IconMenuItem MenuSalir;
        private FontAwesome.Sharp.IconMenuItem iconMenuListados;
        private FontAwesome.Sharp.IconMenuItem iconMenuEmpleados;
        private FontAwesome.Sharp.IconMenuItem iconMenuHabitaciones;
        private FontAwesome.Sharp.IconMenuItem iconMenuServicios;
        private FontAwesome.Sharp.IconMenuItem iconMenuServiciosAdicionales;
    }
}