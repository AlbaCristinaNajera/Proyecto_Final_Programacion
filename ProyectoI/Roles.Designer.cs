namespace ProyectoI
{
    partial class Roles
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
            this.btnProfesor = new System.Windows.Forms.Button();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Qué Rol desempeña?";
            // 
            // btnProfesor
            // 
            this.btnProfesor.BackColor = System.Drawing.Color.Yellow;
            this.btnProfesor.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesor.ForeColor = System.Drawing.Color.Black;
            this.btnProfesor.Location = new System.Drawing.Point(286, 164);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Size = new System.Drawing.Size(117, 64);
            this.btnProfesor.TabIndex = 1;
            this.btnProfesor.Text = "Profesor";
            this.btnProfesor.UseVisualStyleBackColor = false;
            this.btnProfesor.Click += new System.EventHandler(this.btnProfesor_Click);
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEstudiante.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiante.Location = new System.Drawing.Point(435, 164);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(108, 64);
            this.btnEstudiante.TabIndex = 2;
            this.btnEstudiante.Text = "Estudiante ";
            this.btnEstudiante.UseVisualStyleBackColor = false;
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEstudiante);
            this.Controls.Add(this.btnProfesor);
            this.Controls.Add(this.label1);
            this.Name = "Roles";
            this.Text = "Roles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProfesor;
        private System.Windows.Forms.Button btnEstudiante;
    }
}