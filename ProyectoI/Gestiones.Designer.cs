namespace ProyectoI
{
    partial class Gestiones
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
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.txtGroupDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstEstudiantesDisponibles = new System.Windows.Forms.ListBox();
            this.lstEstudiantesAsignados = new System.Windows.Forms.ListBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.comboBoxGrupos = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGroupName
            // 
            this.txtGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.Location = new System.Drawing.Point(452, 46);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(268, 23);
            this.txtGroupName.TabIndex = 0;
            // 
            // txtGroupDescription
            // 
            this.txtGroupDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupDescription.Location = new System.Drawing.Point(452, 110);
            this.txtGroupDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGroupDescription.Name = "txtGroupDescription";
            this.txtGroupDescription.Size = new System.Drawing.Size(268, 132);
            this.txtGroupDescription.TabIndex = 1;
            this.txtGroupDescription.Text = "";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddGroup.Location = new System.Drawing.Point(548, 257);
            this.btnAddGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(113, 46);
            this.btnAddGroup.TabIndex = 2;
            this.btnAddGroup.Text = "Crear";
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion del grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selecciona un curso";
            // 
            // lstEstudiantesDisponibles
            // 
            this.lstEstudiantesDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEstudiantesDisponibles.FormattingEnabled = true;
            this.lstEstudiantesDisponibles.ItemHeight = 16;
            this.lstEstudiantesDisponibles.Location = new System.Drawing.Point(30, 101);
            this.lstEstudiantesDisponibles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstEstudiantesDisponibles.Name = "lstEstudiantesDisponibles";
            this.lstEstudiantesDisponibles.Size = new System.Drawing.Size(205, 116);
            this.lstEstudiantesDisponibles.TabIndex = 9;
            this.lstEstudiantesDisponibles.SelectedIndexChanged += new System.EventHandler(this.lstEstudiantesDisponibles_SelectedIndexChanged);
            // 
            // lstEstudiantesAsignados
            // 
            this.lstEstudiantesAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEstudiantesAsignados.FormattingEnabled = true;
            this.lstEstudiantesAsignados.ItemHeight = 16;
            this.lstEstudiantesAsignados.Location = new System.Drawing.Point(30, 236);
            this.lstEstudiantesAsignados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstEstudiantesAsignados.Name = "lstEstudiantesAsignados";
            this.lstEstudiantesAsignados.Size = new System.Drawing.Size(205, 116);
            this.lstEstudiantesAsignados.TabIndex = 10;
            this.lstEstudiantesAsignados.SelectedIndexChanged += new System.EventHandler(this.lstEstudiantesAsignados_SelectedIndexChanged);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.White;
            this.btnAsignar.Location = new System.Drawing.Point(30, 383);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(93, 35);
            this.btnAsignar.TabIndex = 11;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(140, 383);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 35);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // comboBoxGrupos
            // 
            this.comboBoxGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGrupos.FormattingEnabled = true;
            this.comboBoxGrupos.Location = new System.Drawing.Point(30, 58);
            this.comboBoxGrupos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxGrupos.Name = "comboBoxGrupos";
            this.comboBoxGrupos.Size = new System.Drawing.Size(205, 24);
            this.comboBoxGrupos.TabIndex = 13;
            this.comboBoxGrupos.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurso_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(88, 423);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 37);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar lista ";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Gestiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.comboBoxGrupos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lstEstudiantesAsignados);
            this.Controls.Add(this.lstEstudiantesDisponibles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.txtGroupDescription);
            this.Controls.Add(this.txtGroupName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestiones";
            this.Text = "Gestiones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.RichTextBox txtGroupDescription;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstEstudiantesDisponibles;
        private System.Windows.Forms.ListBox lstEstudiantesAsignados;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox comboBoxGrupos;
        private System.Windows.Forms.Button btnLimpiar;
    }
}