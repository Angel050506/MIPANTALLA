namespace pacientes_pantalla
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPaciente = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelFechaNAci = new System.Windows.Forms.Label();
            this.labelsexo = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelHistorial = new System.Windows.Forms.Label();
            this.txtIDPaciente = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.buttonGuardar_paciente = new System.Windows.Forms.Button();
            this.buttonActualizar_datos = new System.Windows.Forms.Button();
            this.buttonCONSULTAR = new System.Windows.Forms.Button();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.txtHistorial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Location = new System.Drawing.Point(102, 54);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(75, 16);
            this.labelPaciente.TabIndex = 0;
            this.labelPaciente.Text = "ID paciente";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(117, 96);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(120, 132);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(57, 16);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellido";
            // 
            // labelFechaNAci
            // 
            this.labelFechaNAci.AutoSize = true;
            this.labelFechaNAci.Location = new System.Drawing.Point(40, 165);
            this.labelFechaNAci.Name = "labelFechaNAci";
            this.labelFechaNAci.Size = new System.Drawing.Size(137, 16);
            this.labelFechaNAci.TabIndex = 3;
            this.labelFechaNAci.Text = "Fecha De Nacimiento";
            // 
            // labelsexo
            // 
            this.labelsexo.AutoSize = true;
            this.labelsexo.Location = new System.Drawing.Point(137, 200);
            this.labelsexo.Name = "labelsexo";
            this.labelsexo.Size = new System.Drawing.Size(36, 16);
            this.labelsexo.TabIndex = 4;
            this.labelsexo.Text = "sexo";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(132, 233);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(113, 263);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(64, 16);
            this.labelDireccion.TabIndex = 6;
            this.labelDireccion.Text = "Direccion";
            // 
            // labelHistorial
            // 
            this.labelHistorial.AutoSize = true;
            this.labelHistorial.Location = new System.Drawing.Point(73, 302);
            this.labelHistorial.Name = "labelHistorial";
            this.labelHistorial.Size = new System.Drawing.Size(104, 16);
            this.labelHistorial.TabIndex = 7;
            this.labelHistorial.Text = "Historial medico";
            // 
            // txtIDPaciente
            // 
            this.txtIDPaciente.Location = new System.Drawing.Point(211, 50);
            this.txtIDPaciente.Name = "txtIDPaciente";
            this.txtIDPaciente.Size = new System.Drawing.Size(100, 22);
            this.txtIDPaciente.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(211, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(211, 125);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(211, 233);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(211, 263);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 22);
            this.txtDireccion.TabIndex = 17;
            // 
            // buttonGuardar_paciente
            // 
            this.buttonGuardar_paciente.Location = new System.Drawing.Point(533, 48);
            this.buttonGuardar_paciente.Name = "buttonGuardar_paciente";
            this.buttonGuardar_paciente.Size = new System.Drawing.Size(197, 23);
            this.buttonGuardar_paciente.TabIndex = 20;
            this.buttonGuardar_paciente.Text = "Guardar paciente";
            this.buttonGuardar_paciente.UseVisualStyleBackColor = true;
            this.buttonGuardar_paciente.Click += new System.EventHandler(this.buttonGuardar_paciente_Click);
            // 
            // buttonActualizar_datos
            // 
            this.buttonActualizar_datos.Location = new System.Drawing.Point(533, 82);
            this.buttonActualizar_datos.Name = "buttonActualizar_datos";
            this.buttonActualizar_datos.Size = new System.Drawing.Size(197, 23);
            this.buttonActualizar_datos.TabIndex = 21;
            this.buttonActualizar_datos.Text = "Actualizar Datos";
            this.buttonActualizar_datos.UseVisualStyleBackColor = true;
            this.buttonActualizar_datos.Click += new System.EventHandler(this.buttonActualizar_datos_Click);
            // 
            // buttonCONSULTAR
            // 
            this.buttonCONSULTAR.Location = new System.Drawing.Point(533, 129);
            this.buttonCONSULTAR.Name = "buttonCONSULTAR";
            this.buttonCONSULTAR.Size = new System.Drawing.Size(197, 23);
            this.buttonCONSULTAR.TabIndex = 24;
            this.buttonCONSULTAR.Text = "CONSULTAR HISTORIAL";
            this.buttonCONSULTAR.UseVisualStyleBackColor = true;
            this.buttonCONSULTAR.Click += new System.EventHandler(this.buttonCONSULTAR_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(211, 165);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaNacimiento.TabIndex = 25;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Hombre ",
            "Mujer",
            "Otro"});
            this.cmbSexo.Location = new System.Drawing.Point(211, 200);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 24);
            this.cmbSexo.TabIndex = 26;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(533, 167);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(197, 23);
            this.button_Limpiar.TabIndex = 27;
            this.button_Limpiar.Text = "Limpiar casillas";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // txtHistorial
            // 
            this.txtHistorial.Location = new System.Drawing.Point(211, 302);
            this.txtHistorial.Name = "txtHistorial";
            this.txtHistorial.Size = new System.Drawing.Size(265, 22);
            this.txtHistorial.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHistorial);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.buttonCONSULTAR);
            this.Controls.Add(this.buttonActualizar_datos);
            this.Controls.Add(this.buttonGuardar_paciente);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDPaciente);
            this.Controls.Add(this.labelHistorial);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelsexo);
            this.Controls.Add(this.labelFechaNAci);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelPaciente);
            this.Name = "Form1";
            this.Text = "Pacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPaciente;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelFechaNAci;
        private System.Windows.Forms.Label labelsexo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelHistorial;
        private System.Windows.Forms.TextBox txtIDPaciente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button buttonGuardar_paciente;
        private System.Windows.Forms.Button buttonActualizar_datos;
        private System.Windows.Forms.Button buttonCONSULTAR;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.TextBox txtHistorial;
    }
}

