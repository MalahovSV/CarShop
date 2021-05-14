namespace CarShop
{
    partial class AutorisationWindow
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
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.AutorisationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowPasswordCheck = new System.Windows.Forms.CheckBox();
            this.CloseWindow = new System.Windows.Forms.Label();
            this.ConnectionLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(292, 205);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(5);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(237, 27);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.Text = "sysadmin";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(292, 245);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(5);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '•';
            this.PasswordBox.Size = new System.Drawing.Size(237, 27);
            this.PasswordBox.TabIndex = 1;
            // 
            // AutorisationButton
            // 
            this.AutorisationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutorisationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.AutorisationButton.Location = new System.Drawing.Point(327, 324);
            this.AutorisationButton.Margin = new System.Windows.Forms.Padding(5);
            this.AutorisationButton.Name = "AutorisationButton";
            this.AutorisationButton.Size = new System.Drawing.Size(160, 57);
            this.AutorisationButton.TabIndex = 2;
            this.AutorisationButton.Text = "Войти";
            this.AutorisationButton.UseVisualStyleBackColor = true;
            this.AutorisationButton.Click += new System.EventHandler(this.AutorisationButton_Click);
            this.AutorisationButton.MouseEnter += new System.EventHandler(this.AutorisationButton_MouseEnter);
            this.AutorisationButton.MouseLeave += new System.EventHandler(this.AutorisationButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(190, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(190, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // ShowPasswordCheck
            // 
            this.ShowPasswordCheck.AutoSize = true;
            this.ShowPasswordCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.ShowPasswordCheck.Location = new System.Drawing.Point(292, 280);
            this.ShowPasswordCheck.Name = "ShowPasswordCheck";
            this.ShowPasswordCheck.Size = new System.Drawing.Size(169, 24);
            this.ShowPasswordCheck.TabIndex = 5;
            this.ShowPasswordCheck.Text = "Показать пароль";
            this.ShowPasswordCheck.UseVisualStyleBackColor = false;
            this.ShowPasswordCheck.Click += new System.EventHandler(this.ShowPasswordCheck_Click);
            this.ShowPasswordCheck.MouseEnter += new System.EventHandler(this.ShowPasswordCheck_MouseEnter);
            this.ShowPasswordCheck.MouseLeave += new System.EventHandler(this.ShowPasswordCheck_MouseLeave);
            // 
            // CloseWindow
            // 
            this.CloseWindow.AutoSize = true;
            this.CloseWindow.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseWindow.Location = new System.Drawing.Point(748, 9);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(24, 25);
            this.CloseWindow.TabIndex = 6;
            this.CloseWindow.Text = "X";
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            this.CloseWindow.MouseEnter += new System.EventHandler(this.CloseWindow_MouseEnter);
            this.CloseWindow.MouseLeave += new System.EventHandler(this.CloseWindow_MouseLeave);
            // 
            // ConnectionLink
            // 
            this.ConnectionLink.AutoSize = true;
            this.ConnectionLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.ConnectionLink.Location = new System.Drawing.Point(305, 400);
            this.ConnectionLink.Name = "ConnectionLink";
            this.ConnectionLink.Size = new System.Drawing.Size(207, 20);
            this.ConnectionLink.TabIndex = 7;
            this.ConnectionLink.TabStop = true;
            this.ConnectionLink.Text = "Установить соединение";
            this.ConnectionLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ConnectionLink_LinkClicked);
            this.ConnectionLink.MouseEnter += new System.EventHandler(this.linkLabel1_MouseEnter);
            this.ConnectionLink.MouseLeave += new System.EventHandler(this.ConnectionLink_MouseLeave);
            // 
            // AutorisationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.BackgroundImage = global::CarShop.Properties.Resources.backgroundAutorisation;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ConnectionLink);
            this.Controls.Add(this.CloseWindow);
            this.Controls.Add(this.ShowPasswordCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutorisationButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AutorisationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AutorisationWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button AutorisationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ShowPasswordCheck;
        private System.Windows.Forms.Label CloseWindow;
        private System.Windows.Forms.LinkLabel ConnectionLink;
    }
}

