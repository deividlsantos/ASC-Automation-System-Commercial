namespace ASC_Automation_System_Commercial
{
    partial class TelaPrincipal
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
            this.btnMproduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMproduto
            // 
            this.btnMproduto.Location = new System.Drawing.Point(27, 37);
            this.btnMproduto.Name = "btnMproduto";
            this.btnMproduto.Size = new System.Drawing.Size(143, 23);
            this.btnMproduto.TabIndex = 0;
            this.btnMproduto.Text = "Cadastro de Produto";
            this.btnMproduto.UseVisualStyleBackColor = true;
            this.btnMproduto.Click += new System.EventHandler(this.btnMproduto_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMproduto);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMproduto;
    }
}