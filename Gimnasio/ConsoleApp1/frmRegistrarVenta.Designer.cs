namespace ConsoleApp1
{
    partial class frmRegistrarVenta
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
            this.lblIdProd = new System.Windows.Forms.Label();
            this.lblNombProd = new System.Windows.Forms.Label();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtNombProd = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblCantProd = new System.Windows.Forms.Label();
            this.txtCantProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdProd
            // 
            this.lblIdProd.AutoSize = true;
            this.lblIdProd.Location = new System.Drawing.Point(73, 36);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(67, 13);
            this.lblIdProd.TabIndex = 0;
            this.lblIdProd.Text = "ID Producto:";
            this.lblIdProd.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombProd
            // 
            this.lblNombProd.AutoSize = true;
            this.lblNombProd.Location = new System.Drawing.Point(73, 70);
            this.lblNombProd.Name = "lblNombProd";
            this.lblNombProd.Size = new System.Drawing.Size(108, 13);
            this.lblNombProd.TabIndex = 1;
            this.lblNombProd.Text = "Nombre de Producto:";
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(229, 36);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(100, 20);
            this.txtIdProd.TabIndex = 2;
            // 
            // txtNombProd
            // 
            this.txtNombProd.Location = new System.Drawing.Point(229, 67);
            this.txtNombProd.Name = "txtNombProd";
            this.txtNombProd.Size = new System.Drawing.Size(99, 20);
            this.txtNombProd.TabIndex = 3;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(42, 165);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(510, 181);
            this.dgvProductos.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(465, 136);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(42, 352);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(465, 352);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // lblCantProd
            // 
            this.lblCantProd.AutoSize = true;
            this.lblCantProd.Location = new System.Drawing.Point(73, 105);
            this.lblCantProd.Name = "lblCantProd";
            this.lblCantProd.Size = new System.Drawing.Size(52, 13);
            this.lblCantProd.TabIndex = 8;
            this.lblCantProd.Text = "Cantidad:";
            // 
            // txtCantProd
            // 
            this.txtCantProd.Location = new System.Drawing.Point(229, 98);
            this.txtCantProd.Name = "txtCantProd";
            this.txtCantProd.Size = new System.Drawing.Size(100, 20);
            this.txtCantProd.TabIndex = 9;
            // 
            // frmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 400);
            this.Controls.Add(this.txtCantProd);
            this.Controls.Add(this.lblCantProd);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtNombProd);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.lblNombProd);
            this.Controls.Add(this.lblIdProd);
            this.Name = "frmRegistrarVenta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdProd;
        private System.Windows.Forms.Label lblNombProd;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.TextBox txtNombProd;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblCantProd;
        private System.Windows.Forms.TextBox txtCantProd;
    }
}