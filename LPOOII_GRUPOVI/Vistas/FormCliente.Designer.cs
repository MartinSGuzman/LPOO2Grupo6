namespace Vistas
{
    partial class FormCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.frmNombre = new System.Windows.Forms.TextBox();
            this.frmTel = new System.Windows.Forms.TextBox();
            this.frmDNI = new System.Windows.Forms.TextBox();
            this.frmApellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alta Cliente";
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(170, 244);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(131, 23);
            this.btnCliente.TabIndex = 5;
            this.btnCliente.Text = "Guardar Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // frmNombre
            // 
            this.frmNombre.Location = new System.Drawing.Point(201, 62);
            this.frmNombre.Name = "frmNombre";
            this.frmNombre.Size = new System.Drawing.Size(100, 20);
            this.frmNombre.TabIndex = 6;
            // 
            // frmTel
            // 
            this.frmTel.Location = new System.Drawing.Point(201, 198);
            this.frmTel.Name = "frmTel";
            this.frmTel.Size = new System.Drawing.Size(100, 20);
            this.frmTel.TabIndex = 7;
            // 
            // frmDNI
            // 
            this.frmDNI.Location = new System.Drawing.Point(201, 154);
            this.frmDNI.Name = "frmDNI";
            this.frmDNI.Size = new System.Drawing.Size(100, 20);
            this.frmDNI.TabIndex = 8;
            // 
            // frmApellido
            // 
            this.frmApellido.Location = new System.Drawing.Point(201, 107);
            this.frmApellido.Name = "frmApellido";
            this.frmApellido.Size = new System.Drawing.Size(100, 20);
            this.frmApellido.TabIndex = 9;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 307);
            this.Controls.Add(this.frmApellido);
            this.Controls.Add(this.frmDNI);
            this.Controls.Add(this.frmTel);
            this.Controls.Add(this.frmNombre);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox frmNombre;
        private System.Windows.Forms.TextBox frmTel;
        private System.Windows.Forms.TextBox frmDNI;
        private System.Windows.Forms.TextBox frmApellido;
    }
}