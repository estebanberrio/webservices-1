namespace cSharp
{
    partial class Inicio
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnvalidarconexion = new System.Windows.Forms.Button();
            this.btnllenardirecta = new System.Windows.Forms.Button();
            this.btnconsumirws = new System.Windows.Forms.Button();
            this.btneliminardatos = new System.Windows.Forms.Button();
            this.btncargarexcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccione actividad a realizar";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Location = new System.Drawing.Point(266, 217);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(195, 60);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnvalidarconexion
            // 
            this.btnvalidarconexion.BackColor = System.Drawing.Color.Transparent;
            this.btnvalidarconexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvalidarconexion.Location = new System.Drawing.Point(266, 142);
            this.btnvalidarconexion.Name = "btnvalidarconexion";
            this.btnvalidarconexion.Size = new System.Drawing.Size(195, 60);
            this.btnvalidarconexion.TabIndex = 11;
            this.btnvalidarconexion.Text = "Validar Conexión Base de Datos";
            this.btnvalidarconexion.UseVisualStyleBackColor = false;
            this.btnvalidarconexion.Click += new System.EventHandler(this.btnvalidarconexion_Click);
            // 
            // btnllenardirecta
            // 
            this.btnllenardirecta.BackColor = System.Drawing.Color.Transparent;
            this.btnllenardirecta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnllenardirecta.Location = new System.Drawing.Point(266, 66);
            this.btnllenardirecta.Name = "btnllenardirecta";
            this.btnllenardirecta.Size = new System.Drawing.Size(195, 60);
            this.btnllenardirecta.TabIndex = 10;
            this.btnllenardirecta.Text = "Llenar datos de forma directa";
            this.btnllenardirecta.UseVisualStyleBackColor = false;
            this.btnllenardirecta.Click += new System.EventHandler(this.btnllenardirecta_Click);
            // 
            // btnconsumirws
            // 
            this.btnconsumirws.BackColor = System.Drawing.Color.Transparent;
            this.btnconsumirws.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnconsumirws.Location = new System.Drawing.Point(34, 217);
            this.btnconsumirws.Name = "btnconsumirws";
            this.btnconsumirws.Size = new System.Drawing.Size(195, 60);
            this.btnconsumirws.TabIndex = 9;
            this.btnconsumirws.Text = "Consumir Web Services";
            this.btnconsumirws.UseVisualStyleBackColor = false;
            this.btnconsumirws.Click += new System.EventHandler(this.btnconsumirws_Click);
            // 
            // btneliminardatos
            // 
            this.btneliminardatos.BackColor = System.Drawing.Color.Transparent;
            this.btneliminardatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminardatos.Location = new System.Drawing.Point(34, 142);
            this.btneliminardatos.Name = "btneliminardatos";
            this.btneliminardatos.Size = new System.Drawing.Size(195, 60);
            this.btneliminardatos.TabIndex = 8;
            this.btneliminardatos.Text = "Eliminar Datos Anteriores";
            this.btneliminardatos.UseVisualStyleBackColor = false;
            this.btneliminardatos.Click += new System.EventHandler(this.btneliminardatos_Click);
            // 
            // btncargarexcel
            // 
            this.btncargarexcel.BackColor = System.Drawing.Color.Transparent;
            this.btncargarexcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncargarexcel.Location = new System.Drawing.Point(34, 66);
            this.btncargarexcel.Name = "btncargarexcel";
            this.btncargarexcel.Size = new System.Drawing.Size(195, 60);
            this.btncargarexcel.TabIndex = 7;
            this.btncargarexcel.Text = "Cargar Archivos Excel";
            this.btncargarexcel.UseVisualStyleBackColor = false;
            this.btncargarexcel.Click += new System.EventHandler(this.btncargarexcel_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(487, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnvalidarconexion);
            this.Controls.Add(this.btnllenardirecta);
            this.Controls.Add(this.btnconsumirws);
            this.Controls.Add(this.btneliminardatos);
            this.Controls.Add(this.btncargarexcel);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnvalidarconexion;
        private System.Windows.Forms.Button btnllenardirecta;
        private System.Windows.Forms.Button btnconsumirws;
        private System.Windows.Forms.Button btneliminardatos;
        private System.Windows.Forms.Button btncargarexcel;
    }
}