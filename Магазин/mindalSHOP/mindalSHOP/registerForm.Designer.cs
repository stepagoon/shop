
namespace mindalSHOP
{
    partial class registerForm
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
            this.tbPasswordReg = new System.Windows.Forms.TextBox();
            this.tbLoginReg = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelSurrname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPasswordReg
            // 
            this.tbPasswordReg.Location = new System.Drawing.Point(186, 258);
            this.tbPasswordReg.Name = "tbPasswordReg";
            this.tbPasswordReg.Size = new System.Drawing.Size(157, 20);
            this.tbPasswordReg.TabIndex = 35;
            // 
            // tbLoginReg
            // 
            this.tbLoginReg.Location = new System.Drawing.Point(186, 218);
            this.tbLoginReg.Name = "tbLoginReg";
            this.tbLoginReg.Size = new System.Drawing.Size(157, 20);
            this.tbLoginReg.TabIndex = 34;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(117, 255);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 22);
            this.labelPassword.TabIndex = 33;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(126, 215);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(54, 22);
            this.labelLogin.TabIndex = 32;
            this.labelLogin.Text = "Логин";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SlateBlue;
            this.btnBack.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(221, 311);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(203, 59);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.SlateBlue;
            this.btnReg.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReg.Location = new System.Drawing.Point(12, 310);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(203, 59);
            this.btnReg.TabIndex = 30;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(186, 179);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(157, 20);
            this.tbNumber.TabIndex = 29;
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
            // 
            // tbSecondName
            // 
            this.tbSecondName.Location = new System.Drawing.Point(185, 140);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(157, 20);
            this.tbSecondName.TabIndex = 28;
            this.tbSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSecondName_KeyPress);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(186, 97);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(157, 20);
            this.tbFirstName.TabIndex = 27;
            this.tbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFirstName_KeyPress);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(46, 176);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(134, 22);
            this.labelPhone.TabIndex = 26;
            this.labelPhone.Text = "Номер телефона";
            // 
            // labelSurrname
            // 
            this.labelSurrname.AutoSize = true;
            this.labelSurrname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurrname.Location = new System.Drawing.Point(99, 137);
            this.labelSurrname.Name = "labelSurrname";
            this.labelSurrname.Size = new System.Drawing.Size(76, 22);
            this.labelSurrname.TabIndex = 25;
            this.labelSurrname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(139, 94);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 22);
            this.labelName.TabIndex = 24;
            this.labelName.Text = "Имя";
            // 
            // labelHeading
            // 
            this.labelHeading.BackColor = System.Drawing.Color.SlateBlue;
            this.labelHeading.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeading.Location = new System.Drawing.Point(-11, -5);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(463, 62);
            this.labelHeading.TabIndex = 36;
            this.labelHeading.Text = "Регистрация пользователя";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 382);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.tbPasswordReg);
            this.Controls.Add(this.tbLoginReg);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelSurrname);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPasswordReg;
        private System.Windows.Forms.TextBox tbLoginReg;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelSurrname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHeading;
    }
}