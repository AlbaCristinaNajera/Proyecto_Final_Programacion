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
            this.comboBoxForo = new System.Windows.Forms.ComboBox();
            this.textBoxMensaje = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.listBoxMensajes = new System.Windows.Forms.ListBox();
            this.comboBoxPregunta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Foro";
            // 
            // comboBoxForo
            // 
            this.comboBoxForo.FormattingEnabled = true;
            this.comboBoxForo.Location = new System.Drawing.Point(12, 57);
            this.comboBoxForo.Name = "comboBoxForo";
            this.comboBoxForo.Size = new System.Drawing.Size(84, 21);
            this.comboBoxForo.TabIndex = 7;
            // 
            // textBoxMensaje
            // 
            this.textBoxMensaje.Location = new System.Drawing.Point(12, 164);
            this.textBoxMensaje.Name = "textBoxMensaje";
            this.textBoxMensaje.Size = new System.Drawing.Size(186, 20);
            this.textBoxMensaje.TabIndex = 9;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(63, 220);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(57, 39);
            this.buttonEnviar.TabIndex = 10;
            this.buttonEnviar.Text = "Enviar ";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            // 
            // listBoxMensajes
            // 
            this.listBoxMensajes.FormattingEnabled = true;
            this.listBoxMensajes.Location = new System.Drawing.Point(269, 22);
            this.listBoxMensajes.Name = "listBoxMensajes";
            this.listBoxMensajes.Size = new System.Drawing.Size(260, 290);
            this.listBoxMensajes.TabIndex = 11;
            // 
            // comboBoxPregunta
            // 
            this.comboBoxPregunta.FormattingEnabled = true;
            this.comboBoxPregunta.Location = new System.Drawing.Point(12, 106);
            this.comboBoxPregunta.Name = "comboBoxPregunta";
            this.comboBoxPregunta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPregunta.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Selelccionar Pregunta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Respuesta Pregunta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre Foro:";
            // 
            // Foros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(610, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPregunta);
            this.Controls.Add(this.listBoxMensajes);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.textBoxMensaje);
            this.Controls.Add(this.comboBoxForo);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Foros";
            this.Text = "Foros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxForo;
        private System.Windows.Forms.TextBox textBoxMensaje;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.ListBox listBoxMensajes;
        private System.Windows.Forms.ComboBox comboBoxPregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}