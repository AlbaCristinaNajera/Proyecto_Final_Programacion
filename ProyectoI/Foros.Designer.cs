namespace ProyectoI
{
    partial class Foros
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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNombreForo = new System.Windows.Forms.ComboBox();
            this.textBoxRespuesta = new System.Windows.Forms.TextBox();
            this.ButtonEnviar = new System.Windows.Forms.Button();
            this.comboBoxPregunta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxRespuestas = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Foros";
            // 
            // comboBoxNombreForo
            // 
            this.comboBoxNombreForo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNombreForo.FormattingEnabled = true;
            this.comboBoxNombreForo.Location = new System.Drawing.Point(29, 71);
            this.comboBoxNombreForo.Name = "comboBoxNombreForo";
            this.comboBoxNombreForo.Size = new System.Drawing.Size(114, 24);
            this.comboBoxNombreForo.TabIndex = 7;
            this.comboBoxNombreForo.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreForo_SelectedIndexChanged);
            // 
            // textBoxRespuesta
            // 
            this.textBoxRespuesta.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRespuesta.Location = new System.Drawing.Point(29, 141);
            this.textBoxRespuesta.Multiline = true;
            this.textBoxRespuesta.Name = "textBoxRespuesta";
            this.textBoxRespuesta.Size = new System.Drawing.Size(305, 92);
            this.textBoxRespuesta.TabIndex = 9;
            // 
            // ButtonEnviar
            // 
            this.ButtonEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ButtonEnviar.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEnviar.ForeColor = System.Drawing.Color.White;
            this.ButtonEnviar.Location = new System.Drawing.Point(131, 254);
            this.ButtonEnviar.Name = "ButtonEnviar";
            this.ButtonEnviar.Size = new System.Drawing.Size(95, 51);
            this.ButtonEnviar.TabIndex = 10;
            this.ButtonEnviar.Text = "Enviar ";
            this.ButtonEnviar.UseVisualStyleBackColor = false;
            this.ButtonEnviar.Click += new System.EventHandler(this.ButtonEnviar_Click);
            // 
            // comboBoxPregunta
            // 
            this.comboBoxPregunta.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPregunta.FormattingEnabled = true;
            this.comboBoxPregunta.Location = new System.Drawing.Point(201, 71);
            this.comboBoxPregunta.Name = "comboBoxPregunta";
            this.comboBoxPregunta.Size = new System.Drawing.Size(150, 24);
            this.comboBoxPregunta.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Selelccionar Pregunta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tu respuesta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre Foro:";
            // 
            // listBoxRespuestas
            // 
            this.listBoxRespuestas.FormattingEnabled = true;
            this.listBoxRespuestas.Location = new System.Drawing.Point(399, 81);
            this.listBoxRespuestas.Name = "listBoxRespuestas";
            this.listBoxRespuestas.Size = new System.Drawing.Size(368, 238);
            this.listBoxRespuestas.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Respuestas del Foro:";
            // 
            // Foros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(779, 414);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxRespuestas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPregunta);
            this.Controls.Add(this.ButtonEnviar);
            this.Controls.Add(this.textBoxRespuesta);
            this.Controls.Add(this.comboBoxNombreForo);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Foros";
            this.Text = "Foros";
            this.Load += new System.EventHandler(this.Foros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNombreForo;
        private System.Windows.Forms.TextBox textBoxRespuesta;
        private System.Windows.Forms.Button ButtonEnviar;
        private System.Windows.Forms.ComboBox comboBoxPregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxRespuestas;
        private System.Windows.Forms.Label label5;
    }
}