namespace Parcial1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbTiposPersonal = new System.Windows.Forms.ComboBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.AltaPersonal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTiposPersonal
            // 
            this.cbTiposPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTiposPersonal.FormattingEnabled = true;
            this.cbTiposPersonal.Items.AddRange(new object[] {
            "Auxiliar",
            "Modelo",
            "Publicitario",
            "Presentador"});
            this.cbTiposPersonal.Location = new System.Drawing.Point(479, 177);
            this.cbTiposPersonal.Name = "cbTiposPersonal";
            this.cbTiposPersonal.Size = new System.Drawing.Size(227, 28);
            this.cbTiposPersonal.TabIndex = 0;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(479, 232);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(227, 26);
            this.txtHoras.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el tipo de empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de horas a trabajar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Indique el nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(479, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // AltaPersonal
            // 
            this.AltaPersonal.Location = new System.Drawing.Point(479, 311);
            this.AltaPersonal.Name = "AltaPersonal";
            this.AltaPersonal.Size = new System.Drawing.Size(101, 124);
            this.AltaPersonal.TabIndex = 4;
            this.AltaPersonal.Text = "Alta de personal";
            this.AltaPersonal.UseVisualStyleBackColor = true;
            this.AltaPersonal.Click += new System.EventHandler(this.AltaPersonal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(864, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(350, 405);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 583);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AltaPersonal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.cbTiposPersonal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTiposPersonal;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button AltaPersonal;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

