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
            this.Progreso = new System.Windows.Forms.Label();
            this.ComBoxCursos = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(221, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seguimiento del Progreso en los Cursos";
            // 
            // LblDetalles
            // 
            this.LblDetalles.AutoSize = true;
            this.LblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalles.Location = new System.Drawing.Point(20, 141);
            this.LblDetalles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDetalles.Name = "LblDetalles";
            this.LblDetalles.Size = new System.Drawing.Size(123, 17);
            this.LblDetalles.TabIndex = 4;
            this.LblDetalles.Text = "Detalles del Curso";
            // 
            // Progreso
            // 
            this.Progreso.AutoSize = true;
            this.Progreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progreso.Location = new System.Drawing.Point(22, 169);
            this.Progreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Progreso.Name = "Progreso";
            this.Progreso.Size = new System.Drawing.Size(70, 17);
            this.Progreso.TabIndex = 6;
            this.Progreso.Text = "Progreso:";
            // 
            // ComBoxCursos
            // 
            this.ComBoxCursos.BackColor = System.Drawing.Color.White;
            this.ComBoxCursos.FormattingEnabled = true;
            this.ComBoxCursos.Location = new System.Drawing.Point(23, 94);
            this.ComBoxCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComBoxCursos.Name = "ComBoxCursos";
            this.ComBoxCursos.Size = new System.Drawing.Size(143, 21);
            this.ComBoxCursos.TabIndex = 10;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(11, 197);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(760, 140);
            this.dataGridView.TabIndex = 11;
            // 
            // Seguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(782, 390);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ComBoxCursos);
            this.Controls.Add(this.Progreso);
            this.Controls.Add(this.LblDetalles);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Seguimiento";
            this.Text = "Seguimiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDetalles;
       
        private System.Windows.Forms.Label Progreso;
        private System.Windows.Forms.ComboBox ComBoxCursos;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}