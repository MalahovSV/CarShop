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
            this.CloseWindow = new System.Windows.Forms.Label();
            this.FramePanel = new System.Windows.Forms.Panel();
            this.VariableUser = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // CloseWindow
            // 
            this.CloseWindow.AutoSize = true;
            this.CloseWindow.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.CloseWindow.Location = new System.Drawing.Point(748, 9);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(24, 25);
            this.CloseWindow.TabIndex = 6;
            this.CloseWindow.Text = "X";
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            this.CloseWindow.MouseEnter += new System.EventHandler(this.CloseWindow_MouseEnter);
            this.CloseWindow.MouseLeave += new System.EventHandler(this.CloseWindow_MouseLeave);
            // 
            // FramePanel
            // 
            this.FramePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FramePanel.Location = new System.Drawing.Point(185, 134);
            this.FramePanel.Name = "FramePanel";
            this.FramePanel.Size = new System.Drawing.Size(400, 300);
            this.FramePanel.TabIndex = 7;
            // 
            // VariableUser
            // 
            this.VariableUser.AutoSize = true;
            this.VariableUser.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.VariableUser.Location = new System.Drawing.Point(21, 532);
            this.VariableUser.Name = "VariableUser";
            this.VariableUser.Size = new System.Drawing.Size(140, 20);
            this.VariableUser.TabIndex = 8;
            this.VariableUser.TabStop = true;
            this.VariableUser.Text = "Я пользователь";
            this.VariableUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VariableUser_LinkClicked);
            this.VariableUser.MouseEnter += new System.EventHandler(this.VariableUser_MouseEnter);
            this.VariableUser.MouseLeave += new System.EventHandler(this.VariableUser_MouseLeave);
            // 
            // AutorisationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.BackgroundImage = global::CarShop.Properties.Resources.backgroundAutorisation;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.VariableUser);
            this.Controls.Add(this.FramePanel);
            this.Controls.Add(this.CloseWindow);
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
        private System.Windows.Forms.Label CloseWindow;
        private System.Windows.Forms.Panel FramePanel;
        private System.Windows.Forms.LinkLabel VariableUser;
    }
}

