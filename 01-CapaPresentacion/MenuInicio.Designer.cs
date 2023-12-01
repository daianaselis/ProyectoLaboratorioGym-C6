namespace _01_CapaPresentacion
{
    partial class MenuInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicio));
            datagvmostrar = new DataGridView();
            menuStrip1 = new MenuStrip();
            mostrarDatosCLienteToolStripMenuItem = new ToolStripMenuItem();
            modificarDatosDelClienteToolStripMenuItem = new ToolStripMenuItem();
            borrarDatosDelClienteToolStripMenuItem = new ToolStripMenuItem();
            agregarUnaNuevaPersonaToolStripMenuItem = new ToolStripMenuItem();
            limpiarDGVToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)datagvmostrar).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // datagvmostrar
            // 
            datagvmostrar.BackgroundColor = SystemColors.ActiveCaption;
            datagvmostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagvmostrar.Location = new Point(207, 40);
            datagvmostrar.Name = "datagvmostrar";
            datagvmostrar.RowTemplate.Height = 25;
            datagvmostrar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagvmostrar.Size = new Size(637, 449);
            datagvmostrar.TabIndex = 3;
            datagvmostrar.MouseDoubleClick += datagvmostrar_MouseDoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mostrarDatosCLienteToolStripMenuItem, limpiarDGVToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1119, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // mostrarDatosCLienteToolStripMenuItem
            // 
            mostrarDatosCLienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modificarDatosDelClienteToolStripMenuItem, borrarDatosDelClienteToolStripMenuItem, agregarUnaNuevaPersonaToolStripMenuItem });
            mostrarDatosCLienteToolStripMenuItem.Name = "mostrarDatosCLienteToolStripMenuItem";
            mostrarDatosCLienteToolStripMenuItem.Size = new Size(136, 20);
            mostrarDatosCLienteToolStripMenuItem.Text = "Mostrar Datos CLiente";
            mostrarDatosCLienteToolStripMenuItem.Click += mostrarDatosCLienteToolStripMenuItem_Click;
            // 
            // modificarDatosDelClienteToolStripMenuItem
            // 
            modificarDatosDelClienteToolStripMenuItem.Name = "modificarDatosDelClienteToolStripMenuItem";
            modificarDatosDelClienteToolStripMenuItem.Size = new Size(219, 22);
            modificarDatosDelClienteToolStripMenuItem.Text = "Modificar Datos del cliente";
            modificarDatosDelClienteToolStripMenuItem.Click += modificarDatosDelClienteToolStripMenuItem_Click;
            // 
            // borrarDatosDelClienteToolStripMenuItem
            // 
            borrarDatosDelClienteToolStripMenuItem.Name = "borrarDatosDelClienteToolStripMenuItem";
            borrarDatosDelClienteToolStripMenuItem.Size = new Size(219, 22);
            borrarDatosDelClienteToolStripMenuItem.Text = "Borrar Datos del cliente";
            borrarDatosDelClienteToolStripMenuItem.Click += borrarDatosDelClienteToolStripMenuItem_Click;
            // 
            // agregarUnaNuevaPersonaToolStripMenuItem
            // 
            agregarUnaNuevaPersonaToolStripMenuItem.Name = "agregarUnaNuevaPersonaToolStripMenuItem";
            agregarUnaNuevaPersonaToolStripMenuItem.Size = new Size(219, 22);
            agregarUnaNuevaPersonaToolStripMenuItem.Text = "Agregar una nueva Persona";
            agregarUnaNuevaPersonaToolStripMenuItem.Click += agregarUnaNuevaPersonaToolStripMenuItem_Click;
            // 
            // limpiarDGVToolStripMenuItem
            // 
            limpiarDGVToolStripMenuItem.Name = "limpiarDGVToolStripMenuItem";
            limpiarDGVToolStripMenuItem.Size = new Size(85, 20);
            limpiarDGVToolStripMenuItem.Text = "Limpiar DGV";
            limpiarDGVToolStripMenuItem.Click += limpiarDGVToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 271);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // MenuInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1119, 629);
            Controls.Add(label1);
            Controls.Add(datagvmostrar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuInicio";
            Text = "GYMNASIO";
            Load += MenuInicio_Load;
            ((System.ComponentModel.ISupportInitialize)datagvmostrar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView datagvmostrar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mostrarDatosCLienteToolStripMenuItem;
        private ToolStripMenuItem limpiarDGVToolStripMenuItem;
        private ToolStripMenuItem modificarDatosDelClienteToolStripMenuItem;
        private ToolStripMenuItem borrarDatosDelClienteToolStripMenuItem;
        private ToolStripMenuItem agregarUnaNuevaPersonaToolStripMenuItem;
        private Label label1;
    }
}