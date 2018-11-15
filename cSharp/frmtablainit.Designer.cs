namespace ws
{
    partial class frmtablainit
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
            this.txttokenti = new System.Windows.Forms.TextBox();
            this.txtcontrasenati = new System.Windows.Forms.TextBox();
            this.txtusuarioti = new System.Windows.Forms.TextBox();
            this.gbtablainit = new System.Windows.Forms.GroupBox();
            this.txtidcompaniati = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmostrarti = new System.Windows.Forms.Button();
            this.btnagregarti = new System.Windows.Forms.Button();
            this.btnconectarti = new System.Windows.Forms.Button();
            this.dgvti = new System.Windows.Forms.DataGridView();
            this.gbtablainit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvti)).BeginInit();
            this.SuspendLayout();
            // 
            // txttokenti
            // 
            this.txttokenti.Location = new System.Drawing.Point(216, 111);
            this.txttokenti.Name = "txttokenti";
            this.txttokenti.Size = new System.Drawing.Size(386, 20);
            this.txttokenti.TabIndex = 7;
            // 
            // txtcontrasenati
            // 
            this.txtcontrasenati.Location = new System.Drawing.Point(216, 85);
            this.txtcontrasenati.Name = "txtcontrasenati";
            this.txtcontrasenati.Size = new System.Drawing.Size(386, 20);
            this.txtcontrasenati.TabIndex = 6;
            // 
            // txtusuarioti
            // 
            this.txtusuarioti.Location = new System.Drawing.Point(216, 56);
            this.txtusuarioti.Name = "txtusuarioti";
            this.txtusuarioti.Size = new System.Drawing.Size(386, 20);
            this.txtusuarioti.TabIndex = 5;
            // 
            // gbtablainit
            // 
            this.gbtablainit.Controls.Add(this.txttokenti);
            this.gbtablainit.Controls.Add(this.txtcontrasenati);
            this.gbtablainit.Controls.Add(this.txtusuarioti);
            this.gbtablainit.Controls.Add(this.txtidcompaniati);
            this.gbtablainit.Controls.Add(this.label4);
            this.gbtablainit.Controls.Add(this.label3);
            this.gbtablainit.Controls.Add(this.label2);
            this.gbtablainit.Controls.Add(this.label1);
            this.gbtablainit.Location = new System.Drawing.Point(16, 13);
            this.gbtablainit.Name = "gbtablainit";
            this.gbtablainit.Size = new System.Drawing.Size(644, 145);
            this.gbtablainit.TabIndex = 26;
            this.gbtablainit.TabStop = false;
            this.gbtablainit.Text = "Tabla init";
            // 
            // txtidcompaniati
            // 
            this.txtidcompaniati.Location = new System.Drawing.Point(216, 26);
            this.txtidcompaniati.Name = "txtidcompaniati";
            this.txtidcompaniati.Size = new System.Drawing.Size(386, 20);
            this.txtidcompaniati.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TOKEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Compañia";
            // 
            // btnmostrarti
            // 
            this.btnmostrarti.Location = new System.Drawing.Point(512, 164);
            this.btnmostrarti.Name = "btnmostrarti";
            this.btnmostrarti.Size = new System.Drawing.Size(136, 54);
            this.btnmostrarti.TabIndex = 28;
            this.btnmostrarti.Text = "Mostrar";
            this.btnmostrarti.UseVisualStyleBackColor = true;
            this.btnmostrarti.Click += new System.EventHandler(this.btnmostrarti_Click);
            // 
            // btnagregarti
            // 
            this.btnagregarti.Location = new System.Drawing.Point(29, 164);
            this.btnagregarti.Name = "btnagregarti";
            this.btnagregarti.Size = new System.Drawing.Size(136, 54);
            this.btnagregarti.TabIndex = 27;
            this.btnagregarti.Text = "Agregar";
            this.btnagregarti.UseVisualStyleBackColor = true;
            this.btnagregarti.Click += new System.EventHandler(this.btnagregarti_Click);
            // 
            // btnconectarti
            // 
            this.btnconectarti.Location = new System.Drawing.Point(232, 164);
            this.btnconectarti.Name = "btnconectarti";
            this.btnconectarti.Size = new System.Drawing.Size(229, 54);
            this.btnconectarti.TabIndex = 25;
            this.btnconectarti.Text = "Probar conexion";
            this.btnconectarti.UseVisualStyleBackColor = true;
            this.btnconectarti.Click += new System.EventHandler(this.btnconectarti_Click);
            // 
            // dgvti
            // 
            this.dgvti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvti.Location = new System.Drawing.Point(24, 224);
            this.dgvti.Name = "dgvti";
            this.dgvti.Size = new System.Drawing.Size(636, 198);
            this.dgvti.TabIndex = 29;
            // 
            // frmtablainit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 435);
            this.Controls.Add(this.gbtablainit);
            this.Controls.Add(this.btnmostrarti);
            this.Controls.Add(this.btnagregarti);
            this.Controls.Add(this.btnconectarti);
            this.Controls.Add(this.dgvti);
            this.Name = "frmtablainit";
            this.Text = "frmtablainit";
            this.gbtablainit.ResumeLayout(false);
            this.gbtablainit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txttokenti;
        private System.Windows.Forms.TextBox txtcontrasenati;
        private System.Windows.Forms.TextBox txtusuarioti;
        private System.Windows.Forms.GroupBox gbtablainit;
        private System.Windows.Forms.TextBox txtidcompaniati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmostrarti;
        private System.Windows.Forms.Button btnagregarti;
        private System.Windows.Forms.Button btnconectarti;
        private System.Windows.Forms.DataGridView dgvti;
    }
}