namespace cSharp
{
    partial class frmcargararchivos
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
            this.tbca = new System.Windows.Forms.TextBox();
            this.btnexaminarca = new System.Windows.Forms.Button();
            this.rbtinit = new System.Windows.Forms.RadioButton();
            this.rbttipocambio = new System.Windows.Forms.RadioButton();
            this.rbtcinventario = new System.Windows.Forms.RadioButton();
            this.rbtimpuesto = new System.Windows.Forms.RadioButton();
            this.rbtbancos = new System.Windows.Forms.RadioButton();
            this.rbtcxc = new System.Windows.Forms.RadioButton();
            this.btncargararchivoca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Seleccione Archivo a Cargar";
            // 
            // tbca
            // 
            this.tbca.Enabled = false;
            this.tbca.Location = new System.Drawing.Point(10, 46);
            this.tbca.Name = "tbca";
            this.tbca.Size = new System.Drawing.Size(468, 20);
            this.tbca.TabIndex = 15;
            // 
            // btnexaminarca
            // 
            this.btnexaminarca.Location = new System.Drawing.Point(160, 81);
            this.btnexaminarca.Name = "btnexaminarca";
            this.btnexaminarca.Size = new System.Drawing.Size(151, 33);
            this.btnexaminarca.TabIndex = 16;
            this.btnexaminarca.Text = "Examinar";
            this.btnexaminarca.UseVisualStyleBackColor = true;
            this.btnexaminarca.Click += new System.EventHandler(this.btnexaminarca_Click);
            // 
            // rbtinit
            // 
            this.rbtinit.AutoSize = true;
            this.rbtinit.Location = new System.Drawing.Point(33, 178);
            this.rbtinit.Name = "rbtinit";
            this.rbtinit.Size = new System.Drawing.Size(80, 17);
            this.rbtinit.TabIndex = 17;
            this.rbtinit.TabStop = true;
            this.rbtinit.Text = "Cargar INIT";
            this.rbtinit.UseVisualStyleBackColor = true;
            // 
            // rbttipocambio
            // 
            this.rbttipocambio.AutoSize = true;
            this.rbttipocambio.Location = new System.Drawing.Point(157, 178);
            this.rbttipocambio.Name = "rbttipocambio";
            this.rbttipocambio.Size = new System.Drawing.Size(118, 17);
            this.rbttipocambio.TabIndex = 18;
            this.rbttipocambio.TabStop = true;
            this.rbttipocambio.Text = "Cargar Tipo Cambio";
            this.rbttipocambio.UseVisualStyleBackColor = true;
            // 
            // rbtcinventario
            // 
            this.rbtcinventario.AutoSize = true;
            this.rbtcinventario.Location = new System.Drawing.Point(306, 180);
            this.rbtcinventario.Name = "rbtcinventario";
            this.rbtcinventario.Size = new System.Drawing.Size(106, 17);
            this.rbtcinventario.TabIndex = 19;
            this.rbtcinventario.TabStop = true;
            this.rbtcinventario.Text = "Cargar Inventario";
            this.rbtcinventario.UseVisualStyleBackColor = true;
            // 
            // rbtimpuesto
            // 
            this.rbtimpuesto.AutoSize = true;
            this.rbtimpuesto.Location = new System.Drawing.Point(33, 201);
            this.rbtimpuesto.Name = "rbtimpuesto";
            this.rbtimpuesto.Size = new System.Drawing.Size(102, 17);
            this.rbtimpuesto.TabIndex = 20;
            this.rbtimpuesto.TabStop = true;
            this.rbtimpuesto.Text = "Cargar Impuesto";
            this.rbtimpuesto.UseVisualStyleBackColor = true;
            // 
            // rbtbancos
            // 
            this.rbtbancos.AutoSize = true;
            this.rbtbancos.Location = new System.Drawing.Point(157, 201);
            this.rbtbancos.Name = "rbtbancos";
            this.rbtbancos.Size = new System.Drawing.Size(95, 17);
            this.rbtbancos.TabIndex = 21;
            this.rbtbancos.TabStop = true;
            this.rbtbancos.Text = "Cargar Bancos";
            this.rbtbancos.UseVisualStyleBackColor = true;
            // 
            // rbtcxc
            // 
            this.rbtcxc.AutoSize = true;
            this.rbtcxc.Location = new System.Drawing.Point(306, 201);
            this.rbtcxc.Name = "rbtcxc";
            this.rbtcxc.Size = new System.Drawing.Size(137, 17);
            this.rbtcxc.TabIndex = 22;
            this.rbtcxc.TabStop = true;
            this.rbtcxc.Text = "Cargar Antiguedad CXC";
            this.rbtcxc.UseVisualStyleBackColor = true;
            // 
            // btncargararchivoca
            // 
            this.btncargararchivoca.Location = new System.Drawing.Point(161, 231);
            this.btncargararchivoca.Name = "btncargararchivoca";
            this.btncargararchivoca.Size = new System.Drawing.Size(151, 63);
            this.btncargararchivoca.TabIndex = 23;
            this.btncargararchivoca.Text = "Cargar Archivo";
            this.btncargararchivoca.UseVisualStyleBackColor = true;
            this.btncargararchivoca.Click += new System.EventHandler(this.btncargararchivoca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Escoja en que Tabla Cargar el Archivo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(20, 19);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.Visible = false;
            // 
            // frmcargararchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 302);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncargararchivoca);
            this.Controls.Add(this.rbtcxc);
            this.Controls.Add(this.rbtbancos);
            this.Controls.Add(this.rbtimpuesto);
            this.Controls.Add(this.rbtcinventario);
            this.Controls.Add(this.rbttipocambio);
            this.Controls.Add(this.rbtinit);
            this.Controls.Add(this.btnexaminarca);
            this.Controls.Add(this.tbca);
            this.Controls.Add(this.label1);
            this.Name = "frmcargararchivos";
            this.Text = "Cargar Archivos";
            this.Load += new System.EventHandler(this.frmcargararchivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbca;
        private System.Windows.Forms.Button btnexaminarca;
        private System.Windows.Forms.RadioButton rbtinit;
        private System.Windows.Forms.RadioButton rbttipocambio;
        private System.Windows.Forms.RadioButton rbtcinventario;
        private System.Windows.Forms.RadioButton rbtimpuesto;
        private System.Windows.Forms.RadioButton rbtbancos;
        private System.Windows.Forms.RadioButton rbtcxc;
        private System.Windows.Forms.Button btncargararchivoca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}