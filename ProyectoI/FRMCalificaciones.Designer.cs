namespace ProyectoI
{
    partial class FRMCalificaciones
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
            this.comboBoxEstudiante = new System.Windows.Forms.ComboBox();
            this.txtPunteo = new System.Windows.Forms.TextBox();
            this.btnGuardarCalificacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxRetroalimentacion = new System.Windows.Forms.RichTextBox();
            this.dataGridViewRespuestasEvaluacion = new System.Windows.Forms.DataGridView();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.comboBoxEvaluaciones = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRespuestasEvaluacion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxEstudiante
            // 
            this.comboBoxEstudiante.FormattingEnabled = true;
            this.comboBoxEstudiante.Location = new System.Drawing.Point(27, 67);
            this.comboBoxEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEstudiante.Name = "comboBoxEstudiante";
            this.comboBoxEstudiante.Size = new System.Drawing.Size(150, 21);
            this.comboBoxEstudiante.TabIndex = 0;
            this.comboBoxEstudiante.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstudiante_SelectedIndexChanged);
            // 
            // txtPunteo
            // 
            this.txtPunteo.Location = new System.Drawing.Point(22, 296);
            this.txtPunteo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPunteo.Name = "txtPunteo";
            this.txtPunteo.Size = new System.Drawing.Size(155, 20);
            this.txtPunteo.TabIndex = 1;
            // 
            // btnGuardarCalificacion
            // 
            this.btnGuardarCalificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGuardarCalificacion.FlatAppearance.BorderSize = 0;
            this.btnGuardarCalificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCalificacion.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCalificacion.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCalificacion.Location = new System.Drawing.Point(317, 391);
            this.btnGuardarCalificacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCalificacion.Name = "btnGuardarCalificacion";
            this.btnGuardarCalificacion.Size = new System.Drawing.Size(113, 44);
            this.btnGuardarCalificacion.TabIndex = 3;
            this.btnGuardarCalificacion.Text = "Guardar";
            this.btnGuardarCalificacion.UseVisualStyleBackColor = false;
            this.btnGuardarCalificacion.Click += new System.EventHandler(this.btnGuardarCalificacion_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Punteo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de estudiantes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Retroalimentacion";
            // 
            // richTextBoxRetroalimentacion
            // 
            this.richTextBoxRetroalimentacion.Location = new System.Drawing.Point(337, 295);
            this.richTextBoxRetroalimentacion.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxRetroalimentacion.Name = "richTextBoxRetroalimentacion";
            this.richTextBoxRetroalimentacion.Size = new System.Drawing.Size(399, 72);
            this.richTextBoxRetroalimentacion.TabIndex = 7;
            this.richTextBoxRetroalimentacion.Text = "";
            // 
            // dataGridViewRespuestasEvaluacion
            // 
            this.dataGridViewRespuestasEvaluacion.AllowUserToAddRows = false;
            this.dataGridViewRespuestasEvaluacion.AllowUserToDeleteRows = false;
            this.dataGridViewRespuestasEvaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRespuestasEvaluacion.Location = new System.Drawing.Point(78, 124);
            this.dataGridViewRespuestasEvaluacion.Name = "dataGridViewRespuestasEvaluacion";
            this.dataGridViewRespuestasEvaluacion.ReadOnly = true;
            this.dataGridViewRespuestasEvaluacion.Size = new System.Drawing.Size(557, 110);
            this.dataGridViewRespuestasEvaluacion.TabIndex = 8;
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(272, 67);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(149, 21);
            this.comboBoxCurso.TabIndex = 9;
            this.comboBoxCurso.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurso_SelectedIndexChanged);
            // 
            // comboBoxEvaluaciones
            // 
            this.comboBoxEvaluaciones.FormattingEnabled = true;
            this.comboBoxEvaluaciones.Location = new System.Drawing.Point(514, 67);
            this.comboBoxEvaluaciones.Name = "comboBoxEvaluaciones";
            this.comboBoxEvaluaciones.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEvaluaciones.TabIndex = 10;
            this.comboBoxEvaluaciones.SelectedIndexChanged += new System.EventHandler(this.comboBoxEvaluaciones_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lista de Cursos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lista de Evaluaciones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 35);
            this.panel1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(199, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(365, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Asignar Calificaciones";
            // 
            // FRMCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(747, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxEvaluaciones);
            this.Controls.Add(this.comboBoxCurso);
            this.Controls.Add(this.dataGridViewRespuestasEvaluacion);
            this.Controls.Add(this.richTextBoxRetroalimentacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarCalificacion);
            this.Controls.Add(this.txtPunteo);
            this.Controls.Add(this.comboBoxEstudiante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMCalificaciones";
            this.Text = "Calificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRespuestasEvaluacion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEstudiante;
        private System.Windows.Forms.TextBox txtPunteo;
        private System.Windows.Forms.Button btnGuardarCalificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxRetroalimentacion;
        private System.Windows.Forms.DataGridView dataGridViewRespuestasEvaluacion;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.ComboBox comboBoxEvaluaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}