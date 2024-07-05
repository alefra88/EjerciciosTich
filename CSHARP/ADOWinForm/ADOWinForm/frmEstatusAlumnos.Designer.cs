namespace ADOWinForm
{
    partial class frmEstatusAlumnos
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
            this.cbxEstatusAlumno = new System.Windows.Forms.ComboBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvestatus = new System.Windows.Forms.DataGridView();
            this.pnlDetalles = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nomTxtBx = new System.Windows.Forms.TextBox();
            this.txtBxClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestatus)).BeginInit();
            this.pnlDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxEstatusAlumno
            // 
            this.cbxEstatusAlumno.FormattingEnabled = true;
            this.cbxEstatusAlumno.Location = new System.Drawing.Point(112, 28);
            this.cbxEstatusAlumno.Name = "cbxEstatusAlumno";
            this.cbxEstatusAlumno.Size = new System.Drawing.Size(121, 21);
            this.cbxEstatusAlumno.TabIndex = 0;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(34, 31);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(42, 13);
            this.lblEstatus.TabIndex = 1;
            this.lblEstatus.Text = "Estatus";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(358, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(439, 28);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(520, 28);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvestatus
            // 
            this.dgvestatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestatus.Location = new System.Drawing.Point(34, 69);
            this.dgvestatus.Name = "dgvestatus";
            this.dgvestatus.Size = new System.Drawing.Size(573, 238);
            this.dgvestatus.TabIndex = 3;
            // 
            // pnlDetalles
            // 
            this.pnlDetalles.Controls.Add(this.btnCancelar);
            this.pnlDetalles.Controls.Add(this.btnGuardar);
            this.pnlDetalles.Controls.Add(this.nomTxtBx);
            this.pnlDetalles.Controls.Add(this.txtBxClave);
            this.pnlDetalles.Controls.Add(this.lblClave);
            this.pnlDetalles.Controls.Add(this.lblNombre);
            this.pnlDetalles.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pnlDetalles.Location = new System.Drawing.Point(41, 313);
            this.pnlDetalles.Name = "pnlDetalles";
            this.pnlDetalles.Size = new System.Drawing.Size(576, 114);
            this.pnlDetalles.TabIndex = 4;
            this.pnlDetalles.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(268, 79);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(131, 79);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // nomTxtBx
            // 
            this.nomTxtBx.Location = new System.Drawing.Point(183, 13);
            this.nomTxtBx.Name = "nomTxtBx";
            this.nomTxtBx.Size = new System.Drawing.Size(111, 20);
            this.nomTxtBx.TabIndex = 1;
            // 
            // txtBxClave
            // 
            this.txtBxClave.Location = new System.Drawing.Point(183, 44);
            this.txtBxClave.Name = "txtBxClave";
            this.txtBxClave.Size = new System.Drawing.Size(111, 20);
            this.txtBxClave.TabIndex = 1;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(128, 47);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(128, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // frmEstatusAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDetalles);
            this.Controls.Add(this.dgvestatus);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.cbxEstatusAlumno);
            this.Name = "frmEstatusAlumnos";
            this.Text = "frmEstatusAlumnos";
            this.Load += new System.EventHandler(this.frmEstatusAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvestatus)).EndInit();
            this.pnlDetalles.ResumeLayout(false);
            this.pnlDetalles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEstatusAlumno;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvestatus;
        private System.Windows.Forms.Panel pnlDetalles;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox nomTxtBx;
        private System.Windows.Forms.TextBox txtBxClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombre;
    }
}