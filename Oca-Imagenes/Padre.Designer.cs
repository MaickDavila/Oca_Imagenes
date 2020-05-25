namespace Oca_Imagenes
{
    partial class Padre
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
            this.btnllamar_hijo = new System.Windows.Forms.Button();
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnllamar_hijo
            // 
            this.btnllamar_hijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnllamar_hijo.Location = new System.Drawing.Point(12, 142);
            this.btnllamar_hijo.Name = "btnllamar_hijo";
            this.btnllamar_hijo.Size = new System.Drawing.Size(241, 161);
            this.btnllamar_hijo.TabIndex = 1;
            this.btnllamar_hijo.Text = "Llamar Hijo";
            this.btnllamar_hijo.UseVisualStyleBackColor = true;
            this.btnllamar_hijo.Click += new System.EventHandler(this.btnllamar_hijo_Click);
            // 
            // txt_texto
            // 
            this.txt_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_texto.Location = new System.Drawing.Point(66, 322);
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(585, 47);
            this.txt_texto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "HOLA SOY EL PADRE";
            // 
            // Padre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_texto);
            this.Controls.Add(this.btnllamar_hijo);
            this.Name = "Padre";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imagen_Seleccionada";
            this.Load += new System.EventHandler(this.Imagen_Seleccionada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnllamar_hijo;
        private System.Windows.Forms.TextBox txt_texto;
        private System.Windows.Forms.Label label1;
    }
}