namespace ProyectoI
{
    partial class Catalogo
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
            this.txtIdEstudiante = new System.Windows.Forms.TextBox();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.AllowUserToAddRows = false;
            this.dataGridViewCursos.AllowUserToDeleteRows = false;
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Location = new System.Drawing.Point(2, 3);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.ReadOnly = true;
            this.dataGridViewCursos.Size = new System.Drawing.Size(795, 195);
            this.dataGridViewCursos.TabIndex = 0;
            // 
            // btnRegistrarseCurso
            // 
            this.btnRegistrarseCurso.Location = new System.Drawing.Point(338, 328);
            this.btnRegistrarseCurso.Name = "btnRegistrarseCurso";
            this.btnRegistrarseCurso.Size = new System.Drawing.Size(120, 38);
            this.btnRegistrarseCurso.TabIndex = 1;
            this.btnRegistrarseCurso.Text = "Asignar";
            this.btnRegistrarseCurso.UseVisualStyleBackColor = true;
            // 
            // txtIdEstudiante
            // 
            this.txtIdEstudiante.Location = new System.Drawing.Point(113, 257);
            this.txtIdEstudiante.Name = "txtIdEstudiante";
            this.txtIdEstudiante.Size = new System.Drawing.Size(100, 20);
            this.txtIdEstudiante.TabIndex = 2;
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Location = new System.Drawing.Point(578, 245);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(100, 20);
            this.txtIdCurso.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Curso";
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdCurso);
            this.Controls.Add(this.txtIdEstudiante);
            this.Controls.Add(this.btnRegistrarseCurso);
            this.Controls.Add(this.dataGridViewCursos);
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
        private System.Windows.Forms.TextBox txtIdEstudiante;
        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}