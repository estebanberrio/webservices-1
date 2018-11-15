namespace ws
{
    partial class frmguardarimpuesto
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
            this.txtidcompaniagim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbguardarimpuesto = new System.Windows.Forms.GroupBox();
            this.txtdescripciongim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmontogim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmensajegim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttokengim = new System.Windows.Forms.TextBox();
            this.txtidclasificaciongim = new System.Windows.Forms.TextBox();
            this.txtcuentaimpuestogim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvgim = new System.Windows.Forms.DataGridView();
            this.btnmostrargim = new System.Windows.Forms.Button();
            this.btnagregargim = new System.Windows.Forms.Button();
            this.btnconectargim = new System.Windows.Forms.Button();
            this.gbguardarimpuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidcompaniagim
            // 
            this.txtidcompaniagim.Location = new System.Drawing.Point(216, 29);
            this.txtidcompaniagim.Name = "txtidcompaniagim";
            this.txtidcompaniagim.Size = new System.Drawing.Size(386, 20);
            this.txtidcompaniagim.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuenta Impuesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdCompañia";
            // 
            // gbguardarimpuesto
            // 
            this.gbguardarimpuesto.Controls.Add(this.txtdescripciongim);
            this.gbguardarimpuesto.Controls.Add(this.label7);
            this.gbguardarimpuesto.Controls.Add(this.txtmontogim);
            this.gbguardarimpuesto.Controls.Add(this.label6);
            this.gbguardarimpuesto.Controls.Add(this.txtmensajegim);
            this.gbguardarimpuesto.Controls.Add(this.label5);
            this.gbguardarimpuesto.Controls.Add(this.txttokengim);
            this.gbguardarimpuesto.Controls.Add(this.txtidclasificaciongim);
            this.gbguardarimpuesto.Controls.Add(this.txtcuentaimpuestogim);
            this.gbguardarimpuesto.Controls.Add(this.txtidcompaniagim);
            this.gbguardarimpuesto.Controls.Add(this.label4);
            this.gbguardarimpuesto.Controls.Add(this.label3);
            this.gbguardarimpuesto.Controls.Add(this.label2);
            this.gbguardarimpuesto.Controls.Add(this.label1);
            this.gbguardarimpuesto.Location = new System.Drawing.Point(12, 8);
            this.gbguardarimpuesto.Name = "gbguardarimpuesto";
            this.gbguardarimpuesto.Size = new System.Drawing.Size(649, 231);
            this.gbguardarimpuesto.TabIndex = 11;
            this.gbguardarimpuesto.TabStop = false;
            this.gbguardarimpuesto.Text = "Tabla Guardar Impuesto";
            // 
            // txtdescripciongim
            // 
            this.txtdescripciongim.Location = new System.Drawing.Point(215, 145);
            this.txtdescripciongim.Name = "txtdescripciongim";
            this.txtdescripciongim.Size = new System.Drawing.Size(386, 20);
            this.txtdescripciongim.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Descripción";
            // 
            // txtmontogim
            // 
            this.txtmontogim.Location = new System.Drawing.Point(215, 118);
            this.txtmontogim.Name = "txtmontogim";
            this.txtmontogim.Size = new System.Drawing.Size(386, 20);
            this.txtmontogim.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Monto";
            // 
            // txtmensajegim
            // 
            this.txtmensajegim.Location = new System.Drawing.Point(216, 198);
            this.txtmensajegim.Name = "txtmensajegim";
            this.txtmensajegim.Size = new System.Drawing.Size(386, 20);
            this.txtmensajegim.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mensaje";
            // 
            // txttokengim
            // 
            this.txttokengim.Location = new System.Drawing.Point(216, 171);
            this.txttokengim.Name = "txttokengim";
            this.txttokengim.Size = new System.Drawing.Size(386, 20);
            this.txttokengim.TabIndex = 7;
            // 
            // txtidclasificaciongim
            // 
            this.txtidclasificaciongim.Location = new System.Drawing.Point(216, 88);
            this.txtidclasificaciongim.Name = "txtidclasificaciongim";
            this.txtidclasificaciongim.Size = new System.Drawing.Size(386, 20);
            this.txtidclasificaciongim.TabIndex = 6;
            // 
            // txtcuentaimpuestogim
            // 
            this.txtcuentaimpuestogim.Location = new System.Drawing.Point(216, 59);
            this.txtcuentaimpuestogim.Name = "txtcuentaimpuestogim";
            this.txtcuentaimpuestogim.Size = new System.Drawing.Size(386, 20);
            this.txtcuentaimpuestogim.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TOKEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Clasificación";
            // 
            // dgvgim
            // 
            this.dgvgim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgim.Location = new System.Drawing.Point(19, 339);
            this.dgvgim.Name = "dgvgim";
            this.dgvgim.Size = new System.Drawing.Size(636, 293);
            this.dgvgim.TabIndex = 14;
            // 
            // btnmostrargim
            // 
            this.btnmostrargim.Location = new System.Drawing.Point(510, 257);
            this.btnmostrargim.Name = "btnmostrargim";
            this.btnmostrargim.Size = new System.Drawing.Size(136, 54);
            this.btnmostrargim.TabIndex = 13;
            this.btnmostrargim.Text = "Mostrar";
            this.btnmostrargim.UseVisualStyleBackColor = true;
            this.btnmostrargim.Click += new System.EventHandler(this.btnmostrargim_Click);
            // 
            // btnagregargim
            // 
            this.btnagregargim.Location = new System.Drawing.Point(27, 257);
            this.btnagregargim.Name = "btnagregargim";
            this.btnagregargim.Size = new System.Drawing.Size(136, 54);
            this.btnagregargim.TabIndex = 12;
            this.btnagregargim.Text = "Agregar";
            this.btnagregargim.UseVisualStyleBackColor = true;
            this.btnagregargim.Click += new System.EventHandler(this.btnagregargim_Click);
            // 
            // btnconectargim
            // 
            this.btnconectargim.Location = new System.Drawing.Point(230, 257);
            this.btnconectargim.Name = "btnconectargim";
            this.btnconectargim.Size = new System.Drawing.Size(229, 54);
            this.btnconectargim.TabIndex = 10;
            this.btnconectargim.Text = "Probar conexion";
            this.btnconectargim.UseVisualStyleBackColor = true;
            this.btnconectargim.Click += new System.EventHandler(this.btnconectargim_Click);
            // 
            // frmguardarimpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 644);
            this.Controls.Add(this.gbguardarimpuesto);
            this.Controls.Add(this.dgvgim);
            this.Controls.Add(this.btnmostrargim);
            this.Controls.Add(this.btnagregargim);
            this.Controls.Add(this.btnconectargim);
            this.Name = "frmguardarimpuesto";
            this.Text = "Formulario Tabla Guardar Impuesto";
            this.gbguardarimpuesto.ResumeLayout(false);
            this.gbguardarimpuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtidcompaniagim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbguardarimpuesto;
        private System.Windows.Forms.TextBox txtmensajegim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttokengim;
        private System.Windows.Forms.TextBox txtidclasificaciongim;
        private System.Windows.Forms.TextBox txtcuentaimpuestogim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvgim;
        private System.Windows.Forms.Button btnmostrargim;
        private System.Windows.Forms.Button btnagregargim;
        private System.Windows.Forms.Button btnconectargim;
        private System.Windows.Forms.TextBox txtdescripciongim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmontogim;
        private System.Windows.Forms.Label label6;
    }
}