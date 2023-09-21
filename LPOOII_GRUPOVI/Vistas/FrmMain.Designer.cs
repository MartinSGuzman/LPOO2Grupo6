namespace Vistas
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionSectoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeEstacionamientoToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionSectoresToolStripMenuItem,
            this.gestionClientesToolStripMenuItem,
            this.gestionVehiculosToolStripMenuItem,
            this.gestionDeEstacionamientoToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionSectoresToolStripMenuItem
            // 
            this.gestionSectoresToolStripMenuItem.Name = "gestionSectoresToolStripMenuItem";
            this.gestionSectoresToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.gestionSectoresToolStripMenuItem.Text = "Gestion de Sectores";
            // 
            // gestionClientesToolStripMenuItem
            // 
            this.gestionClientesToolStripMenuItem.Name = "gestionClientesToolStripMenuItem";
            this.gestionClientesToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestionClientesToolStripMenuItem.Text = "Gestion de Clientes";
            this.gestionClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionClientesToolStripMenuItem_Click);
            // 
            // gestionVehiculosToolStripMenuItem
            // 
            this.gestionVehiculosToolStripMenuItem.Name = "gestionVehiculosToolStripMenuItem";
            this.gestionVehiculosToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.gestionVehiculosToolStripMenuItem.Text = "Tipos de Vehiculo";
            this.gestionVehiculosToolStripMenuItem.Click += new System.EventHandler(this.gestionVehiculosToolStripMenuItem_Click);
            // 
            // gestionDeEstacionamientoToolStripMenu
            // 
            this.gestionDeEstacionamientoToolStripMenu.Name = "gestionDeEstacionamientoToolStripMenu";
            this.gestionDeEstacionamientoToolStripMenu.Size = new System.Drawing.Size(166, 20);
            this.gestionDeEstacionamientoToolStripMenu.Text = "Gestion de Estacionamiento";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 478);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionSectoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeEstacionamientoToolStripMenu;
    }
}