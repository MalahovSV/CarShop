
namespace CarShop
{
    partial class UserWindow
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectionLink = new System.Windows.Forms.LinkLabel();
            this.ShowPasswordCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AutorisationButton = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConnectionLink
            // 
            this.ConnectionLink.AutoSize = true;
            this.ConnectionLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.ConnectionLink.Location = new System.Drawing.Point(135, 238);
            this.ConnectionLink.Name = "ConnectionLink";
            this.ConnectionLink.Size = new System.Drawing.Size(207, 20);
            this.ConnectionLink.TabIndex = 14;
            this.ConnectionLink.TabStop = true;
            this.ConnectionLink.Text = "Установить соединение";
            this.ConnectionLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ConnectionLink_LinkClicked);
            this.ConnectionLink.MouseEnter += new System.EventHandler(this.ConnectionLink_MouseEnter);
            this.ConnectionLink.MouseLeave += new System.EventHandler(this.ConnectionLink_MouseLeave);
            // 
            // ShowPasswordCheck
            // 
            this.ShowPasswordCheck.AutoSize = true;
            this.ShowPasswordCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.ShowPasswordCheck.Location = new System.Drawing.Point(122, 118);
            this.ShowPasswordCheck.Name = "ShowPasswordCheck";
            this.ShowPasswordCheck.Size = new System.Drawing.Size(169, 24);
            this.ShowPasswordCheck.TabIndex = 13;
            this.ShowPasswordCheck.Text = "Показать пароль";
            this.ShowPasswordCheck.UseVisualStyleBackColor = false;
            this.ShowPasswordCheck.CheckedChanged += new System.EventHandler(this.ShowPasswordCheck_CheckedChanged);
            this.ShowPasswordCheck.MouseEnter += new System.EventHandler(this.ShowPasswordCheck_MouseEnter);
            this.ShowPasswordCheck.MouseLeave += new System.EventHandler(this.ShowPasswordCheck_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Логин";
            // 
            // AutorisationButton
            // 
            this.AutorisationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutorisationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.AutorisationButton.Location = new System.Drawing.Point(157, 162);
            this.AutorisationButton.Margin = new System.Windows.Forms.Padding(5);
            this.AutorisationButton.Name = "AutorisationButton";
            this.AutorisationButton.Size = new System.Drawing.Size(160, 57);
            this.AutorisationButton.TabIndex = 10;
            this.AutorisationButton.Text = "Войти";
            this.AutorisationButton.UseVisualStyleBackColor = true;
            this.AutorisationButton.Click += new System.EventHandler(this.AutorisationButton_Click);
            this.AutorisationButton.MouseEnter += new System.EventHandler(this.AutorisationButton_MouseEnter);
            this.AutorisationButton.MouseLeave += new System.EventHandler(this.AutorisationButton_MouseLeave);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(122, 83);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(5);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '•';
            this.PasswordBox.Size = new System.Drawing.Size(237, 27);
            this.PasswordBox.TabIndex = 9;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(122, 43);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(5);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(237, 27);
            this.LoginBox.TabIndex = 8;
            this.LoginBox.Text = "sysadmin";
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.ConnectionLink);
            this.Controls.Add(this.ShowPasswordCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutorisationButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserWindow";
            this.Size = new System.Drawing.Size(400, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ConnectionLink;
        private System.Windows.Forms.CheckBox ShowPasswordCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AutorisationButton;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox LoginBox;
    }
}
