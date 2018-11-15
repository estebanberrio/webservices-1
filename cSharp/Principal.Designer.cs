namespace ws
{
    partial class principal
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
            this.btninit = new System.Windows.Forms.Button();
            this.btnguardartipocambio = new System.Windows.Forms.Button();
            this.btnguardarinventario = new System.Windows.Forms.Button();
            this.btnguardarimpuesto = new System.Windows.Forms.Button();
            this.btnguardarbancos = new System.Windows.Forms.Button();
            this.btnguardarantiguedadcxc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btninit
            // 
            this.btninit.BackColor = System.Drawing.Color.Transparent;
            this.btninit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btninit.Location = new System.Drawing.Point(42, 63);
            this.btninit.Name = "btninit";
            this.btninit.Size = new System.Drawing.Size(195, 60);
            this.btninit.TabIndex = 0;
            this.btninit.Text = "Tabla Init";
            this.btninit.UseVisualStyleBackColor = false;
            this.btninit.Click += new System.EventHandler(this.btninit_Click);
            // 
            // btnguardartipocambio
            // 
            this.btnguardartipocambio.BackColor = System.Drawing.Color.Transparent;
            this.btnguardartipocambio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardartipocambio.Location = new System.Drawing.Point(42, 139);
            this.btnguardartipocambio.Name = "btnguardartipocambio";
            this.btnguardartipocambio.Size = new System.Drawing.Size(195, 60);
            this.btnguardartipocambio.TabIndex = 1;
            this.btnguardartipocambio.Text = "Tabla Guardar Tipo Cambio";
            this.btnguardartipocambio.UseVisualStyleBackColor = false;
            this.btnguardartipocambio.Click += new System.EventHandler(this.btnguardartipocambio_Click);
            // 
            // btnguardarinventario
            // 
            this.btnguardarinventario.BackColor = System.Drawing.Color.Transparent;
            this.btnguardarinventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardarinventario.Location = new System.Drawing.Point(42, 214);
            this.btnguardarinventario.Name = "btnguardarinventario";
            this.btnguardarinventario.Size = new System.Drawing.Size(195, 60);
            this.btnguardarinventario.TabIndex = 2;
            this.btnguardarinventario.Text = "Tabla Guardar Inventario";
            this.btnguardarinventario.UseVisualStyleBackColor = false;
            this.btnguardarinventario.Click += new System.EventHandler(this.btnguardarinventario_Click);
            // 
            // btnguardarimpuesto
            // 
            this.btnguardarimpuesto.BackColor = System.Drawing.Color.Transparent;
            this.btnguardarimpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardarimpuesto.Location = new System.Drawing.Point(274, 63);
            this.btnguardarimpuesto.Name = "btnguardarimpuesto";
            this.btnguardarimpuesto.Size = new System.Drawing.Size(195, 60);
            this.btnguardarimpuesto.TabIndex = 3;
            this.btnguardarimpuesto.Text = "Tabla Guardar Impuesto";
            this.btnguardarimpuesto.UseVisualStyleBackColor = false;
            this.btnguardarimpuesto.Click += new System.EventHandler(this.btnguardarimpuesto_Click);
            // 
            // btnguardarbancos
            // 
            this.btnguardarbancos.BackColor = System.Drawing.Color.Transparent;
            this.btnguardarbancos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardarbancos.Location = new System.Drawing.Point(274, 139);
            this.btnguardarbancos.Name = "btnguardarbancos";
            this.btnguardarbancos.Size = new System.Drawing.Size(195, 60);
            this.btnguardarbancos.TabIndex = 4;
            this.btnguardarbancos.Text = "Tabla Guardar Bancos";
            this.btnguardarbancos.UseVisualStyleBackColor = false;
            this.btnguardarbancos.Click += new System.EventHandler(this.btnguardarbancos_Click);
            // 
            // btnguardarantiguedadcxc
            // 
            this.btnguardarantiguedadcxc.BackColor = System.Drawing.Color.Transparent;
            this.btnguardarantiguedadcxc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardarantiguedadcxc.Location = new System.Drawing.Point(274, 214);
            this.btnguardarantiguedadcxc.Name = "btnguardarantiguedadcxc";
            this.btnguardarantiguedadcxc.Size = new System.Drawing.Size(195, 60);
            this.btnguardarantiguedadcxc.TabIndex = 5;
            this.btnguardarantiguedadcxc.Text = "Tabla Guardar Antiguedad CXC";
            this.btnguardarantiguedadcxc.UseVisualStyleBackColor = false;
            this.btnguardarantiguedadcxc.Click += new System.EventHandler(this.btnguardarantiguedadcxc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione la tabla a gestionar";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(509, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguardarantiguedadcxc);
            this.Controls.Add(this.btnguardarbancos);
            this.Controls.Add(this.btnguardarimpuesto);
            this.Controls.Add(this.btnguardarinventario);
            this.Controls.Add(this.btnguardartipocambio);
            this.Controls.Add(this.btninit);
            this.Name = "principal";
            this.Text = "Gestionar Tabla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninit;
        private System.Windows.Forms.Button btnguardartipocambio;
        private System.Windows.Forms.Button btnguardarinventario;
        private System.Windows.Forms.Button btnguardarimpuesto;
        private System.Windows.Forms.Button btnguardarbancos;
        private System.Windows.Forms.Button btnguardarantiguedadcxc;
        private System.Windows.Forms.Label label1;
    }
}