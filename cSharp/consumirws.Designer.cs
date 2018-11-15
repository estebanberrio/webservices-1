namespace cSharp
{
    partial class consumirws
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnconsumircxc = new System.Windows.Forms.Button();
            this.btnconsumirgb = new System.Windows.Forms.Button();
            this.btnconsumirgim = new System.Windows.Forms.Button();
            this.btnconsumirgi = new System.Windows.Forms.Button();
            this.btnconsumirgtc = new System.Windows.Forms.Button();
            this.btconsumirinit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccione Servicio a Consumir";
            // 
            // btnconsumircxc
            // 
            this.btnconsumircxc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnconsumircxc.Location = new System.Drawing.Point(264, 220);
            this.btnconsumircxc.Name = "btnconsumircxc";
            this.btnconsumircxc.Size = new System.Drawing.Size(195, 60);
            this.btnconsumircxc.TabIndex = 12;
            this.btnconsumircxc.Text = "Consumir Guardar Antiguedad CXC";
            this.btnconsumircxc.UseVisualStyleBackColor = true;
            this.btnconsumircxc.Click += new System.EventHandler(this.btnconsumircxc_Click);
            // 
            // btnconsumirgb
            // 
            this.btnconsumirgb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnconsumirgb.Location = new System.Drawing.Point(264, 145);
            this.btnconsumirgb.Name = "btnconsumirgb";
            this.btnconsumirgb.Size = new System.Drawing.Size(195, 60);
            this.btnconsumirgb.TabIndex = 11;
            this.btnconsumirgb.Text = "Consumir Guardar Bancos";
            this.btnconsumirgb.UseVisualStyleBackColor = true;
            this.btnconsumirgb.Click += new System.EventHandler(this.btnconsumirgb_Click);
            // 
            // btnconsumirgim
            // 
            this.btnconsumirgim.BackColor = System.Drawing.Color.Transparent;
            this.btnconsumirgim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnconsumirgim.Location = new System.Drawing.Point(264, 69);
            this.btnconsumirgim.Name = "btnconsumirgim";
            this.btnconsumirgim.Size = new System.Drawing.Size(195, 60);
            this.btnconsumirgim.TabIndex = 10;
            this.btnconsumirgim.Text = "Consumir Guardar Impuesto";
            this.btnconsumirgim.UseVisualStyleBackColor = false;
            this.btnconsumirgim.Click += new System.EventHandler(this.btnconsumirgim_Click);
            // 
            // btnconsumirgi
            // 
            this.btnconsumirgi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnconsumirgi.Location = new System.Drawing.Point(32, 220);
            this.btnconsumirgi.Name = "btnconsumirgi";
            this.btnconsumirgi.Size = new System.Drawing.Size(195, 60);
            this.btnconsumirgi.TabIndex = 9;
            this.btnconsumirgi.Text = "Consumir Guardar Inventario";
            this.btnconsumirgi.UseVisualStyleBackColor = true;
            this.btnconsumirgi.Click += new System.EventHandler(this.btnconsumirgi_Click);
            // 
            // btnconsumirgtc
            // 
            this.btnconsumirgtc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnconsumirgtc.Location = new System.Drawing.Point(32, 145);
            this.btnconsumirgtc.Name = "btnconsumirgtc";
            this.btnconsumirgtc.Size = new System.Drawing.Size(195, 60);
            this.btnconsumirgtc.TabIndex = 8;
            this.btnconsumirgtc.Text = "Consumir Guardar Tipo Cambio";
            this.btnconsumirgtc.UseVisualStyleBackColor = true;
            this.btnconsumirgtc.Click += new System.EventHandler(this.btnconsumirgtc_Click);
            // 
            // btconsumirinit
            // 
            this.btconsumirinit.BackColor = System.Drawing.Color.Transparent;
            this.btconsumirinit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btconsumirinit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btconsumirinit.Location = new System.Drawing.Point(32, 69);
            this.btconsumirinit.Name = "btconsumirinit";
            this.btconsumirinit.Size = new System.Drawing.Size(195, 60);
            this.btconsumirinit.TabIndex = 7;
            this.btconsumirinit.Text = "Consumir Init";
            this.btconsumirinit.UseVisualStyleBackColor = false;
            this.btconsumirinit.Click += new System.EventHandler(this.btconsumirinit_Click);
            // 
            // consumirws
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(482, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconsumircxc);
            this.Controls.Add(this.btnconsumirgb);
            this.Controls.Add(this.btnconsumirgim);
            this.Controls.Add(this.btnconsumirgi);
            this.Controls.Add(this.btnconsumirgtc);
            this.Controls.Add(this.btconsumirinit);
            this.Name = "consumirws";
            this.Text = "Consumir WS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnconsumircxc;
        private System.Windows.Forms.Button btnconsumirgb;
        private System.Windows.Forms.Button btnconsumirgim;
        private System.Windows.Forms.Button btnconsumirgi;
        private System.Windows.Forms.Button btnconsumirgtc;
        private System.Windows.Forms.Button btconsumirinit;
    }
}