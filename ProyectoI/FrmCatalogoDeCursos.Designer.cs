namespace ProyectoI
{
    partial class FrmCatalogoDeCursos
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
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            this.btnRegistrarseCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.AllowUserToAddRows = false;
            this.dataGridViewCursos.AllowUserToDeleteRows = false;
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Location = new System.Drawing.Point(3, 119);
            this.dataGridViewCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.ReadOnly = true;
            this.dataGridViewCursos.RowHeadersWidth = 51;
            this.dataGridViewCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCursos.Size = new System.Drawing.Size(1063, 222);
            this.dataGridViewCursos.TabIndex = 0;
            // 
            // btnRegistrarseCurso
            // 
            this.btnRegistrarseCurso.Location = new System.Drawing.Point(460, 379);
            this.btnRegistrarseCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarseCurso.Name = "btnRegistrarseCurso";
            this.btnRegistrarseCurso.Size = new System.Drawing.Size(160, 47);
            this.btnRegistrarseCurso.TabIndex = 1;
            this.btnRegistrarseCurso.Text = "Asignar";
            this.btnRegistrarseCurso.UseVisualStyleBackColor = true;
            this.btnRegistrarseCurso.Click += new System.EventHandler(this.btnRegistrarseCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cursos";
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarseCurso);
            this.Controls.Add(this.dataGridViewCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCursos;
        private System.Windows.Forms.Button btnRegistrarseCurso;
        private System.Windows.Forms.Label label1;
    }
}