namespace ProyectoI
{
    partial class FrmMaterialesEstudiante
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.TabMateriales = new System.Windows.Forms.TabControl();
            this.TabPagDocumentos = new System.Windows.Forms.TabPage();
            this.PanelDocumentos = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ListBoxDocumentos = new System.Windows.Forms.ListBox();
            this.TabPagPresentaciones = new System.Windows.Forms.TabPage();
            this.PanelPresentaciones = new System.Windows.Forms.Panel();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.ListBoxPresentaciones = new System.Windows.Forms.ListBox();
            this.TabPagVideos = new System.Windows.Forms.TabPage();
            this.PanelVideos = new System.Windows.Forms.Panel();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.ListBoxVideos = new System.Windows.Forms.ListBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.comboBoxCursos = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.TabMateriales.SuspendLayout();
            this.TabPagDocumentos.SuspendLayout();
            this.PanelDocumentos.SuspendLayout();
            this.TabPagPresentaciones.SuspendLayout();
            this.PanelPresentaciones.SuspendLayout();
            this.TabPagVideos.SuspendLayout();
            this.PanelVideos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(146, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATERIALES DEL CURSO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuSalir
            // 
            this.MenuSalir.Name = "MenuSalir";
            this.MenuSalir.Size = new System.Drawing.Size(41, 20);
            this.MenuSalir.Text = "Salir";
            this.MenuSalir.Click += new System.EventHandler(this.MenuSalir_Click);
            // 
            // TabMateriales
            // 
            this.TabMateriales.Controls.Add(this.TabPagDocumentos);
            this.TabMateriales.Controls.Add(this.TabPagPresentaciones);
            this.TabMateriales.Controls.Add(this.TabPagVideos);
            this.TabMateriales.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabMateriales.Location = new System.Drawing.Point(11, 40);
            this.TabMateriales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabMateriales.Name = "TabMateriales";
            this.TabMateriales.SelectedIndex = 0;
            this.TabMateriales.Size = new System.Drawing.Size(538, 315);
            this.TabMateriales.TabIndex = 2;
            this.TabMateriales.SelectedIndexChanged += new System.EventHandler(this.TabMaterialesIndexChanged);
            // 
            // TabPagDocumentos
            // 
            this.TabPagDocumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TabPagDocumentos.Controls.Add(this.PanelDocumentos);
            this.TabPagDocumentos.Controls.Add(this.ListBoxDocumentos);
            this.TabPagDocumentos.Location = new System.Drawing.Point(4, 26);
            this.TabPagDocumentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPagDocumentos.Name = "TabPagDocumentos";
            this.TabPagDocumentos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPagDocumentos.Size = new System.Drawing.Size(530, 285);
            this.TabPagDocumentos.TabIndex = 0;
            this.TabPagDocumentos.Text = "Documentos";
            // 
            // PanelDocumentos
            // 
            this.PanelDocumentos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.PanelDocumentos.Controls.Add(this.webBrowser1);
            this.PanelDocumentos.Location = new System.Drawing.Point(4, 94);
            this.PanelDocumentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelDocumentos.Name = "PanelDocumentos";
            this.PanelDocumentos.Size = new System.Drawing.Size(524, 189);
            this.PanelDocumentos.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(524, 189);
            this.webBrowser1.TabIndex = 0;
            // 
            // ListBoxDocumentos
            // 
            this.ListBoxDocumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ListBoxDocumentos.ForeColor = System.Drawing.Color.White;
            this.ListBoxDocumentos.FormattingEnabled = true;
            this.ListBoxDocumentos.ItemHeight = 17;
            this.ListBoxDocumentos.Location = new System.Drawing.Point(2, 5);
            this.ListBoxDocumentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListBoxDocumentos.Name = "ListBoxDocumentos";
            this.ListBoxDocumentos.Size = new System.Drawing.Size(527, 55);
            this.ListBoxDocumentos.TabIndex = 0;
            this.ListBoxDocumentos.SelectedIndexChanged += new System.EventHandler(this.ListBoxDocumentos_SelectedIndexChanged);
            // 
            // TabPagPresentaciones
            // 
            this.TabPagPresentaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TabPagPresentaciones.Controls.Add(this.PanelPresentaciones);
            this.TabPagPresentaciones.Controls.Add(this.ListBoxPresentaciones);
            this.TabPagPresentaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TabPagPresentaciones.Location = new System.Drawing.Point(4, 26);
            this.TabPagPresentaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPagPresentaciones.Name = "TabPagPresentaciones";
            this.TabPagPresentaciones.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPagPresentaciones.Size = new System.Drawing.Size(530, 285);
            this.TabPagPresentaciones.TabIndex = 1;
            this.TabPagPresentaciones.Text = "Presentaciones";
            // 
            // PanelPresentaciones
            // 
            this.PanelPresentaciones.Controls.Add(this.webBrowser2);
            this.PanelPresentaciones.Location = new System.Drawing.Point(5, 95);
            this.PanelPresentaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelPresentaciones.Name = "PanelPresentaciones";
            this.PanelPresentaciones.Size = new System.Drawing.Size(523, 188);
            this.PanelPresentaciones.TabIndex = 1;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(523, 188);
            this.webBrowser2.TabIndex = 0;
            // 
            // ListBoxPresentaciones
            // 
            this.ListBoxPresentaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ListBoxPresentaciones.ForeColor = System.Drawing.Color.White;
            this.ListBoxPresentaciones.FormattingEnabled = true;
            this.ListBoxPresentaciones.ItemHeight = 17;
            this.ListBoxPresentaciones.Location = new System.Drawing.Point(5, 6);
            this.ListBoxPresentaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListBoxPresentaciones.Name = "ListBoxPresentaciones";
            this.ListBoxPresentaciones.Size = new System.Drawing.Size(524, 55);
            this.ListBoxPresentaciones.TabIndex = 0;
            this.ListBoxPresentaciones.SelectedIndexChanged += new System.EventHandler(this.ListBoxPresentaciones_SelectedIndexChanged);
            // 
            // TabPagVideos
            // 
            this.TabPagVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TabPagVideos.Controls.Add(this.PanelVideos);
            this.TabPagVideos.Controls.Add(this.ListBoxVideos);
            this.TabPagVideos.Location = new System.Drawing.Point(4, 26);
            this.TabPagVideos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPagVideos.Name = "TabPagVideos";
            this.TabPagVideos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPagVideos.Size = new System.Drawing.Size(530, 285);
            this.TabPagVideos.TabIndex = 2;
            this.TabPagVideos.Text = "Videos";
            // 
            // PanelVideos
            // 
            this.PanelVideos.Controls.Add(this.webBrowser3);
            this.PanelVideos.Location = new System.Drawing.Point(4, 95);
            this.PanelVideos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelVideos.Name = "PanelVideos";
            this.PanelVideos.Size = new System.Drawing.Size(524, 188);
            this.PanelVideos.TabIndex = 1;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(0, 0);
            this.webBrowser3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(524, 188);
            this.webBrowser3.TabIndex = 0;
            // 
            // ListBoxVideos
            // 
            this.ListBoxVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ListBoxVideos.ForeColor = System.Drawing.Color.White;
            this.ListBoxVideos.FormattingEnabled = true;
            this.ListBoxVideos.ItemHeight = 17;
            this.ListBoxVideos.Location = new System.Drawing.Point(5, 6);
            this.ListBoxVideos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListBoxVideos.Name = "ListBoxVideos";
            this.ListBoxVideos.Size = new System.Drawing.Size(524, 55);
            this.ListBoxVideos.TabIndex = 0;
            this.ListBoxVideos.SelectedIndexChanged += new System.EventHandler(this.ListBoxVideos_SelectedIndexChanged);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // comboBoxCursos
            // 
            this.comboBoxCursos.FormattingEnabled = true;
            this.comboBoxCursos.Location = new System.Drawing.Point(47, 3);
            this.comboBoxCursos.Name = "comboBoxCursos";
            this.comboBoxCursos.Size = new System.Drawing.Size(94, 21);
            this.comboBoxCursos.TabIndex = 3;
            // 
            // FrmMaterialesEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.comboBoxCursos);
            this.Controls.Add(this.TabMateriales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMaterialesEstudiante";
            this.Text = "Materiales";
            this.Load += new System.EventHandler(this.Materiales_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabMateriales.ResumeLayout(false);
            this.TabPagDocumentos.ResumeLayout(false);
            this.PanelDocumentos.ResumeLayout(false);
            this.TabPagPresentaciones.ResumeLayout(false);
            this.PanelPresentaciones.ResumeLayout(false);
            this.TabPagVideos.ResumeLayout(false);
            this.PanelVideos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl TabMateriales;
        private System.Windows.Forms.TabPage TabPagDocumentos;
        private System.Windows.Forms.ListBox ListBoxDocumentos;
        private System.Windows.Forms.TabPage TabPagPresentaciones;
        private System.Windows.Forms.ListBox ListBoxPresentaciones;
        private System.Windows.Forms.TabPage TabPagVideos;
        private System.Windows.Forms.ListBox ListBoxVideos;
        private System.Windows.Forms.Panel PanelVideos;
        private System.Windows.Forms.Panel PanelDocumentos;
        private System.Windows.Forms.Panel PanelPresentaciones;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ToolStripMenuItem MenuSalir;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.ComboBox comboBoxCursos;
    }
}