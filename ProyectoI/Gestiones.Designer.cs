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
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditGroup = new System.Windows.Forms.Button();
            this.lstGroups = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstEstudiantesDisponibles = new System.Windows.Forms.ListBox();
            this.lstEstudiantesAsignados = new System.Windows.Forms.ListBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtGroupName
            // 
            this.txtGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.Location = new System.Drawing.Point(602, 57);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(356, 26);
            this.txtGroupName.TabIndex = 0;
            // 
            // txtGroupDescription
            // 
            this.txtGroupDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupDescription.Location = new System.Drawing.Point(602, 136);
            this.txtGroupDescription.Name = "txtGroupDescription";
            this.txtGroupDescription.Size = new System.Drawing.Size(356, 162);
            this.txtGroupDescription.TabIndex = 1;
            this.txtGroupDescription.Text = "";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddGroup.Location = new System.Drawing.Point(505, 324);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(151, 56);
            this.btnAddGroup.TabIndex = 2;
            this.btnAddGroup.Text = "Crear";
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDeleteGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGroup.ForeColor = System.Drawing.Color.White;
            this.btnDeleteGroup.Location = new System.Drawing.Point(883, 322);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(151, 56);
            this.btnDeleteGroup.TabIndex = 3;
            this.btnDeleteGroup.Text = "Eliminar";
            this.btnDeleteGroup.UseVisualStyleBackColor = false;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(607, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(607, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion del grupo";
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEditGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGroup.ForeColor = System.Drawing.Color.White;
            this.btnEditGroup.Location = new System.Drawing.Point(708, 322);
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Size = new System.Drawing.Size(151, 58);
            this.btnEditGroup.TabIndex = 6;
            this.btnEditGroup.Text = "Editar";
            this.btnEditGroup.UseVisualStyleBackColor = false;
            this.btnEditGroup.Click += new System.EventHandler(this.btnEditGroup_Click);
            // 
            // lstGroups
            // 
            this.lstGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGroups.FormattingEnabled = true;
            this.lstGroups.ItemHeight = 20;
            this.lstGroups.Location = new System.Drawing.Point(683, 410);
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.Size = new System.Drawing.Size(221, 104);
            this.lstGroups.TabIndex = 7;
            this.lstGroups.SelectedIndexChanged += new System.EventHandler(this.lstGroups_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selecciona un curso";
            // 
            // lstEstudiantesDisponibles
            // 
            this.lstEstudiantesDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEstudiantesDisponibles.FormattingEnabled = true;
            this.lstEstudiantesDisponibles.ItemHeight = 20;
            this.lstEstudiantesDisponibles.Location = new System.Drawing.Point(40, 124);
            this.lstEstudiantesDisponibles.Name = "lstEstudiantesDisponibles";
            this.lstEstudiantesDisponibles.Size = new System.Drawing.Size(272, 144);
            this.lstEstudiantesDisponibles.TabIndex = 9;
            // 
            // lstEstudiantesAsignados
            // 
            this.lstEstudiantesAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEstudiantesAsignados.FormattingEnabled = true;
            this.lstEstudiantesAsignados.ItemHeight = 20;
            this.lstEstudiantesAsignados.Location = new System.Drawing.Point(40, 291);
            this.lstEstudiantesAsignados.Name = "lstEstudiantesAsignados";
            this.lstEstudiantesAsignados.Size = new System.Drawing.Size(272, 144);
            this.lstEstudiantesAsignados.TabIndex = 10;
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.White;
            this.btnAsignar.Location = new System.Drawing.Point(40, 471);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(124, 43);
            this.btnAsignar.TabIndex = 11;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(187, 471);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 43);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(40, 71);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(272, 28);
            this.comboBoxCurso.TabIndex = 13;
            // 
            // Gestiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboBoxCurso);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lstEstudiantesAsignados);
            this.Controls.Add(this.lstEstudiantesDisponibles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstGroups);
            this.Controls.Add(this.btnEditGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteGroup);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.txtGroupDescription);
            this.Controls.Add(this.txtGroupName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gestiones";
            this.Text = "Gestiones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.RichTextBox txtGroupDescription;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditGroup;
        private System.Windows.Forms.ListBox lstGroups;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstEstudiantesDisponibles;
        private System.Windows.Forms.ListBox lstEstudiantesAsignados;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox comboBoxCurso;
    }
}