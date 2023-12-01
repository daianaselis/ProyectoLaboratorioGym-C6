namespace _01_CapaPresentacion
{
    partial class DVGinsertarclientes
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
            lbl_Nombre = new Label();
            lbl_apellid = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dni_lbl = new Label();
            Membresia_lbl = new Label();
            btn_GRABARPEROSONA = new Button();
            txt_dni = new TextBox();
            lbl_Fechanac = new Label();
            dtp_fechanacimiento = new DateTimePicker();
            dtp_fechainicio = new DateTimePicker();
            dtp_fechavencimiento = new DateTimePicker();
            btn_agregar = new Button();
            textBox3 = new TextBox();
            lbl_fechainicio = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(67, 77);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(59, 15);
            lbl_Nombre.TabIndex = 0;
            lbl_Nombre.Text = "Nombres:";
            // 
            // lbl_apellid
            // 
            lbl_apellid.AutoSize = true;
            lbl_apellid.Location = new Point(67, 141);
            lbl_apellid.Name = "lbl_apellid";
            lbl_apellid.Size = new Size(59, 15);
            lbl_apellid.TabIndex = 1;
            lbl_apellid.Text = "Apellidos:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 23);
            textBox2.TabIndex = 3;
            // 
            // dni_lbl
            // 
            dni_lbl.AutoSize = true;
            dni_lbl.Location = new Point(88, 203);
            dni_lbl.Name = "dni_lbl";
            dni_lbl.Size = new Size(27, 15);
            dni_lbl.TabIndex = 4;
            dni_lbl.Text = "DNI";
            // 
            // Membresia_lbl
            // 
            Membresia_lbl.AutoSize = true;
            Membresia_lbl.Location = new Point(42, 376);
            Membresia_lbl.Name = "Membresia_lbl";
            Membresia_lbl.Size = new Size(140, 15);
            Membresia_lbl.TabIndex = 5;
            Membresia_lbl.Text = "Fecha vencimiento cuota";
            // 
            // btn_GRABARPEROSONA
            // 
            btn_GRABARPEROSONA.Location = new Point(0, 0);
            btn_GRABARPEROSONA.Name = "btn_GRABARPEROSONA";
            btn_GRABARPEROSONA.Size = new Size(75, 23);
            btn_GRABARPEROSONA.TabIndex = 13;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(199, 195);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(188, 23);
            txt_dni.TabIndex = 7;
            // 
            // lbl_Fechanac
            // 
            lbl_Fechanac.AutoSize = true;
            lbl_Fechanac.Location = new Point(53, 269);
            lbl_Fechanac.Name = "lbl_Fechanac";
            lbl_Fechanac.Size = new Size(117, 15);
            lbl_Fechanac.TabIndex = 9;
            lbl_Fechanac.Text = "Fecha de nacimiento";
            // 
            // dtp_fechanacimiento
            // 
            dtp_fechanacimiento.Location = new Point(199, 263);
            dtp_fechanacimiento.Name = "dtp_fechanacimiento";
            dtp_fechanacimiento.Size = new Size(200, 23);
            dtp_fechanacimiento.TabIndex = 10;
            // 
            // dtp_fechainicio
            // 
            dtp_fechainicio.Location = new Point(199, 312);
            dtp_fechainicio.Name = "dtp_fechainicio";
            dtp_fechainicio.Size = new Size(200, 23);
            dtp_fechainicio.TabIndex = 11;
            // 
            // dtp_fechavencimiento
            // 
            dtp_fechavencimiento.Location = new Point(199, 370);
            dtp_fechavencimiento.Name = "dtp_fechavencimiento";
            dtp_fechavencimiento.Size = new Size(200, 23);
            dtp_fechavencimiento.TabIndex = 12;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(538, 473);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(144, 45);
            btn_agregar.TabIndex = 14;
            btn_agregar.Text = "agregar persoma";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(182, 424);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(247, 23);
            textBox3.TabIndex = 15;
            // 
            // lbl_fechainicio
            // 
            lbl_fechainicio.AutoSize = true;
            lbl_fechainicio.Location = new Point(88, 320);
            lbl_fechainicio.Name = "lbl_fechainicio";
            lbl_fechainicio.Size = new Size(73, 15);
            lbl_fechainicio.TabIndex = 16;
            lbl_fechainicio.Text = "Fecha inicio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 432);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 17;
            label1.Text = "Membresia:";
            // 
            // DVGinsertarclientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_606549277_BMzgu4QoNfqHDkmUgngJrFHuxZXvkS7d;
            ClientSize = new Size(756, 540);
            Controls.Add(label1);
            Controls.Add(lbl_fechainicio);
            Controls.Add(textBox3);
            Controls.Add(btn_agregar);
            Controls.Add(dtp_fechavencimiento);
            Controls.Add(dtp_fechainicio);
            Controls.Add(dtp_fechanacimiento);
            Controls.Add(lbl_Fechanac);
            Controls.Add(txt_dni);
            Controls.Add(btn_GRABARPEROSONA);
            Controls.Add(Membresia_lbl);
            Controls.Add(dni_lbl);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbl_apellid);
            Controls.Add(lbl_Nombre);
            Name = "DVGinsertarclientes";
            Load += DVGinsertarclientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Nombre;
        private Label lbl_apellid;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label dni_lbl;
        private Label Membresia_lbl;
        private Button btn_GRABARPEROSONA;
        private TextBox txt_dni;
        private ListBox listBox2;
        private Label lbl_Fechanac;
        private DateTimePicker dtp_fechanacimiento;
        private DateTimePicker dtp_fechainicio;
        private DateTimePicker dtp_fechavencimiento;
        private Button btn_agregar;
        private TextBox textBox3;
        private Label lbl_fechainicio;
        private Label label1;
    }
}