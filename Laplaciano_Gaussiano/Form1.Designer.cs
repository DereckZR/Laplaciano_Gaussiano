
namespace Laplaciano_Gaussiano
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PB_img = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianoGaussianoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OFD_img = new System.Windows.Forms.OpenFileDialog();
            this.SFD_img = new System.Windows.Forms.SaveFileDialog();
            this.PB_result = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_img)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_img
            // 
            this.PB_img.Location = new System.Drawing.Point(12, 44);
            this.PB_img.Name = "PB_img";
            this.PB_img.Size = new System.Drawing.Size(300, 300);
            this.PB_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_img.TabIndex = 0;
            this.PB_img.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.filtrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1131, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.abrirToolStripMenuItem.Text = "abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.guardarToolStripMenuItem.Text = "guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laplacianoToolStripMenuItem,
            this.gaussianoToolStripMenuItem,
            this.laplacianoGaussianoToolStripMenuItem});
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.filtrosToolStripMenuItem.Text = "filtros";
            // 
            // laplacianoToolStripMenuItem
            // 
            this.laplacianoToolStripMenuItem.Name = "laplacianoToolStripMenuItem";
            this.laplacianoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.laplacianoToolStripMenuItem.Text = "Laplaciano";
            this.laplacianoToolStripMenuItem.Click += new System.EventHandler(this.laplacianoToolStripMenuItem_Click);
            // 
            // gaussianoToolStripMenuItem
            // 
            this.gaussianoToolStripMenuItem.Name = "gaussianoToolStripMenuItem";
            this.gaussianoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.gaussianoToolStripMenuItem.Text = "Gaussiano";
            this.gaussianoToolStripMenuItem.Click += new System.EventHandler(this.gaussianoToolStripMenuItem_Click);
            // 
            // laplacianoGaussianoToolStripMenuItem
            // 
            this.laplacianoGaussianoToolStripMenuItem.Name = "laplacianoGaussianoToolStripMenuItem";
            this.laplacianoGaussianoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.laplacianoGaussianoToolStripMenuItem.Text = "Laplaciano Gaussiano";
            this.laplacianoGaussianoToolStripMenuItem.Click += new System.EventHandler(this.laplacianoGaussianoToolStripMenuItem_Click);
            // 
            // OFD_img
            // 
            this.OFD_img.FileName = "openFileDialog1";
            // 
            // PB_result
            // 
            this.PB_result.Location = new System.Drawing.Point(368, 44);
            this.PB_result.Name = "PB_result";
            this.PB_result.Size = new System.Drawing.Size(300, 300);
            this.PB_result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_result.TabIndex = 2;
            this.PB_result.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(723, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 365);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PB_result);
            this.Controls.Add(this.PB_img);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_img)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_img;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianoGaussianoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OFD_img;
        private System.Windows.Forms.SaveFileDialog SFD_img;
        private System.Windows.Forms.PictureBox PB_result;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

