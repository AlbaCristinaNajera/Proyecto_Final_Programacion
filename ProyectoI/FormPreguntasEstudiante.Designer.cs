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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelPreguntas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.comboBoxEvaluaciones = new System.Windows.Forms.ComboBox();
            this.btnTerminarEvaluacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Evaluaciones y Pruebas";
            // 
            // flowLayoutPanelPreguntas
            // 
            this.flowLayoutPanelPreguntas.Location = new System.Drawing.Point(118, 87);
            this.flowLayoutPanelPreguntas.Name = "flowLayoutPanelPreguntas";
            this.flowLayoutPanelPreguntas.Size = new System.Drawing.Size(338, 171);
            this.flowLayoutPanelPreguntas.TabIndex = 14;
            //this.flowLayoutPanelPreguntas.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelPreguntas_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Preguntas";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(381, 264);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 16;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // comboBoxEvaluaciones
            // 
            this.comboBoxEvaluaciones.FormattingEnabled = true;
            this.comboBoxEvaluaciones.Location = new System.Drawing.Point(12, 32);
            this.comboBoxEvaluaciones.Name = "comboBoxEvaluaciones";
            this.comboBoxEvaluaciones.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEvaluaciones.TabIndex = 17;
            this.comboBoxEvaluaciones.SelectedIndexChanged += new System.EventHandler(this.comboBoxEvaluaciones_SelectedIndexChanged);
            // 
            // btnTerminarEvaluacion
            // 
            this.btnTerminarEvaluacion.Location = new System.Drawing.Point(466, 313);
            this.btnTerminarEvaluacion.Name = "btnTerminarEvaluacion";
            this.btnTerminarEvaluacion.Size = new System.Drawing.Size(116, 30);
            this.btnTerminarEvaluacion.TabIndex = 18;
            this.btnTerminarEvaluacion.Text = "Terminar Evaluación";
            this.btnTerminarEvaluacion.UseVisualStyleBackColor = true;
            this.btnTerminarEvaluacion.Click += new System.EventHandler(this.btnTerminarEvaluacion_Click);
            // 
            // FormPreguntasEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnTerminarEvaluacion);
            this.Controls.Add(this.comboBoxEvaluaciones);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanelPreguntas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPreguntasEstudiante";
            this.Text = "FormPreguntasEstudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel flowLayoutPanelPreguntas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ComboBox comboBoxEvaluaciones;
        private System.Windows.Forms.Button btnTerminarEvaluacion;
    }
}