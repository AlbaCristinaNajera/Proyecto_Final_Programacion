namespace ProyectoI
{
    partial class FRMGruposEstudiantes
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
            this.listViewGrupos = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxNombresUsuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listViewGrupos
            // 
            this.listViewGrupos.HideSelection = false;
            this.listViewGrupos.Location = new System.Drawing.Point(211, 105);
            this.listViewGrupos.Name = "listViewGrupos";
            this.listViewGrupos.Size = new System.Drawing.Size(328, 135);
            this.listViewGrupos.TabIndex = 0;
            this.listViewGrupos.UseCompatibleStateImageBehavior = false;
            this.listViewGrupos.SelectedIndexChanged += new System.EventHandler(this.listViewGrupos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grupos ";
            // 
            // listBoxNombresUsuarios
            // 
            this.listBoxNombresUsuarios.FormattingEnabled = true;
            this.listBoxNombresUsuarios.Location = new System.Drawing.Point(312, 279);
            this.listBoxNombresUsuarios.Name = "listBoxNombresUsuarios";
            this.listBoxNombresUsuarios.Size = new System.Drawing.Size(120, 95);
            this.listBoxNombresUsuarios.TabIndex = 2;
            // 
            // FRMGruposEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxNombresUsuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewGrupos);
            this.Name = "FRMGruposEstudiantes";
            this.Text = "FRMGruposEstudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewGrupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxNombresUsuarios;
    }
}