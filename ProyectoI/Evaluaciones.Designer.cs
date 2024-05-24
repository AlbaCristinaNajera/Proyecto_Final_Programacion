namespace ProyectoI
{
    partial class Evaluaciones
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
            this.comboBoxCursos = new System.Windows.Forms.ComboBox();
            this.textBoxPuntos = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxIngresarPreguntas = new System.Windows.Forms.TextBox();
            this.buttonGuardarpregunta = new System.Windows.Forms.Button();
            this.buttonEliminarpregunta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxPreguntas = new System.Windows.Forms.ListBox();
            this.comboBoxEvaluaciones = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxCursos
            // 
            this.comboBoxCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBoxCursos.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxCursos.FormattingEnabled = true;
            this.comboBoxCursos.Location = new System.Drawing.Point(257, 48);
            this.comboBoxCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCursos.Name = "comboBoxCursos";
            this.comboBoxCursos.Size = new System.Drawing.Size(245, 24);
            this.comboBoxCursos.TabIndex = 2;
            this.comboBoxCursos.SelectedIndexChanged += new System.EventHandler(this.comboBoxCursos_SelectedIndexChanged_1);
            // 
            // textBoxPuntos
            // 
            this.textBoxPuntos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBoxPuntos.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxPuntos.Location = new System.Drawing.Point(257, 80);
            this.textBoxPuntos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPuntos.Name = "textBoxPuntos";
            this.textBoxPuntos.Size = new System.Drawing.Size(245, 22);
            this.textBoxPuntos.TabIndex = 3;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGuardar.Location = new System.Drawing.Point(309, 140);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(124, 32);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxIngresarPreguntas
            // 
            this.textBoxIngresarPreguntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBoxIngresarPreguntas.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxIngresarPreguntas.Location = new System.Drawing.Point(477, 277);
            this.textBoxIngresarPreguntas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIngresarPreguntas.Name = "textBoxIngresarPreguntas";
            this.textBoxIngresarPreguntas.Size = new System.Drawing.Size(245, 22);
            this.textBoxIngresarPreguntas.TabIndex = 5;
            // 
            // buttonGuardarpregunta
            // 
            this.buttonGuardarpregunta.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGuardarpregunta.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.buttonGuardarpregunta.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGuardarpregunta.Location = new System.Drawing.Point(444, 345);
            this.buttonGuardarpregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardarpregunta.Name = "buttonGuardarpregunta";
            this.buttonGuardarpregunta.Size = new System.Drawing.Size(125, 34);
            this.buttonGuardarpregunta.TabIndex = 6;
            this.buttonGuardarpregunta.Text = "Guardar";
            this.buttonGuardarpregunta.UseVisualStyleBackColor = false;
            this.buttonGuardarpregunta.Click += new System.EventHandler(this.buttonGuardarpregunta_Click_1);
            // 
            // buttonEliminarpregunta
            // 
            this.buttonEliminarpregunta.BackColor = System.Drawing.Color.Red;
            this.buttonEliminarpregunta.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.buttonEliminarpregunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminarpregunta.Location = new System.Drawing.Point(621, 345);
            this.buttonEliminarpregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminarpregunta.Name = "buttonEliminarpregunta";
            this.buttonEliminarpregunta.Size = new System.Drawing.Size(117, 34);
            this.buttonEliminarpregunta.TabIndex = 7;
            this.buttonEliminarpregunta.Text = "Eliminar";
            this.buttonEliminarpregunta.UseVisualStyleBackColor = false;
            this.buttonEliminarpregunta.Click += new System.EventHandler(this.buttonEliminarpregunta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Evaluación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(48, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Preguntas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cursos";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBoxFecha.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxFecha.Location = new System.Drawing.Point(257, 114);
            this.textBoxFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(245, 22);
            this.textBoxFecha.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(154, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Puntos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(154, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(483, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ingresar Preguntas";
            // 
            // listBoxPreguntas
            // 
            this.listBoxPreguntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.listBoxPreguntas.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxPreguntas.FormattingEnabled = true;
            this.listBoxPreguntas.ItemHeight = 16;
            this.listBoxPreguntas.Location = new System.Drawing.Point(53, 222);
            this.listBoxPreguntas.Name = "listBoxPreguntas";
            this.listBoxPreguntas.Size = new System.Drawing.Size(309, 116);
            this.listBoxPreguntas.TabIndex = 18;
            // 
            // comboBoxEvaluaciones
            // 
            this.comboBoxEvaluaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBoxEvaluaciones.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxEvaluaciones.FormattingEnabled = true;
            this.comboBoxEvaluaciones.Location = new System.Drawing.Point(477, 192);
            this.comboBoxEvaluaciones.Name = "comboBoxEvaluaciones";
            this.comboBoxEvaluaciones.Size = new System.Drawing.Size(207, 24);
            this.comboBoxEvaluaciones.TabIndex = 19;
            // 
            // Evaluaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxEvaluaciones);
            this.Controls.Add(this.listBoxPreguntas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEliminarpregunta);
            this.Controls.Add(this.buttonGuardarpregunta);
            this.Controls.Add(this.textBoxIngresarPreguntas);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxPuntos);
            this.Controls.Add(this.comboBoxCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Evaluaciones";
            this.Text = "Evaluaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxCursos;
        private System.Windows.Forms.TextBox textBoxPuntos;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxIngresarPreguntas;
        private System.Windows.Forms.Button buttonGuardarpregunta;
        private System.Windows.Forms.Button buttonEliminarpregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxPreguntas;
        private System.Windows.Forms.ComboBox comboBoxEvaluaciones;
    }
}