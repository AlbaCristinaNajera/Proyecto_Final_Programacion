namespace ProyectoI.Clases
{
    partial class FormPreguntasEstudiante
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
            this.flowLayoutPanelPreguntas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.comboBoxEvaluaciones = new System.Windows.Forms.ComboBox();
            this.btnTerminarEvaluacion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelPreguntas
            // 
            this.flowLayoutPanelPreguntas.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelPreguntas.Location = new System.Drawing.Point(187, 103);
            this.flowLayoutPanelPreguntas.Name = "flowLayoutPanelPreguntas";
            this.flowLayoutPanelPreguntas.Size = new System.Drawing.Size(338, 171);
            this.flowLayoutPanelPreguntas.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Preguntas";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(450, 280);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(98, 30);
            this.btnSiguiente.TabIndex = 16;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // comboBoxEvaluaciones
            // 
            this.comboBoxEvaluaciones.FormattingEnabled = true;
            this.comboBoxEvaluaciones.Location = new System.Drawing.Point(12, 70);
            this.comboBoxEvaluaciones.Name = "comboBoxEvaluaciones";
            this.comboBoxEvaluaciones.Size = new System.Drawing.Size(131, 21);
            this.comboBoxEvaluaciones.TabIndex = 17;
            this.comboBoxEvaluaciones.SelectedIndexChanged += new System.EventHandler(this.comboBoxEvaluaciones_SelectedIndexChanged);
            // 
            // btnTerminarEvaluacion
            // 
            this.btnTerminarEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTerminarEvaluacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerminarEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminarEvaluacion.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnTerminarEvaluacion.Location = new System.Drawing.Point(582, 347);
            this.btnTerminarEvaluacion.Name = "btnTerminarEvaluacion";
            this.btnTerminarEvaluacion.Size = new System.Drawing.Size(120, 44);
            this.btnTerminarEvaluacion.TabIndex = 18;
            this.btnTerminarEvaluacion.Text = "Terminar Evaluación";
            this.btnTerminarEvaluacion.UseVisualStyleBackColor = false;
            this.btnTerminarEvaluacion.Click += new System.EventHandler(this.btnTerminarEvaluacion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 33);
            this.panel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(141, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Evaluaciones y pruebas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Selecciona la Evaluación:";
            // 
            // FormPreguntasEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTerminarEvaluacion);
            this.Controls.Add(this.comboBoxEvaluaciones);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanelPreguntas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPreguntasEstudiante";
            this.Text = "FormPreguntasEstudiante";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel flowLayoutPanelPreguntas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ComboBox comboBoxEvaluaciones;
        private System.Windows.Forms.Button btnTerminarEvaluacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}