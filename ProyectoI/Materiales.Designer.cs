﻿namespace ProyectoI
{
    partial class Materiales
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
            this.MenuCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPerfil = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATERIALES DEL CURSO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.ForestGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCurso,
            this.MenuPerfil,
            this.MenuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCurso
            // 
            this.MenuCurso.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCurso.Name = "MenuCurso";
            this.MenuCurso.Size = new System.Drawing.Size(71, 24);
            this.MenuCurso.Text = "Cursos";
            this.MenuCurso.Click += new System.EventHandler(this.MenuCurso_Click);
            // 
            // MenuPerfil
            // 
            this.MenuPerfil.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPerfil.Name = "MenuPerfil";
            this.MenuPerfil.Size = new System.Drawing.Size(59, 24);
            this.MenuPerfil.Text = "Perfil";
            this.MenuPerfil.Click += new System.EventHandler(this.MenuPerfil_Click);
            // 
            // MenuSalir
            // 
            this.MenuSalir.Name = "MenuSalir";
            this.MenuSalir.Size = new System.Drawing.Size(52, 24);
            this.MenuSalir.Text = "Salir";
            this.MenuSalir.Click += new System.EventHandler(this.MenuSalir_Click);
            // 
            // TabMateriales
            // 
            this.TabMateriales.Controls.Add(this.TabPagDocumentos);
            this.TabMateriales.Controls.Add(this.TabPagPresentaciones);
            this.TabMateriales.Controls.Add(this.TabPagVideos);
            this.TabMateriales.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabMateriales.Location = new System.Drawing.Point(13, 50);
            this.TabMateriales.Name = "TabMateriales";
            this.TabMateriales.SelectedIndex = 0;
            this.TabMateriales.Size = new System.Drawing.Size(718, 388);
            this.TabMateriales.TabIndex = 2;
            // 
            // TabPagDocumentos
            // 
            this.TabPagDocumentos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TabPagDocumentos.Controls.Add(this.PanelDocumentos);
            this.TabPagDocumentos.Controls.Add(this.ListBoxDocumentos);
            this.TabPagDocumentos.Location = new System.Drawing.Point(4, 29);
            this.TabPagDocumentos.Name = "TabPagDocumentos";
            this.TabPagDocumentos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagDocumentos.Size = new System.Drawing.Size(710, 355);
            this.TabPagDocumentos.TabIndex = 0;
            this.TabPagDocumentos.Text = "Documentos";
            // 
            // PanelDocumentos
            // 
            this.PanelDocumentos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.PanelDocumentos.Controls.Add(this.webBrowser1);
            this.PanelDocumentos.Location = new System.Drawing.Point(6, 116);
            this.PanelDocumentos.Name = "PanelDocumentos";
            this.PanelDocumentos.Size = new System.Drawing.Size(698, 233);
            this.PanelDocumentos.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(698, 233);
            this.webBrowser1.TabIndex = 0;
            // 
            // ListBoxDocumentos
            // 
            this.ListBoxDocumentos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ListBoxDocumentos.FormattingEnabled = true;
            this.ListBoxDocumentos.ItemHeight = 20;
            this.ListBoxDocumentos.Location = new System.Drawing.Point(3, 6);
            this.ListBoxDocumentos.Name = "ListBoxDocumentos";
            this.ListBoxDocumentos.Size = new System.Drawing.Size(701, 104);
            this.ListBoxDocumentos.TabIndex = 0;
            this.ListBoxDocumentos.SelectedIndexChanged += new System.EventHandler(this.ListBoxDocumentos_SelectedIndexChanged);
            // 
            // TabPagPresentaciones
            // 
            this.TabPagPresentaciones.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TabPagPresentaciones.Controls.Add(this.PanelPresentaciones);
            this.TabPagPresentaciones.Controls.Add(this.ListBoxPresentaciones);
            this.TabPagPresentaciones.Location = new System.Drawing.Point(4, 29);
            this.TabPagPresentaciones.Name = "TabPagPresentaciones";
            this.TabPagPresentaciones.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagPresentaciones.Size = new System.Drawing.Size(710, 355);
            this.TabPagPresentaciones.TabIndex = 1;
            this.TabPagPresentaciones.Text = "Presentaciones";
            // 
            // PanelPresentaciones
            // 
            this.PanelPresentaciones.Controls.Add(this.webBrowser2);
            this.PanelPresentaciones.Location = new System.Drawing.Point(7, 117);
            this.PanelPresentaciones.Name = "PanelPresentaciones";
            this.PanelPresentaciones.Size = new System.Drawing.Size(697, 232);
            this.PanelPresentaciones.TabIndex = 1;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(697, 232);
            this.webBrowser2.TabIndex = 0;
            // 
            // ListBoxPresentaciones
            // 
            this.ListBoxPresentaciones.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ListBoxPresentaciones.FormattingEnabled = true;
            this.ListBoxPresentaciones.ItemHeight = 20;
            this.ListBoxPresentaciones.Location = new System.Drawing.Point(7, 7);
            this.ListBoxPresentaciones.Name = "ListBoxPresentaciones";
            this.ListBoxPresentaciones.Size = new System.Drawing.Size(697, 104);
            this.ListBoxPresentaciones.TabIndex = 0;
            this.ListBoxPresentaciones.SelectedIndexChanged += new System.EventHandler(this.ListBoxPresentaciones_SelectedIndexChanged);
            // 
            // TabPagVideos
            // 
            this.TabPagVideos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TabPagVideos.Controls.Add(this.PanelVideos);
            this.TabPagVideos.Controls.Add(this.ListBoxVideos);
            this.TabPagVideos.Location = new System.Drawing.Point(4, 29);
            this.TabPagVideos.Name = "TabPagVideos";
            this.TabPagVideos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagVideos.Size = new System.Drawing.Size(710, 355);
            this.TabPagVideos.TabIndex = 2;
            this.TabPagVideos.Text = "Videos";
            // 
            // PanelVideos
            // 
            this.PanelVideos.Controls.Add(this.webBrowser3);
            this.PanelVideos.Location = new System.Drawing.Point(6, 117);
            this.PanelVideos.Name = "PanelVideos";
            this.PanelVideos.Size = new System.Drawing.Size(698, 232);
            this.PanelVideos.TabIndex = 1;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(0, 0);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(698, 232);
            this.webBrowser3.TabIndex = 0;
            // 
            // ListBoxVideos
            // 
            this.ListBoxVideos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ListBoxVideos.FormattingEnabled = true;
            this.ListBoxVideos.ItemHeight = 20;
            this.ListBoxVideos.Location = new System.Drawing.Point(7, 7);
            this.ListBoxVideos.Name = "ListBoxVideos";
            this.ListBoxVideos.Size = new System.Drawing.Size(697, 104);
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
            // Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabMateriales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Materiales";
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
        private System.Windows.Forms.ToolStripMenuItem MenuCurso;
        private System.Windows.Forms.ToolStripMenuItem MenuPerfil;
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
    }
}