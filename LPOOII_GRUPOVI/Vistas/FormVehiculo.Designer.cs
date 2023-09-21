namespace Vistas
{
    partial class FormVehiculo
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
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.AltaVehiculo = new System.Windows.Forms.Label();
            this.TVCodigolabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.frmTVCod = new System.Windows.Forms.TextBox();
            this.frmChinko = new System.Windows.Forms.TextBox();
            this.frmDescrip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Location = new System.Drawing.Point(93, 168);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(192, 23);
            this.btnVehiculo.TabIndex = 0;
            this.btnVehiculo.Text = "Guardar Vehiculo";
            this.btnVehiculo.UseVisualStyleBackColor = true;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // AltaVehiculo
            // 
            this.AltaVehiculo.AutoSize = true;
            this.AltaVehiculo.Location = new System.Drawing.Point(54, 23);
            this.AltaVehiculo.Name = "AltaVehiculo";
            this.AltaVehiculo.Size = new System.Drawing.Size(84, 13);
            this.AltaVehiculo.TabIndex = 1;
            this.AltaVehiculo.Text = "Alta de Vehiculo";
            // 
            // TVCodigolabel
            // 
            this.TVCodigolabel.AutoSize = true;
            this.TVCodigolabel.Location = new System.Drawing.Point(54, 58);
            this.TVCodigolabel.Name = "TVCodigolabel";
            this.TVCodigolabel.Size = new System.Drawing.Size(54, 13);
            this.TVCodigolabel.TabIndex = 2;
            this.TVCodigolabel.Text = "TVCodigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tarifa";
            // 
            // frmTVCod
            // 
            this.frmTVCod.Location = new System.Drawing.Point(144, 58);
            this.frmTVCod.Name = "frmTVCod";
            this.frmTVCod.Size = new System.Drawing.Size(100, 20);
            this.frmTVCod.TabIndex = 5;
            // 
            // frmChinko
            // 
            this.frmChinko.Location = new System.Drawing.Point(144, 127);
            this.frmChinko.Name = "frmChinko";
            this.frmChinko.Size = new System.Drawing.Size(100, 20);
            this.frmChinko.TabIndex = 7;
            // 
            // frmDescrip
            // 
            this.frmDescrip.Location = new System.Drawing.Point(144, 92);
            this.frmDescrip.Name = "frmDescrip";
            this.frmDescrip.Size = new System.Drawing.Size(100, 20);
            this.frmDescrip.TabIndex = 6;
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 340);
            this.Controls.Add(this.frmChinko);
            this.Controls.Add(this.frmDescrip);
            this.Controls.Add(this.frmTVCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TVCodigolabel);
            this.Controls.Add(this.AltaVehiculo);
            this.Controls.Add(this.btnVehiculo);
            this.Name = "FormVehiculo";
            this.Text = "FormVehiculo";
            this.Load += new System.EventHandler(this.FormVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.Label AltaVehiculo;
        private System.Windows.Forms.Label TVCodigolabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox frmTVCod;
        private System.Windows.Forms.TextBox frmChinko;
        private System.Windows.Forms.TextBox frmDescrip;
    }
}