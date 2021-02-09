namespace LVAPV07
{
    partial class Form1
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
            this.lblFormaUno = new System.Windows.Forms.Label();
            this.bttLLamarAformaDos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormaUno
            // 
            this.lblFormaUno.AutoSize = true;
            this.lblFormaUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaUno.ForeColor = System.Drawing.Color.Red;
            this.lblFormaUno.Location = new System.Drawing.Point(257, 218);
            this.lblFormaUno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormaUno.Name = "lblFormaUno";
            this.lblFormaUno.Size = new System.Drawing.Size(437, 91);
            this.lblFormaUno.TabIndex = 0;
            this.lblFormaUno.Text = "Forma Uno";
            this.lblFormaUno.Click += new System.EventHandler(this.label1_Click);
            // 
            // bttLLamarAformaDos
            // 
            this.bttLLamarAformaDos.Location = new System.Drawing.Point(600, 434);
            this.bttLLamarAformaDos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttLLamarAformaDos.Name = "bttLLamarAformaDos";
            this.bttLLamarAformaDos.Size = new System.Drawing.Size(355, 65);
            this.bttLLamarAformaDos.TabIndex = 1;
            this.bttLLamarAformaDos.Text = "LLamar Forma Dos";
            this.bttLLamarAformaDos.UseVisualStyleBackColor = true;
            this.bttLLamarAformaDos.Click += new System.EventHandler(this.bttLLamarAformaDos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(77, 431);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(157, 70);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.bttLLamarAformaDos);
            this.Controls.Add(this.lblFormaUno);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormaUno;
        private System.Windows.Forms.Button bttLLamarAformaDos;
        private System.Windows.Forms.Button btnCerrar;
    }
}

