namespace wd
{
    partial class frmguardartipocambio
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
            this.txtmonedagtc = new System.Windows.Forms.TextBox();
            this.txttipocambioventagtc = new System.Windows.Forms.TextBox();
            this.gbguardartipocambio = new System.Windows.Forms.GroupBox();
            this.txttipocambiocompragtc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmostrargtc = new System.Windows.Forms.Button();
            this.btnagregargtc = new System.Windows.Forms.Button();
            this.btnconectargtc = new System.Windows.Forms.Button();
            this.dgvgtc = new System.Windows.Forms.DataGridView();
            this.gbguardartipocambio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgtc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmonedagtc
            // 
            this.txtmonedagtc.Location = new System.Drawing.Point(216, 88);
            this.txtmonedagtc.Name = "txtmonedagtc";
            this.txtmonedagtc.Size = new System.Drawing.Size(386, 20);
            this.txtmonedagtc.TabIndex = 6;
            // 
            // txttipocambioventagtc
            // 
            this.txttipocambioventagtc.Location = new System.Drawing.Point(216, 59);
            this.txttipocambioventagtc.Name = "txttipocambioventagtc";
            this.txttipocambioventagtc.Size = new System.Drawing.Size(386, 20);
            this.txttipocambioventagtc.TabIndex = 5;
            // 
            // gbguardartipocambio
            // 
            this.gbguardartipocambio.Controls.Add(this.txtmonedagtc);
            this.gbguardartipocambio.Controls.Add(this.txttipocambioventagtc);
            this.gbguardartipocambio.Controls.Add(this.txttipocambiocompragtc);
            this.gbguardartipocambio.Controls.Add(this.label3);
            this.gbguardartipocambio.Controls.Add(this.label2);
            this.gbguardartipocambio.Controls.Add(this.label1);
            this.gbguardartipocambio.Location = new System.Drawing.Point(17, 11);
            this.gbguardartipocambio.Name = "gbguardartipocambio";
            this.gbguardartipocambio.Size = new System.Drawing.Size(649, 138);
            this.gbguardartipocambio.TabIndex = 21;
            this.gbguardartipocambio.TabStop = false;
            this.gbguardartipocambio.Text = "Tabla Guardar Tipo Cambio";
            // 
            // txttipocambiocompragtc
            // 
            this.txttipocambiocompragtc.Location = new System.Drawing.Point(216, 29);
            this.txttipocambiocompragtc.Name = "txttipocambiocompragtc";
            this.txttipocambiocompragtc.Size = new System.Drawing.Size(386, 20);
            this.txttipocambiocompragtc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Moneda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo cambio Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Cambio Compra";
            // 
            // btnmostrargtc
            // 
            this.btnmostrargtc.Location = new System.Drawing.Point(509, 160);
            this.btnmostrargtc.Name = "btnmostrargtc";
            this.btnmostrargtc.Size = new System.Drawing.Size(136, 54);
            this.btnmostrargtc.TabIndex = 23;
            this.btnmostrargtc.Text = "Mostrar";
            this.btnmostrargtc.UseVisualStyleBackColor = true;
            this.btnmostrargtc.Click += new System.EventHandler(this.btnmostrargtc_Click);
            // 
            // btnagregargtc
            // 
            this.btnagregargtc.Location = new System.Drawing.Point(26, 160);
            this.btnagregargtc.Name = "btnagregargtc";
            this.btnagregargtc.Size = new System.Drawing.Size(136, 54);
            this.btnagregargtc.TabIndex = 22;
            this.btnagregargtc.Text = "Agregar";
            this.btnagregargtc.UseVisualStyleBackColor = true;
            this.btnagregargtc.Click += new System.EventHandler(this.btnagregargtc_Click);
            // 
            // btnconectargtc
            // 
            this.btnconectargtc.Location = new System.Drawing.Point(229, 160);
            this.btnconectargtc.Name = "btnconectargtc";
            this.btnconectargtc.Size = new System.Drawing.Size(229, 54);
            this.btnconectargtc.TabIndex = 20;
            this.btnconectargtc.Text = "Probar conexion";
            this.btnconectargtc.UseVisualStyleBackColor = true;
            this.btnconectargtc.Click += new System.EventHandler(this.btnconectargtc_Click);
            // 
            // dgvgtc
            // 
            this.dgvgtc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgtc.Location = new System.Drawing.Point(24, 232);
            this.dgvgtc.Name = "dgvgtc";
            this.dgvgtc.Size = new System.Drawing.Size(636, 236);
            this.dgvgtc.TabIndex = 24;
            // 
            // frmguardartipocambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 485);
            this.Controls.Add(this.gbguardartipocambio);
            this.Controls.Add(this.btnmostrargtc);
            this.Controls.Add(this.btnagregargtc);
            this.Controls.Add(this.btnconectargtc);
            this.Controls.Add(this.dgvgtc);
            this.Name = "frmguardartipocambio";
            this.Text = "frmguardartipocambio";
            this.gbguardartipocambio.ResumeLayout(false);
            this.gbguardartipocambio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgtc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtmonedagtc;
        private System.Windows.Forms.TextBox txttipocambioventagtc;
        private System.Windows.Forms.GroupBox gbguardartipocambio;
        private System.Windows.Forms.TextBox txttipocambiocompragtc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmostrargtc;
        private System.Windows.Forms.Button btnagregargtc;
        private System.Windows.Forms.Button btnconectargtc;
        private System.Windows.Forms.DataGridView dgvgtc;
    }
}