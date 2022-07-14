
namespace mindalSHOP
{
    partial class autorisationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelReg = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelEnter = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.mtbPassword = new System.Windows.Forms.MaskedTextBox();
            this.panelHeading = new System.Windows.Forms.Panel();
            this.labelHeading = new System.Windows.Forms.Label();
            this.pBLogo = new System.Windows.Forms.PictureBox();
            this.panelHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReg
            // 
            this.labelReg.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReg.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelReg.Location = new System.Drawing.Point(87, 250);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(390, 27);
            this.labelReg.TabIndex = 15;
            this.labelReg.Text = "Зарегистрироваться";
            this.labelReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelReg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_Register_MouseClick);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEnter.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.btnEnter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnter.Location = new System.Drawing.Point(134, 294);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(132, 45);
            this.btnEnter.TabIndex = 14;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(152, 203);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 22);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(163, 165);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(54, 22);
            this.labelLogin.TabIndex = 12;
            this.labelLogin.Text = "Логин";
            // 
            // labelEnter
            // 
            this.labelEnter.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnter.Location = new System.Drawing.Point(84, 80);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(396, 64);
            this.labelEnter.TabIndex = 11;
            this.labelEnter.Text = "Вход в аккаунт";
            this.labelEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(223, 168);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(148, 20);
            this.tbLogin.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SlateBlue;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(289, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 45);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mtbPassword
            // 
            this.mtbPassword.Location = new System.Drawing.Point(221, 206);
            this.mtbPassword.Name = "mtbPassword";
            this.mtbPassword.Size = new System.Drawing.Size(150, 20);
            this.mtbPassword.TabIndex = 16;
            // 
            // panelHeading
            // 
            this.panelHeading.BackColor = System.Drawing.Color.SlateBlue;
            this.panelHeading.Controls.Add(this.labelHeading);
            this.panelHeading.Controls.Add(this.pBLogo);
            this.panelHeading.Location = new System.Drawing.Point(-2, -4);
            this.panelHeading.Name = "panelHeading";
            this.panelHeading.Size = new System.Drawing.Size(582, 81);
            this.panelHeading.TabIndex = 17;
            // 
            // labelHeading
            // 
            this.labelHeading.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeading.Location = new System.Drawing.Point(96, 13);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(449, 52);
            this.labelHeading.TabIndex = 8;
            this.labelHeading.Text = "Магазин одежды \"Миндаль\"";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBLogo
            // 
            this.pBLogo.Image = global::mindalSHOP.Properties.Resources.store;
            this.pBLogo.Location = new System.Drawing.Point(16, 13);
            this.pBLogo.Name = "pBLogo";
            this.pBLogo.Size = new System.Drawing.Size(74, 58);
            this.pBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBLogo.TabIndex = 8;
            this.pBLogo.TabStop = false;
            // 
            // autorisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 363);
            this.Controls.Add(this.panelHeading);
            this.Controls.Add(this.mtbPassword);
            this.Controls.Add(this.labelReg);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelEnter);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "autorisationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.panelHeading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MaskedTextBox mtbPassword;
        private System.Windows.Forms.Panel panelHeading;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.PictureBox pBLogo;
    }
}

