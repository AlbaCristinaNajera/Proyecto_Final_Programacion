namespace ProyectoI
{
    partial class FRMForoProfesor
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
            this.comboBoxPregunta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonCrearForo = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxMostrarRespuestas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar Pregunta para ver las respuestas:\r\n";
            // 
            // comboBoxPregunta
            // 
            this.comboBoxPregunta.FormattingEnabled = true;
            this.comboBoxPregunta.Location = new System.Drawing.Point(89, 239);
            this.comboBoxPregunta.Name = "comboBoxPregunta";
            this.comboBoxPregunta.Size = new System.Drawing.Size(221, 21);
            this.comboBoxPregunta.TabIndex = 2;
            this.comboBoxPregunta.SelectedIndexChanged += new System.EventHandler(this.comboBoxPregunta_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Foro:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(390, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "FOROS";
            // 
            // ButtonCrearForo
            // 
            this.ButtonCrearForo.BackColor = System.Drawing.Color.Blue;
            this.ButtonCrearForo.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCrearForo.ForeColor = System.Drawing.Color.White;
            this.ButtonCrearForo.Location = new System.Drawing.Point(588, 92);
            this.ButtonCrearForo.Name = "ButtonCrearForo";
            this.ButtonCrearForo.Size = new System.Drawing.Size(106, 40);
            this.ButtonCrearForo.TabIndex = 10;
            this.ButtonCrearForo.Text = "Crear Foro";
            this.ButtonCrearForo.UseVisualStyleBackColor = false;
            this.ButtonCrearForo.Click += new System.EventHandler(this.ButtonCrearForo_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(76, 130);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(219, 20);
            this.txtDescripcion.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contenido:";
            // 
            // listBoxMostrarRespuestas
            // 
            this.listBoxMostrarRespuestas.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMostrarRespuestas.FormattingEnabled = true;
            this.listBoxMostrarRespuestas.ItemHeight = 15;
            this.listBoxMostrarRespuestas.Location = new System.Drawing.Point(89, 278);
            this.listBoxMostrarRespuestas.Name = "listBoxMostrarRespuestas";
            this.listBoxMostrarRespuestas.Size = new System.Drawing.Size(605, 154);
            this.listBoxMostrarRespuestas.TabIndex = 13;
            this.listBoxMostrarRespuestas.SelectedIndexChanged += new System.EventHandler(this.listBoxMostrarRespuestas_SelectedIndexChanged);
            // 
            // FRMForoProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxMostrarRespuestas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.ButtonCrearForo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPregunta);
            this.Controls.Add(this.label1);
            this.Name = "FRMForoProfesor";
            this.Text = "FRMForoProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPregunta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonCrearForo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxMostrarRespuestas;
    }
}