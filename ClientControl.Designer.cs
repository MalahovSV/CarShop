
namespace CarShop
{
    partial class ClientControl
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
            this.ClientFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientFormButton
            // 
            this.ClientFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientFormButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.ClientFormButton.Location = new System.Drawing.Point(120, 122);
            this.ClientFormButton.Margin = new System.Windows.Forms.Padding(5);
            this.ClientFormButton.Name = "ClientFormButton";
            this.ClientFormButton.Size = new System.Drawing.Size(160, 57);
            this.ClientFormButton.TabIndex = 11;
            this.ClientFormButton.Text = "Перейти к каталогу";
            this.ClientFormButton.UseVisualStyleBackColor = true;
            this.ClientFormButton.Click += new System.EventHandler(this.ClientFormButton_Click);
            this.ClientFormButton.MouseEnter += new System.EventHandler(this.ClientFormButton_MouseEnter);
            this.ClientFormButton.MouseLeave += new System.EventHandler(this.ClientFormButton_MouseLeave);
            // 
            // ClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.ClientFormButton);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ClientControl";
            this.Size = new System.Drawing.Size(400, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClientFormButton;
    }
}
