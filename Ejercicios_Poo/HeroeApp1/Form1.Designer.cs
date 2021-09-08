
namespace HeroeApp1
{
    partial class FrmUniverso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevoHeroe = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNuevoHeroe
            // 
            this.btnNuevoHeroe.Location = new System.Drawing.Point(140, 188);
            this.btnNuevoHeroe.Name = "btnNuevoHeroe";
            this.btnNuevoHeroe.Size = new System.Drawing.Size(145, 23);
            this.btnNuevoHeroe.TabIndex = 1;
            this.btnNuevoHeroe.Text = "&NuevoHeroe";
            this.btnNuevoHeroe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoHeroe.UseVisualStyleBackColor = true;
            this.btnNuevoHeroe.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Enabled = false;
            this.lbl.Location = new System.Drawing.Point(56, 51);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(53, 15);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Universo";
            this.lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnNuevoHeroe);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Text = "Titulo de formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNuevoHeroe;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

