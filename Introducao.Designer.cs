namespace ToppestGame
{
    partial class ToppestGame
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
            this.pnlGuia = new System.Windows.Forms.Panel();
            this.btnBumbum = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.pnlGuia.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGuia
            // 
            this.pnlGuia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGuia.BackgroundImage = global::ToppestGame.Properties.Resources.guia2;
            this.pnlGuia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGuia.Controls.Add(this.btnBumbum);
            this.pnlGuia.Controls.Add(this.lblMensagem);
            this.pnlGuia.Controls.Add(this.btnProximo);
            this.pnlGuia.Location = new System.Drawing.Point(417, 35);
            this.pnlGuia.Name = "pnlGuia";
            this.pnlGuia.Size = new System.Drawing.Size(362, 516);
            this.pnlGuia.TabIndex = 0;
            // 
            // btnBumbum
            // 
            this.btnBumbum.BackColor = System.Drawing.Color.LightGray;
            this.btnBumbum.Enabled = false;
            this.btnBumbum.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBumbum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBumbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBumbum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBumbum.Location = new System.Drawing.Point(215, 365);
            this.btnBumbum.Name = "btnBumbum";
            this.btnBumbum.Size = new System.Drawing.Size(101, 44);
            this.btnBumbum.TabIndex = 2;
            this.btnBumbum.Text = "bumbum";
            this.btnBumbum.UseVisualStyleBackColor = false;
            this.btnBumbum.Visible = false;
            this.btnBumbum.Click += new System.EventHandler(this.btnBumbum_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Black;
            this.lblMensagem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMensagem.Location = new System.Drawing.Point(32, 23);
            this.lblMensagem.MaximumSize = new System.Drawing.Size(300, 80);
            this.lblMensagem.MinimumSize = new System.Drawing.Size(300, 80);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(300, 80);
            this.lblMensagem.TabIndex = 1;
            this.lblMensagem.Text = "oi";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProximo
            // 
            this.btnProximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProximo.BackColor = System.Drawing.Color.Black;
            this.btnProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.Color.Silver;
            this.btnProximo.Location = new System.Drawing.Point(230, 103);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(96, 34);
            this.btnProximo.TabIndex = 0;
            this.btnProximo.Text = "prossimo >";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblClose.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(774, 2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(22, 23);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(124, 107);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 30);
            this.txtNome.TabIndex = 2;
            this.txtNome.Visible = false;
            // 
            // txtIdade
            // 
            this.txtIdade.Enabled = false;
            this.txtIdade.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(124, 200);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(200, 30);
            this.txtIdade.TabIndex = 3;
            this.txtIdade.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Enabled = false;
            this.lblNome.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(120, 81);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(107, 23);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "cual seu nome";
            this.lblNome.Visible = false;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Enabled = false;
            this.lblIdade.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(120, 174);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(77, 23);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "sua idade";
            this.lblIdade.Visible = false;
            // 
            // ToppestGame
            // 
            this.AcceptButton = this.btnProximo;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.ControlBox = false;
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.pnlGuia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToppestGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toppest Game";
            this.Load += new System.EventHandler(this.ToppestGame_Load);
            this.Shown += new System.EventHandler(this.ToppestGame_Shown);
            this.pnlGuia.ResumeLayout(false);
            this.pnlGuia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGuia;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnBumbum;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
    }
}

