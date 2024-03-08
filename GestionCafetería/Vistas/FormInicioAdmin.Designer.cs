namespace GestionCafetería.Vistas
{
    partial class FormInicioAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.listaAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.listaProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.TicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BBDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.listaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnTPV = new System.Windows.Forms.Button();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTickets = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.basededatos = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 577);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(4, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 170);
            this.panel2.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.TicketsToolStripMenuItem,
            this.BBDDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(177, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradoresToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // administradoresToolStripMenuItem
            // 
            this.administradoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaAdmin,
            this.listaAdmin});
            this.administradoresToolStripMenuItem.Name = "administradoresToolStripMenuItem";
            this.administradoresToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.administradoresToolStripMenuItem.Text = "Administradores";
            // 
            // altaAdmin
            // 
            this.altaAdmin.Name = "altaAdmin";
            this.altaAdmin.Size = new System.Drawing.Size(112, 22);
            this.altaAdmin.Text = "Alta";
            this.altaAdmin.Click += new System.EventHandler(this.altaAdmin_Click);
            // 
            // listaAdmin
            // 
            this.listaAdmin.Name = "listaAdmin";
            this.listaAdmin.Size = new System.Drawing.Size(112, 22);
            this.listaAdmin.Text = "Listado";
            this.listaAdmin.Click += new System.EventHandler(this.listaAdmin_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaEmpleado,
            this.listadoEmpleado});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // altaEmpleado
            // 
            this.altaEmpleado.Name = "altaEmpleado";
            this.altaEmpleado.Size = new System.Drawing.Size(112, 22);
            this.altaEmpleado.Text = "Alta";
            this.altaEmpleado.Click += new System.EventHandler(this.altaEmpleado_Click);
            // 
            // listadoEmpleado
            // 
            this.listadoEmpleado.Name = "listadoEmpleado";
            this.listadoEmpleado.Size = new System.Drawing.Size(112, 22);
            this.listadoEmpleado.Text = "Listado";
            this.listadoEmpleado.Click += new System.EventHandler(this.listadoEmpleado_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaProducto,
            this.listaProducto});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // altaProducto
            // 
            this.altaProducto.Name = "altaProducto";
            this.altaProducto.Size = new System.Drawing.Size(112, 22);
            this.altaProducto.Text = "Alta";
            this.altaProducto.Click += new System.EventHandler(this.altaProducto_Click);
            // 
            // listaProducto
            // 
            this.listaProducto.Name = "listaProducto";
            this.listaProducto.Size = new System.Drawing.Size(112, 22);
            this.listaProducto.Text = "Listado";
            this.listaProducto.Click += new System.EventHandler(this.listaProducto_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaCliente,
            this.listaCliente});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // altaCliente
            // 
            this.altaCliente.Name = "altaCliente";
            this.altaCliente.Size = new System.Drawing.Size(112, 22);
            this.altaCliente.Text = "Alta";
            this.altaCliente.Click += new System.EventHandler(this.altaCliente_Click);
            // 
            // listaCliente
            // 
            this.listaCliente.Name = "listaCliente";
            this.listaCliente.Size = new System.Drawing.Size(112, 22);
            this.listaCliente.Text = "Listado";
            this.listaCliente.Click += new System.EventHandler(this.listaCliente_Click);
            // 
            // TicketsToolStripMenuItem
            // 
            this.TicketsToolStripMenuItem.Name = "TicketsToolStripMenuItem";
            this.TicketsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.TicketsToolStripMenuItem.Text = "Tickets";
            this.TicketsToolStripMenuItem.Click += new System.EventHandler(this.TicketsToolStripMenuItem_Click);
            // 
            // BBDDToolStripMenuItem
            // 
            this.BBDDToolStripMenuItem.Name = "BBDDToolStripMenuItem";
            this.BBDDToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.BBDDToolStripMenuItem.Text = "Base de datos";
            this.BBDDToolStripMenuItem.Click += new System.EventHandler(this.BBDDToolStripMenuItem_Click);
            // 
            // altaUsuario
            // 
            this.altaUsuario.Name = "altaUsuario";
            this.altaUsuario.Size = new System.Drawing.Size(32, 19);
            // 
            // listaUsuario
            // 
            this.listaUsuario.Name = "listaUsuario";
            this.listaUsuario.Size = new System.Drawing.Size(32, 19);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.btnLogin.Location = new System.Drawing.Point(535, 36);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(82, 33);
            this.btnLogin.TabIndex = 66;
            this.btnLogin.Text = "Ir a login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.btnSalir.Location = new System.Drawing.Point(634, 36);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 33);
            this.btnSalir.TabIndex = 65;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTPV
            // 
            this.btnTPV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.btnTPV.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTPV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTPV.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPV.ForeColor = System.Drawing.Color.White;
            this.btnTPV.Location = new System.Drawing.Point(20, 151);
            this.btnTPV.Name = "btnTPV";
            this.btnTPV.Size = new System.Drawing.Size(156, 38);
            this.btnTPV.TabIndex = 70;
            this.btnTPV.Text = "Ir a TPV";
            this.btnTPV.UseVisualStyleBackColor = false;
            this.btnTPV.Click += new System.EventHandler(this.btnTPV_Click);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.btnVerProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVerProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerProductos.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProductos.ForeColor = System.Drawing.Color.White;
            this.btnVerProductos.Location = new System.Drawing.Point(17, 150);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(172, 38);
            this.btnVerProductos.TabIndex = 69;
            this.btnVerProductos.Text = "Lista Productos";
            this.btnVerProductos.UseVisualStyleBackColor = false;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.btnTickets);
            this.panel4.Location = new System.Drawing.Point(245, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 203);
            this.panel4.TabIndex = 72;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(29, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 127);
            this.panel3.TabIndex = 77;
            // 
            // btnTickets
            // 
            this.btnTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.btnTickets.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTickets.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTickets.ForeColor = System.Drawing.Color.White;
            this.btnTickets.Location = new System.Drawing.Point(22, 150);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(156, 38);
            this.btnTickets.TabIndex = 76;
            this.btnTickets.Text = "Ver Tickets";
            this.btnTickets.UseVisualStyleBackColor = false;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.btnTPV);
            this.panel5.Location = new System.Drawing.Point(516, 341);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 203);
            this.panel5.TabIndex = 73;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(28, 8);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(142, 136);
            this.panel9.TabIndex = 75;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.panel6.Controls.Add(this.basededatos);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Location = new System.Drawing.Point(245, 93);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 203);
            this.panel6.TabIndex = 74;
            // 
            // basededatos
            // 
            this.basededatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.basededatos.Cursor = System.Windows.Forms.Cursors.Default;
            this.basededatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basededatos.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basededatos.ForeColor = System.Drawing.Color.White;
            this.basededatos.Location = new System.Drawing.Point(13, 151);
            this.basededatos.Name = "basededatos";
            this.basededatos.Size = new System.Drawing.Size(175, 38);
            this.basededatos.TabIndex = 78;
            this.basededatos.Text = "Base De Datos";
            this.basededatos.UseVisualStyleBackColor = false;
            this.basededatos.Click += new System.EventHandler(this.basededatos_Click);
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Location = new System.Drawing.Point(34, 15);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(131, 128);
            this.panel10.TabIndex = 75;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.btnVerProductos);
            this.panel7.Location = new System.Drawing.Point(516, 93);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 203);
            this.panel7.TabIndex = 74;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(29, 15);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(141, 129);
            this.panel8.TabIndex = 75;
            // 
            // FormInicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 577);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicioAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Administrador";
            this.Load += new System.EventHandler(this.FormInicioAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaUsuario;
        private System.Windows.Forms.ToolStripMenuItem listaUsuario;
        private System.Windows.Forms.ToolStripMenuItem altaProducto;
        private System.Windows.Forms.ToolStripMenuItem listaProducto;
        private System.Windows.Forms.ToolStripMenuItem altaCliente;
        private System.Windows.Forms.ToolStripMenuItem listaCliente;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnTPV;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ToolStripMenuItem administradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAdmin;
        private System.Windows.Forms.ToolStripMenuItem listaAdmin;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaEmpleado;
        private System.Windows.Forms.Button btnTickets;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button basededatos;
        private System.Windows.Forms.ToolStripMenuItem listadoEmpleado;
        private System.Windows.Forms.ToolStripMenuItem TicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BBDDToolStripMenuItem;
    }
}