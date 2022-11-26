namespace OliveiraTrade
{
    partial class FormEntrada
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
            this.Lbl_TemCadastro = new System.Windows.Forms.Label();
            this.lbl_FacaLogin = new System.Windows.Forms.Label();
            this.lbl_LogUsuario = new System.Windows.Forms.Label();
            this.lbl_LogSenha = new System.Windows.Forms.Label();
            this.txtBx_LogUsuario = new System.Windows.Forms.TextBox();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.txtBx_LogSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ToSignUp = new System.Windows.Forms.Button();
            this.lbl_NovoUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_TemCadastro
            // 
            this.Lbl_TemCadastro.AutoSize = true;
            this.Lbl_TemCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TemCadastro.Location = new System.Drawing.Point(26, 10);
            this.Lbl_TemCadastro.Name = "Lbl_TemCadastro";
            this.Lbl_TemCadastro.Size = new System.Drawing.Size(216, 26);
            this.Lbl_TemCadastro.TabIndex = 5;
            this.Lbl_TemCadastro.Text = "Já tem um cadastro?";
            // 
            // lbl_FacaLogin
            // 
            this.lbl_FacaLogin.AutoSize = true;
            this.lbl_FacaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FacaLogin.Location = new System.Drawing.Point(57, 54);
            this.lbl_FacaLogin.Name = "lbl_FacaLogin";
            this.lbl_FacaLogin.Size = new System.Drawing.Size(144, 17);
            this.lbl_FacaLogin.TabIndex = 6;
            this.lbl_FacaLogin.Text = "Faça seu Log In aqui:";
            // 
            // lbl_LogUsuario
            // 
            this.lbl_LogUsuario.AutoSize = true;
            this.lbl_LogUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LogUsuario.Location = new System.Drawing.Point(28, 118);
            this.lbl_LogUsuario.Name = "lbl_LogUsuario";
            this.lbl_LogUsuario.Size = new System.Drawing.Size(64, 18);
            this.lbl_LogUsuario.TabIndex = 7;
            this.lbl_LogUsuario.Text = "Usuário:";
            // 
            // lbl_LogSenha
            // 
            this.lbl_LogSenha.AutoSize = true;
            this.lbl_LogSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LogSenha.Location = new System.Drawing.Point(28, 201);
            this.lbl_LogSenha.Name = "lbl_LogSenha";
            this.lbl_LogSenha.Size = new System.Drawing.Size(54, 18);
            this.lbl_LogSenha.TabIndex = 8;
            this.lbl_LogSenha.Text = "Senha:";
            // 
            // txtBx_LogUsuario
            // 
            this.txtBx_LogUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_LogUsuario.Location = new System.Drawing.Point(31, 139);
            this.txtBx_LogUsuario.Name = "txtBx_LogUsuario";
            this.txtBx_LogUsuario.Size = new System.Drawing.Size(211, 24);
            this.txtBx_LogUsuario.TabIndex = 9;
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignIn.Location = new System.Drawing.Point(84, 278);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(99, 23);
            this.btn_SignIn.TabIndex = 10;
            this.btn_SignIn.Text = "Sign In";
            this.btn_SignIn.UseVisualStyleBackColor = true;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // txtBx_LogSenha
            // 
            this.txtBx_LogSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_LogSenha.Location = new System.Drawing.Point(31, 222);
            this.txtBx_LogSenha.Name = "txtBx_LogSenha";
            this.txtBx_LogSenha.Size = new System.Drawing.Size(211, 24);
            this.txtBx_LogSenha.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ToSignUp);
            this.panel1.Controls.Add(this.txtBx_LogSenha);
            this.panel1.Controls.Add(this.lbl_NovoUsuario);
            this.panel1.Controls.Add(this.btn_SignIn);
            this.panel1.Controls.Add(this.txtBx_LogUsuario);
            this.panel1.Controls.Add(this.lbl_LogSenha);
            this.panel1.Controls.Add(this.lbl_LogUsuario);
            this.panel1.Controls.Add(this.lbl_FacaLogin);
            this.panel1.Controls.Add(this.Lbl_TemCadastro);
            this.panel1.Location = new System.Drawing.Point(54, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 402);
            this.panel1.TabIndex = 0;
            // 
            // btn_ToSignUp
            // 
            this.btn_ToSignUp.Location = new System.Drawing.Point(168, 357);
            this.btn_ToSignUp.Name = "btn_ToSignUp";
            this.btn_ToSignUp.Size = new System.Drawing.Size(75, 23);
            this.btn_ToSignUp.TabIndex = 15;
            this.btn_ToSignUp.Text = "Sign Up";
            this.btn_ToSignUp.UseVisualStyleBackColor = true;
            this.btn_ToSignUp.Click += new System.EventHandler(this.btn_ToRegistro_Click);
            // 
            // lbl_NovoUsuario
            // 
            this.lbl_NovoUsuario.AutoSize = true;
            this.lbl_NovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_NovoUsuario.Location = new System.Drawing.Point(28, 360);
            this.lbl_NovoUsuario.Name = "lbl_NovoUsuario";
            this.lbl_NovoUsuario.Size = new System.Drawing.Size(134, 17);
            this.lbl_NovoUsuario.TabIndex = 14;
            this.lbl_NovoUsuario.Text = "É um novo usuário?";
            // 
            // FormEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 476);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEntrada";
            this.Text = "Oliveira Trade SignIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Lbl_TemCadastro;
        private System.Windows.Forms.Label lbl_FacaLogin;
        private System.Windows.Forms.Label lbl_LogUsuario;
        private System.Windows.Forms.Label lbl_LogSenha;
        private System.Windows.Forms.TextBox txtBx_LogUsuario;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.TextBox txtBx_LogSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ToSignUp;
        private System.Windows.Forms.Label lbl_NovoUsuario;
    }
}

