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
            this.buttonForo = new System.Windows.Forms.Button();
            this.textBoxMensaje = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.listBoxMensajes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Foro";
            // 
            // comboBoxForo
            // 
            this.comboBoxForo.FormattingEnabled = true;
            this.comboBoxForo.Location = new System.Drawing.Point(31, 74);
            this.comboBoxForo.Name = "comboBoxForo";
            this.comboBoxForo.Size = new System.Drawing.Size(84, 21);
            this.comboBoxForo.TabIndex = 7;
            // 
            // buttonForo
            // 
            this.buttonForo.Location = new System.Drawing.Point(31, 110);
            this.buttonForo.Name = "buttonForo";
            this.buttonForo.Size = new System.Drawing.Size(75, 28);
            this.buttonForo.TabIndex = 8;
            this.buttonForo.Text = "Nuevo Foro";
            this.buttonForo.UseVisualStyleBackColor = true;
            // 
            // textBoxMensaje
            // 
            this.textBoxMensaje.Location = new System.Drawing.Point(12, 155);
            this.textBoxMensaje.Name = "textBoxMensaje";
            this.textBoxMensaje.Size = new System.Drawing.Size(186, 20);
            this.textBoxMensaje.TabIndex = 9;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(43, 206);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(57, 39);
            this.buttonEnviar.TabIndex = 10;
            this.buttonEnviar.Text = "Enviar ";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            // 
            // listBoxMensajes
            // 
            this.listBoxMensajes.FormattingEnabled = true;
            this.listBoxMensajes.Location = new System.Drawing.Point(265, 74);
            this.listBoxMensajes.Name = "listBoxMensajes";
            this.listBoxMensajes.Size = new System.Drawing.Size(260, 173);
            this.listBoxMensajes.TabIndex = 11;
            // 
            // Foros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(610, 366);
            this.Controls.Add(this.listBoxMensajes);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.textBoxMensaje);
            this.Controls.Add(this.buttonForo);
            this.Controls.Add(this.comboBoxForo);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Foros";
            this.Text = "Foros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxForo;
        private System.Windows.Forms.Button buttonForo;
        private System.Windows.Forms.TextBox textBoxMensaje;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.ListBox listBoxMensajes;
    }
}