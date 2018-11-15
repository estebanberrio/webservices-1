namespace ws
{
    partial class frmguardarbancos
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
            this.dgvgb = new System.Windows.Forms.DataGridView();
            this.btnmostrargb = new System.Windows.Forms.Button();
            this.btnagregargb = new System.Windows.Forms.Button();
            this.btnconectargb = new System.Windows.Forms.Button();
            this.txtnombrecuentagb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcuentaclientegb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmonedagb = new System.Windows.Forms.TextBox();
            this.txtbancogb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbguardarbancos = new System.Windows.Forms.GroupBox();
            this.txtfechasaldogb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttipogb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdisponiblegb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtidcompaniagb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgb)).BeginInit();
            this.gbguardarbancos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvgb
            // 
            this.dgvgb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgb.Location = new System.Drawing.Point(29, 371);
            this.dgvgb.Name = "dgvgb";
            this.dgvgb.Size = new System.Drawing.Size(636, 270);
            this.dgvgb.TabIndex = 19;
            // 
            // btnmostrargb
            // 
            this.btnmostrargb.Location = new System.Drawing.Point(517, 299);
            this.btnmostrargb.Name = "btnmostrargb";
            this.btnmostrargb.Size = new System.Drawing.Size(136, 54);
            this.btnmostrargb.TabIndex = 18;
            this.btnmostrargb.Text = "Mostrar";
            this.btnmostrargb.UseVisualStyleBackColor = true;
            this.btnmostrargb.Click += new System.EventHandler(this.btnmostrargb_Click);
            // 
            // btnagregargb
            // 
            this.btnagregargb.Location = new System.Drawing.Point(34, 299);
            this.btnagregargb.Name = "btnagregargb";
            this.btnagregargb.Size = new System.Drawing.Size(136, 54);
            this.btnagregargb.TabIndex = 17;
            this.btnagregargb.Text = "Agregar";
            this.btnagregargb.UseVisualStyleBackColor = true;
            this.btnagregargb.Click += new System.EventHandler(this.btnagregargb_Click);
            // 
            // btnconectargb
            // 
            this.btnconectargb.Location = new System.Drawing.Point(237, 299);
            this.btnconectargb.Name = "btnconectargb";
            this.btnconectargb.Size = new System.Drawing.Size(229, 54);
            this.btnconectargb.TabIndex = 15;
            this.btnconectargb.Text = "Probar conexion";
            this.btnconectargb.UseVisualStyleBackColor = true;
            this.btnconectargb.Click += new System.EventHandler(this.btnconectargb_Click);
            // 
            // txtnombrecuentagb
            // 
            this.txtnombrecuentagb.Location = new System.Drawing.Point(215, 145);
            this.txtnombrecuentagb.Name = "txtnombrecuentagb";
            this.txtnombrecuentagb.Size = new System.Drawing.Size(386, 20);
            this.txtnombrecuentagb.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre Cuenta";
            // 
            // txtcuentaclientegb
            // 
            this.txtcuentaclientegb.Location = new System.Drawing.Point(215, 118);
            this.txtcuentaclientegb.Name = "txtcuentaclientegb";
            this.txtcuentaclientegb.Size = new System.Drawing.Size(386, 20);
            this.txtcuentaclientegb.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cuenta Cliente";
            // 
            // txtmonedagb
            // 
            this.txtmonedagb.Location = new System.Drawing.Point(216, 88);
            this.txtmonedagb.Name = "txtmonedagb";
            this.txtmonedagb.Size = new System.Drawing.Size(386, 20);
            this.txtmonedagb.TabIndex = 6;
            // 
            // txtbancogb
            // 
            this.txtbancogb.Location = new System.Drawing.Point(216, 59);
            this.txtbancogb.Name = "txtbancogb";
            this.txtbancogb.Size = new System.Drawing.Size(386, 20);
            this.txtbancogb.TabIndex = 5;
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
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Banco";
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
            // gbguardarbancos
            // 
            this.gbguardarbancos.Controls.Add(this.txtfechasaldogb);
            this.gbguardarbancos.Controls.Add(this.label8);
            this.gbguardarbancos.Controls.Add(this.txttipogb);
            this.gbguardarbancos.Controls.Add(this.label9);
            this.gbguardarbancos.Controls.Add(this.txtdisponiblegb);
            this.gbguardarbancos.Controls.Add(this.label10);
            this.gbguardarbancos.Controls.Add(this.txtnombrecuentagb);
            this.gbguardarbancos.Controls.Add(this.label7);
            this.gbguardarbancos.Controls.Add(this.txtcuentaclientegb);
            this.gbguardarbancos.Controls.Add(this.label6);
            this.gbguardarbancos.Controls.Add(this.txtmonedagb);
            this.gbguardarbancos.Controls.Add(this.txtbancogb);
            this.gbguardarbancos.Controls.Add(this.txtidcompaniagb);
            this.gbguardarbancos.Controls.Add(this.label3);
            this.gbguardarbancos.Controls.Add(this.label2);
            this.gbguardarbancos.Controls.Add(this.label1);
            this.gbguardarbancos.Location = new System.Drawing.Point(22, 15);
            this.gbguardarbancos.Name = "gbguardarbancos";
            this.gbguardarbancos.Size = new System.Drawing.Size(649, 269);
            this.gbguardarbancos.TabIndex = 16;
            this.gbguardarbancos.TabStop = false;
            this.gbguardarbancos.Text = "Tabla Guardar Bancos";
            // 
            // txtfechasaldogb
            // 
            this.txtfechasaldogb.Location = new System.Drawing.Point(216, 228);
            this.txtfechasaldogb.Name = "txtfechasaldogb";
            this.txtfechasaldogb.Size = new System.Drawing.Size(386, 20);
            this.txtfechasaldogb.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fecha Saldo";
            // 
            // txttipogb
            // 
            this.txttipogb.Location = new System.Drawing.Point(216, 201);
            this.txttipogb.Name = "txttipogb";
            this.txttipogb.Size = new System.Drawing.Size(386, 20);
            this.txttipogb.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tipo";
            // 
            // txtdisponiblegb
            // 
            this.txtdisponiblegb.Location = new System.Drawing.Point(216, 171);
            this.txtdisponiblegb.Name = "txtdisponiblegb";
            this.txtdisponiblegb.Size = new System.Drawing.Size(386, 20);
            this.txtdisponiblegb.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Disponible";
            // 
            // txtidcompaniagb
            // 
            this.txtidcompaniagb.Location = new System.Drawing.Point(216, 29);
            this.txtidcompaniagb.Name = "txtidcompaniagb";
            this.txtidcompaniagb.Size = new System.Drawing.Size(386, 20);
            this.txtidcompaniagb.TabIndex = 4;
            // 
            // frmguardarbancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 651);
            this.Controls.Add(this.dgvgb);
            this.Controls.Add(this.btnmostrargb);
            this.Controls.Add(this.btnagregargb);
            this.Controls.Add(this.btnconectargb);
            this.Controls.Add(this.gbguardarbancos);
            this.Name = "frmguardarbancos";
            this.Text = "Formulario Tabla Guardar Bancos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvgb)).EndInit();
            this.gbguardarbancos.ResumeLayout(false);
            this.gbguardarbancos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvgb;
        private System.Windows.Forms.Button btnmostrargb;
        private System.Windows.Forms.Button btnagregargb;
        private System.Windows.Forms.Button btnconectargb;
        private System.Windows.Forms.TextBox txtnombrecuentagb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcuentaclientegb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmonedagb;
        private System.Windows.Forms.TextBox txtbancogb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbguardarbancos;
        private System.Windows.Forms.TextBox txtfechasaldogb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttipogb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdisponiblegb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtidcompaniagb;
    }
}