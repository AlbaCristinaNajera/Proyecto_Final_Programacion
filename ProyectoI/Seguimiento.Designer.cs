namespace ProyectoI
{
    partial class Seguimiento
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
            this.LblDetalles = new System.Windows.Forms.Label();
            this.Curso = new System.Windows.Forms.Label();
            this.Progreso = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LblCurso = new System.Windows.Forms.Label();
            this.LblProgreso = new System.Windows.Forms.Label();
            this.ComBoxCursos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(173, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seguimiento del Progreso en los Cursos";
            // 
            // LblDetalles
            // 
            this.LblDetalles.AutoSize = true;
            this.LblDetalles.Location = new System.Drawing.Point(27, 185);
            this.LblDetalles.Name = "LblDetalles";
            this.LblDetalles.Size = new System.Drawing.Size(120, 16);
            this.LblDetalles.TabIndex = 4;
            this.LblDetalles.Text = "Detalles del Curso:";
            // 
            // Curso
            // 
            this.Curso.AutoSize = true;
            this.Curso.Location = new System.Drawing.Point(27, 224);
            this.Curso.Name = "Curso";
            this.Curso.Size = new System.Drawing.Size(45, 16);
            this.Curso.TabIndex = 5;
            this.Curso.Text = "Curso:";
            // 
            // Progreso
            // 
            this.Progreso.AutoSize = true;
            this.Progreso.Location = new System.Drawing.Point(31, 253);
            this.Progreso.Name = "Progreso";
            this.Progreso.Size = new System.Drawing.Size(66, 16);
            this.Progreso.TabIndex = 6;
            this.Progreso.Text = "Progreso:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(33, 292);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(489, 129);
            this.progressBar1.TabIndex = 7;
            
            // 
            // LblCurso
            // 
            this.LblCurso.AutoSize = true;
            this.LblCurso.Location = new System.Drawing.Point(79, 224);
            this.LblCurso.Name = "LblCurso";
            this.LblCurso.Size = new System.Drawing.Size(0, 16);
            this.LblCurso.TabIndex = 8;
            // 
            // LblProgreso
            // 
            this.LblProgreso.AutoSize = true;
            this.LblProgreso.Location = new System.Drawing.Point(104, 253);
            this.LblProgreso.Name = "LblProgreso";
            this.LblProgreso.Size = new System.Drawing.Size(0, 16);
            this.LblProgreso.TabIndex = 9;
            // 
            // ComBoxCursos
            // 
            this.ComBoxCursos.FormattingEnabled = true;
            this.ComBoxCursos.Location = new System.Drawing.Point(30, 102);
            this.ComBoxCursos.Name = "ComBoxCursos";
            this.ComBoxCursos.Size = new System.Drawing.Size(189, 24);
            this.ComBoxCursos.TabIndex = 10;
            
            // 
            // Seguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComBoxCursos);
            this.Controls.Add(this.LblProgreso);
            this.Controls.Add(this.LblCurso);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Progreso);
            this.Controls.Add(this.Curso);
            this.Controls.Add(this.LblDetalles);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seguimiento";
            this.Text = "Seguimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDetalles;
        private System.Windows.Forms.Label Curso;
        private System.Windows.Forms.Label Progreso;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LblCurso;
        private System.Windows.Forms.Label LblProgreso;
        private System.Windows.Forms.ComboBox ComBoxCursos;
    }
}