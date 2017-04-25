namespace ConsoleApp1
{
    partial class frmPerfilCliente
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
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblApPat = new System.Windows.Forms.Label();
            this.lblApMat = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblIdMembresia = new System.Windows.Forms.Label();
            this.gbDatosPers1 = new System.Windows.Forms.GroupBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApPat = new System.Windows.Forms.TextBox();
            this.txtApMat = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.gbDatosMembresia = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.gbDatosPers1.SuspendLayout();
            this.gbDatosMembresia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(78, 68);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(78, 99);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombres:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(35, 309);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 2;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblApPat
            // 
            this.lblApPat.AutoSize = true;
            this.lblApPat.Location = new System.Drawing.Point(78, 131);
            this.lblApPat.Name = "lblApPat";
            this.lblApPat.Size = new System.Drawing.Size(87, 13);
            this.lblApPat.TabIndex = 3;
            this.lblApPat.Text = "Apellido Paterno:";
            this.lblApPat.Click += new System.EventHandler(this.lblApPat_Click);
            // 
            // lblApMat
            // 
            this.lblApMat.AutoSize = true;
            this.lblApMat.Location = new System.Drawing.Point(78, 162);
            this.lblApMat.Name = "lblApMat";
            this.lblApMat.Size = new System.Drawing.Size(89, 13);
            this.lblApMat.TabIndex = 4;
            this.lblApMat.Text = "Apellido Materno:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(35, 278);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Location = new System.Drawing.Point(35, 212);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(42, 13);
            this.lblDistrito.TabIndex = 6;
            this.lblDistrito.Text = "Distrito:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(35, 178);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(35, 246);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblIdMembresia
            // 
            this.lblIdMembresia.AutoSize = true;
            this.lblIdMembresia.Location = new System.Drawing.Point(35, 32);
            this.lblIdMembresia.Name = "lblIdMembresia";
            this.lblIdMembresia.Size = new System.Drawing.Size(75, 13);
            this.lblIdMembresia.TabIndex = 9;
            this.lblIdMembresia.Text = "ID Membresia:";
            // 
            // gbDatosPers1
            // 
            this.gbDatosPers1.Controls.Add(this.txtFechaNacimiento);
            this.gbDatosPers1.Controls.Add(this.txtCorreo);
            this.gbDatosPers1.Controls.Add(this.txtTelefono);
            this.gbDatosPers1.Controls.Add(this.txtDistrito);
            this.gbDatosPers1.Controls.Add(this.txtDireccion);
            this.gbDatosPers1.Controls.Add(this.txtApMat);
            this.gbDatosPers1.Controls.Add(this.txtApPat);
            this.gbDatosPers1.Controls.Add(this.txtNombre);
            this.gbDatosPers1.Controls.Add(this.txtDni);
            this.gbDatosPers1.Controls.Add(this.lblDireccion);
            this.gbDatosPers1.Controls.Add(this.lblCorreo);
            this.gbDatosPers1.Controls.Add(this.lblTelefono);
            this.gbDatosPers1.Controls.Add(this.lblFechaNacimiento);
            this.gbDatosPers1.Controls.Add(this.lblDistrito);
            this.gbDatosPers1.Location = new System.Drawing.Point(43, 31);
            this.gbDatosPers1.Name = "gbDatosPers1";
            this.gbDatosPers1.Size = new System.Drawing.Size(622, 345);
            this.gbDatosPers1.TabIndex = 10;
            this.gbDatosPers1.TabStop = false;
            this.gbDatosPers1.Text = "Datos Personales";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(486, 37);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(120, 20);
            this.txtDni.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(398, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApPat
            // 
            this.txtApPat.Location = new System.Drawing.Point(398, 100);
            this.txtApPat.Name = "txtApPat";
            this.txtApPat.Size = new System.Drawing.Size(208, 20);
            this.txtApPat.TabIndex = 11;
            // 
            // txtApMat
            // 
            this.txtApMat.Location = new System.Drawing.Point(398, 131);
            this.txtApMat.Name = "txtApMat";
            this.txtApMat.Size = new System.Drawing.Size(208, 20);
            this.txtApMat.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(346, 178);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(260, 20);
            this.txtDireccion.TabIndex = 13;
            // 
            // txtDistrito
            // 
            this.txtDistrito.Location = new System.Drawing.Point(398, 212);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(207, 20);
            this.txtDistrito.TabIndex = 14;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(486, 246);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(119, 20);
            this.txtTelefono.TabIndex = 15;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(398, 278);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(206, 20);
            this.txtCorreo.TabIndex = 16;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(486, 309);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(117, 20);
            this.txtFechaNacimiento.TabIndex = 17;
            // 
            // gbDatosMembresia
            // 
            this.gbDatosMembresia.Controls.Add(this.lbl);
            this.gbDatosMembresia.Controls.Add(this.lblIdMembresia);
            this.gbDatosMembresia.Location = new System.Drawing.Point(43, 406);
            this.gbDatosMembresia.Name = "gbDatosMembresia";
            this.gbDatosMembresia.Size = new System.Drawing.Size(622, 207);
            this.gbDatosMembresia.TabIndex = 11;
            this.gbDatosMembresia.TabStop = false;
            this.gbDatosMembresia.Text = "Datos de Membresia";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(38, 62);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "label1";
            // 
            // frmPerfilCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 799);
            this.Controls.Add(this.lblApMat);
            this.Controls.Add(this.lblApPat);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.gbDatosPers1);
            this.Controls.Add(this.gbDatosMembresia);
            this.Name = "frmPerfilCliente";
            this.Text = "frmPerfilCliente";
            this.gbDatosPers1.ResumeLayout(false);
            this.gbDatosPers1.PerformLayout();
            this.gbDatosMembresia.ResumeLayout(false);
            this.gbDatosMembresia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblApPat;
        private System.Windows.Forms.Label lblApMat;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblIdMembresia;
        private System.Windows.Forms.GroupBox gbDatosPers1;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApMat;
        private System.Windows.Forms.TextBox txtApPat;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.GroupBox gbDatosMembresia;
        private System.Windows.Forms.Label lbl;
    }
}