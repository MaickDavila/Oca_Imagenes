namespace Oca_Imagenes
{
    partial class Hijo
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
            this.btn_enviar_a_padre = new System.Windows.Forms.Button();
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_enviar_a_padre
            // 
            this.btn_enviar_a_padre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar_a_padre.Location = new System.Drawing.Point(12, 256);
            this.btn_enviar_a_padre.Name = "btn_enviar_a_padre";
            this.btn_enviar_a_padre.Size = new System.Drawing.Size(241, 161);
            this.btn_enviar_a_padre.TabIndex = 0;
            this.btn_enviar_a_padre.Text = "Enviar a padre";
            this.btn_enviar_a_padre.UseVisualStyleBackColor = true;
            this.btn_enviar_a_padre.Click += new System.EventHandler(this.btn_enviar_a_padre_Click);
            // 
            // txt_texto
            // 
            this.txt_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_texto.Location = new System.Drawing.Point(12, 136);
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(585, 47);
            this.txt_texto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "HOLA SOY EL HIJO";
            // 
            // Hijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_texto);
            this.Controls.Add(this.btn_enviar_a_padre);
            this.Name = "Hijo";
            this.Text = "Hijo";
            this.Load += new System.EventHandler(this.Hijo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enviar_a_padre;
        private System.Windows.Forms.TextBox txt_texto;
        private System.Windows.Forms.Label label1;
    }
}