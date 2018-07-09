namespace ToppestGame
{
    partial class ErrorForm
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnLamentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(75, 323);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(351, 23);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Infelismente um erro noa trataodo foi lanssado";
            // 
            // btnLamentar
            // 
            this.btnLamentar.BackColor = System.Drawing.Color.Black;
            this.btnLamentar.FlatAppearance.BorderSize = 0;
            this.btnLamentar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnLamentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamentar.ForeColor = System.Drawing.Color.Gray;
            this.btnLamentar.Location = new System.Drawing.Point(168, 342);
            this.btnLamentar.Name = "btnLamentar";
            this.btnLamentar.Size = new System.Drawing.Size(138, 36);
            this.btnLamentar.TabIndex = 1;
            this.btnLamentar.Text = "Lamentar";
            this.btnLamentar.UseVisualStyleBackColor = false;
            this.btnLamentar.Click += new System.EventHandler(this.btnLamentar_Click);
            // 
            // ErrorForm
            // 
            this.AcceptButton = this.btnLamentar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::ToppestGame.Properties.Resources.fausto;
            this.ClientSize = new System.Drawing.Size(500, 390);
            this.Controls.Add(this.btnLamentar);
            this.Controls.Add(this.lblTexto);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ErrorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnLamentar;
    }
}