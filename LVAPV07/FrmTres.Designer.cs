namespace LVAPV07
{
    partial class FrmTres
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
            this.btnLlamarAFormaDos = new System.Windows.Forms.Button();
            this.lblFormaTres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLlamarAFormaDos
            // 
            this.btnLlamarAFormaDos.Location = new System.Drawing.Point(152, 102);
            this.btnLlamarAFormaDos.Name = "btnLlamarAFormaDos";
            this.btnLlamarAFormaDos.Size = new System.Drawing.Size(298, 90);
            this.btnLlamarAFormaDos.TabIndex = 0;
            this.btnLlamarAFormaDos.Text = "Llamar A Forma Dos";
            this.btnLlamarAFormaDos.UseVisualStyleBackColor = true;
            this.btnLlamarAFormaDos.Click += new System.EventHandler(this.btnLlamarAFormaDos_Click);
            // 
            // lblFormaTres
            // 
            this.lblFormaTres.AutoSize = true;
            this.lblFormaTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaTres.ForeColor = System.Drawing.Color.Maroon;
            this.lblFormaTres.Location = new System.Drawing.Point(229, 240);
            this.lblFormaTres.Name = "lblFormaTres";
            this.lblFormaTres.Size = new System.Drawing.Size(339, 69);
            this.lblFormaTres.TabIndex = 1;
            this.lblFormaTres.Text = "Forma Tres";
            // 
            // FrmTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFormaTres);
            this.Controls.Add(this.btnLlamarAFormaDos);
            this.Name = "FrmTres";
            this.Text = "FrmTres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlamarAFormaDos;
        private System.Windows.Forms.Label lblFormaTres;
    }
}