namespace _03_Eventos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.VideoEncodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VideoEncodButton
            // 
            this.VideoEncodButton.Location = new System.Drawing.Point(118, 152);
            this.VideoEncodButton.Name = "VideoEncodButton";
            this.VideoEncodButton.Size = new System.Drawing.Size(303, 50);
            this.VideoEncodButton.TabIndex = 0;
            this.VideoEncodButton.Text = "Vídeo Encode";
            this.VideoEncodButton.UseVisualStyleBackColor = true;
            //this.VideoEncodButton.Click += new System.EventHandler(this.VideoEncodButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 248);
            this.Controls.Add(this.VideoEncodButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VideoEncodButton;
    }
}

