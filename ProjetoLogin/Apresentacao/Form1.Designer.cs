
namespace ProjetoLogin
{
    partial class Form1
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
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_LOGIN = new System.Windows.Forms.Label();
            this.lbl_SENHA = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_LOGIN = new System.Windows.Forms.TextBox();
            this.txt_SENHA = new System.Windows.Forms.TextBox();
            this.btn_cadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_entrar
            // 
            this.btn_entrar.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_entrar.Location = new System.Drawing.Point(303, 260);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(132, 46);
            this.btn_entrar.TabIndex = 0;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sair.Location = new System.Drawing.Point(490, 258);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(94, 48);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_LOGIN
            // 
            this.lbl_LOGIN.AutoSize = true;
            this.lbl_LOGIN.Location = new System.Drawing.Point(287, 62);
            this.lbl_LOGIN.Name = "lbl_LOGIN";
            this.lbl_LOGIN.Size = new System.Drawing.Size(51, 20);
            this.lbl_LOGIN.TabIndex = 2;
            this.lbl_LOGIN.Text = "LOGIN";
            this.lbl_LOGIN.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_SENHA
            // 
            this.lbl_SENHA.AutoSize = true;
            this.lbl_SENHA.Location = new System.Drawing.Point(287, 143);
            this.lbl_SENHA.Name = "lbl_SENHA";
            this.lbl_SENHA.Size = new System.Drawing.Size(57, 20);
            this.lbl_SENHA.TabIndex = 3;
            this.lbl_SENHA.Text = "SENHA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 114);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txt_LOGIN
            // 
            this.txt_LOGIN.Location = new System.Drawing.Point(382, 62);
            this.txt_LOGIN.Name = "txt_LOGIN";
            this.txt_LOGIN.Size = new System.Drawing.Size(226, 27);
            this.txt_LOGIN.TabIndex = 5;
            // 
            // txt_SENHA
            // 
            this.txt_SENHA.Location = new System.Drawing.Point(382, 140);
            this.txt_SENHA.Name = "txt_SENHA";
            this.txt_SENHA.Size = new System.Drawing.Size(226, 27);
            this.txt_SENHA.TabIndex = 6;
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cadastro.Location = new System.Drawing.Point(31, 260);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(202, 46);
            this.btn_cadastro.TabIndex = 7;
            this.btn_cadastro.Text = "CADASTRE-SE";
            this.btn_cadastro.UseVisualStyleBackColor = false;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(660, 362);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.txt_SENHA);
            this.Controls.Add(this.txt_LOGIN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_SENHA);
            this.Controls.Add(this.lbl_LOGIN);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_entrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_LOGIN;
        private System.Windows.Forms.Label lbl_SENHA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_LOGIN;
        private System.Windows.Forms.TextBox txt_SENHA;
        private System.Windows.Forms.Button btn_cadastro;
    }
}

